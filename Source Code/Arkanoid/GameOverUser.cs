using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameOverUser : UserControl
    {
        public Action backToMenu;
        public GameOverUser()
        {
            InitializeComponent();
            bttnMenu.MouseEnter += new EventHandler(bttnMenu_Enter);
            bttnMenu.MouseLeave += new EventHandler(bttnMenu_Leave);
        }

        private void bttnMenu_Click(object sender, EventArgs e)
        {
            backToMenu.Invoke();
        }

        private void bttnMenu_Enter(object sender, EventArgs e)
        {
            bttnMenu.BackgroundImage = null;
            bttnMenu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Menu_Select_Btnt));
        }

        private void bttnMenu_Leave(object sender, EventArgs e)
        {
            bttnMenu.BackgroundImage = null;
            bttnMenu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Menu_Btn));
        }
    }
}
