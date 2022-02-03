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

            listViewResults.Columns.Add("#", 40, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Name", 104, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Date", 80, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Size (W × D)", 75, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Drawers", 55, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Material", 90, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Days", 50, HorizontalAlignment.Center);
            listViewResults.Columns.Add("Total", 85, HorizontalAlignment.Center);
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

                listViewResults.Items.Clear();

                if (_quotes == null || !_quotes.Any())
                {
                    MessageBox.Show("No quote found", "Error Reading File");
                }
                else
                {
                    _quotes.Where(q => q.Desk.DesktopMaterial.ToString() == MaterialSelected)
                        .Select((quote, index) => (quote, index))
                        .ToList()
                        .ForEach(quote =>
                        {
                            var i = quote.index;
                            var q = quote.quote;
                            listViewResults.Items.Add(new ListViewItem(new[]
                            {
                                i.ToString(),
                                $"{q.FirstName} {q.LastName}",
                                q.QuoteDate.ToString(),
                                $"{(int)q.Desk.Width} × {(int)q.Desk.Depth}",
                                q.Desk.DrawerCount.ToString(),
                                q.Desk.DesktopMaterial.ToString(),
                                q.Desk.ProductionDays.ToString(),
                                $"${q.Value}"
                            }));
                        });
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
