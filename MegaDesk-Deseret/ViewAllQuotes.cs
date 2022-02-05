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
    public partial class ViewAllQuotes : Form
    {
        readonly List<DeskQuote> _quotes = JsonData.Read();

        public ViewAllQuotes()
        {
            InitializeComponent();
            // TODO: Add all 8 columns to dataGridView1
            DisplayQuotes();
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

        private void DisplayQuotes()
        {
            _quotes.ForEach(quote =>
            {
                dataGridView1.Rows.Add
                (
                    quote.FirstName,
                    quote.LastName,
                    quote.Desk.DesktopMaterial.ToString(),
                    quote.Desk.Width.ToString(),
                    quote.Desk.Depth.ToString(),
                    quote.Desk.DrawerCount.ToString(),
                    quote.CalculateQuote().ToString(),
                    quote.Desk.ProductionDays.ToString()
                );
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
