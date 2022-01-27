using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Deseret
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            this.rushOpt.SelectedIndex = 0; // default value for ComboBox
        }

        /// <summary>
        /// Go back to main menu. Triggers on Back Button click.
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        /// <summary>
        /// On Submit Button click, validate values and attempt to <c>ShowDisplayQuoteForm()</c>.
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateName(fname) ||
                !ValidateName(lname) ||
                !ValidateWidth() ||
                !ValidateDepth() ||
                !ValidateDrawerCount() ||
                !ValidateRushOpt() ||
                !ValidateMaterialOpts())
            {
                // prevent redirect to DisplayQuote if any value does not validate
                return;
            }
            // get DesktopMaterial enum value
            var materialOpt = materialOpts.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            var desktopMaterial = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), materialOpt);

            // get Rush Option value as integer (number of days)
            var productionDays = Convert.ToInt32(rushOpt.SelectedValue);

            // produce desk and quote objects
            var desk = new Desk(width.Value, depth.Value, (int)drawerCount.Value, desktopMaterial, productionDays);
            var quote = new DeskQuote(fname.Text, lname.Text, desk);

            // save new quote to JSON
            JsonData.Write(quote);
            // open DisplayQuote form
            ShowDisplayQuoteForm(quote);
        }

        /// <summary>
        /// Open the DisplayQuote Form.
        /// </summary>
        private void ShowDisplayQuoteForm(DeskQuote quote)
        {
            // create DisplayQuote
            var displayQuoteForm = new DisplayQuote(quote);
            // instead of tagging _this_ form, tag the MainMenu from "this.Tag"
            displayQuoteForm.Tag = this.Tag;
            // show the DisplayQuote form
            displayQuoteForm.Show(this);
            // hide the AddQuote form
            Hide();
        }

        /******************** VALUE CHANGE AND LEAVE FOCUS EVENT HANDLERS ********************/

        /// <summary>
        /// On <c>fname</c> or <c>lname</c> ValueChange or LeaveFocus event, call <c>ValidateName()</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void name_ValueChanged(object sender, EventArgs e)
        {
            // try to cast "sender" to a PlaceHolderTextBox
            try
            {
                PlaceHolderTextBox nameInput = sender as PlaceHolderTextBox;
                ValidateName(nameInput);
            }
            // if there's a problem, throw
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex.Message);
#endif
                throw ex;
            }
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            ValidateWidth();
        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {
            ValidateDepth();
        }

        private void drawerCount_ValueChanged(object sender, EventArgs e)
        {
            ValidateDrawerCount();
        }

        private void rushOpt_ValueChanged(object sender, EventArgs e)
        {
            ValidateRushOpt();
        }

        private void materialOpts_ValueChanged(object sender, EventArgs e)
        {
            ValidateMaterialOpts();
        }

        /******************** VALIDATE INPUT VALUES ********************/

        private bool ValidateName(PlaceHolderTextBox nameInput)
        {
            // fname or lname must not be empty or contain a number
            if (nameInput.Text.Length == 0 || nameInput.Text.Any(char.IsDigit))
            {
                nameInput.BackColor = Color.Red;
                return false;
            }
            else
            {
                nameInput.BackColor = Color.Empty;
                return true;
            }
        }

        private bool ValidateWidth()
        {
            // cast to string for IsDigit check
            var widthString = width.Value.ToString();
            // if between 24-96 && it is comprised of only digits
            if (width.Value < 24 || width.Value > 96 || !widthString.Any(char.IsDigit))
            {
                width.BackColor = Color.Red;
                return false;
            }
            else
            {
                width.BackColor = Color.Empty;
                return true;
            }
        }

        private bool ValidateDepth()
        {
            // cast to string for IsDigit check
            var depthString = depth.Value.ToString();
            // check if between 12-48 && it is comprised of only digits
            if (depth.Value < 12 || depth.Value > 48 || !depthString.Any(char.IsDigit))
            {
                depth.BackColor = Color.Red;
                return false;
            }
            else
            {
                depth.BackColor = Color.Empty;
                return true;
            }
        }

        private bool ValidateDrawerCount()
        {
            // check if between 0-7
            if (drawerCount.Value < 0 || drawerCount.Value > 7)
            {
                drawerCount.BackColor = Color.Red;
                return false;
            }
            else
            {
                drawerCount.BackColor = Color.Empty;
                return true;
            }
        }

        private bool ValidateRushOpt()
        {
            // check if the selected index is between 0-3
            if (rushOpt.SelectedIndex < 0 || rushOpt.SelectedIndex > 3)
            {
                rushOpt.BackColor = Color.Red;
                return false;
            }
            else
            {
                rushOpt.BackColor = Color.Empty;
                return true;
            }
        }

        private bool ValidateMaterialOpts()
        {
            // get the first "checked" radio button in the GroupBox or null
            var material = materialOpts.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            // check if a value has been selected
            if (material == null)
            {
                materialOpts.BackColor = Color.Red;
                return false;
            }
            else
            {
                materialOpts.BackColor = Color.Empty;
                return true;
            }
        }

        private void rushOpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
