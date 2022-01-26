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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Go to AddQuote Form.
        /// </summary>
        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            Hide();
        }

        /// <summary>
        /// Go to ViewAllQuotes Form.
        /// </summary>
        private void viewQuotesBtn_Click(object sender, EventArgs e)
        {
            var viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.Tag = this;
            viewQuotesForm.Show(this);
            Hide();
        }

        /// <summary>
        /// Go to SearchQuotes Form.
        /// </summary>
        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
