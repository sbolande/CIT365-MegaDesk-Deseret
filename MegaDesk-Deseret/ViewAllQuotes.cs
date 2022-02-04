using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Deseret
{
    public partial class ViewAllQuotes : Form
    {
        readonly List<DeskQuote> _quotes = JsonData.Read();

        private const string _filepath = @"./quotes.json";

        

        public ViewAllQuotes()
        {
            InitializeComponent();
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

            List<DeskQuote> quotes = JsonData.Read();
            Console.WriteLine(quotes);


            foreach (DeskQuote quote in quotes)
            {
                string[] row = {quote.FirstName, quote.LastName, quote.Desk.DesktopMaterial.ToString(), quote.Desk.Width.ToString(), quote.Desk.Depth.ToString(),
                quote.Desk.DrawerCount.ToString(), quote.CalculateQuote().ToString(), quote.Desk.ProductionDays.ToString() };
                dataGridView1.Rows.Add(row);

                //This is just to make sure stuff is getting passed to the small text box. (just a check)
                textBox1.Text = row[7];
         
                
                
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
