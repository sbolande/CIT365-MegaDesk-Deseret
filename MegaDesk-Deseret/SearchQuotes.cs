using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Deseret
{
    public partial class SearchQuotes : Form
    {
        readonly List<DeskQuote> _quotes = JsonData.Read();

        public SearchQuotes()
        {
            InitializeComponent();
            var materialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            materialOpts.DataSource = materialList;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MaterialSelected = materialOpts.SelectedItem.ToString();

                if (_quotes == null || !_quotes.Any())
                {
                    MessageBox.Show("No quote found", "Error Reading File");
                }
                else
                {
                    listViewResults.Columns.Add("#", 30, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Name", 119, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Date", 75, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Width", 50, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Depth", 50, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Drawers", 55, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Material", 90, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Days", 50, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Total", 60, HorizontalAlignment.Center);

                    int quoteCount = 0;
                    string[] fieldvalue = MaterialSelected.Split(',');
                    if (fieldvalue[5] == MaterialSelected)
                    {
                        quoteCount++;
                        listViewResults.Items.Add(new ListViewItem(new[] { quoteCount.ToString(), fieldvalue[0], fieldvalue[1], fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], "$" + fieldvalue[7] }));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialOpts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
