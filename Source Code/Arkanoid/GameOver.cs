using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();

            bttnMenu.MouseEnter += new EventHandler(bttnMenu_MouseEnter);
            bttnMenu.MouseLeave += new EventHandler(bttnMenu_MouseLeave);

            WindowState = FormWindowState.Maximized;
        }

        void bttnMenu_MouseEnter(object sender, EventArgs e)
        {
            this.bttnMenu.Image = ((System.Drawing.Image)(Properties.Resources.Menu_Select_Btnt));
            this.bttnMenu.BackgroundImage = null;
        }
        void bttnMenu_MouseLeave(object sender, EventArgs e)
        {
            this.bttnMenu.Image = ((System.Drawing.Image)(Properties.Resources.Menu_Btn));
        }

        private void bttnMenu_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            menu.ShowDialog();
            this.Close();
        }
    }
}
