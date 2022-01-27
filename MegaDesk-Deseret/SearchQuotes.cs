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
    public partial class SearchQuotes : Form
    {
        readonly List<DeskQuote> _quotes = JsonData.Read();

        public SearchQuotes()
        {
            InitializeComponent();
            List<Desk.DesktopMaterial> MaterialList = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            materialOpts.DataSource = MaterialList;
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
    }
}
