using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strange_Tides
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void pickShipButton_Click(object sender, EventArgs e)
        {
            var shipForm = new ShipSelection();
            this.Close();
            shipForm.Show();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
