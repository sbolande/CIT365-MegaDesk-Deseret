using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _quote;

        /// <summary>
        /// DisplayQuote Constructor. Must take a DeskQuote obj to have something to display.
        /// </summary>
        public DisplayQuote(DeskQuote quote)
        {
            _quote = quote;
            InitializeComponent();
            DisplayQuoteData();
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
        /// Fill in the TextBoxes with the values from this._quote
        /// </summary>
        private void DisplayQuoteData()
        {
            name.Text = $"{_quote.FirstName} {_quote.LastName}";
            date.Text = _quote.QuoteDate.ToString("g");
            area.Text = $"{_quote.Desk.Width} × {_quote.Desk.Depth}";
            drawerCount.Text = _quote.Desk.DrawerCount.ToString();
            desktopMaterial.Text = _quote.Desk.DesktopMaterial.ToString();
            productionDays.Text = _quote.Desk.ProductionDays.ToString();
            quotePrice.Text = _quote.Value.ToString("0.00");
        }
    }
}
