using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid.Properties
{
    public partial class YouWin : Form
    {
        public YouWin()
        {
            InitializeComponent();
            bttnNext.MouseEnter += new EventHandler(bttnNext_MouseEnter);
            bttnNext.MouseLeave += new EventHandler(bttnNext_MouseLeave);

            bttnMenu.MouseEnter += new EventHandler(bttnMenu_MouseEnter);
            bttnMenu.MouseLeave += new EventHandler(bttnMenu_MouseLeave);

            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        void bttnNext_MouseEnter(object sender, EventArgs e)
        {
            this.bttnMenu.Image = ((System.Drawing.Image)(Properties.Resources.Next_Select_Btn));
            this.bttnMenu.BackgroundImage = null;
        }
        void bttnNext_MouseLeave(object sender, EventArgs e)
        {
            this.bttnMenu.Image = ((System.Drawing.Image)(Properties.Resources.Next_Btn));
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

        private void bttnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
