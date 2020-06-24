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
    public partial class Winner : UserControl
    {
        public Action backToMenuW;
        public Winner()
        {
            {
                InitializeComponent();
                bttnNext.MouseEnter += new EventHandler(bttnNext_MouseEnter);
                bttnNext.MouseLeave += new EventHandler(bttnNext_MouseLeave);

                bttnMenu.MouseEnter += new EventHandler(bttnMenu_MouseEnter);
                bttnMenu.MouseLeave += new EventHandler(bttnMenu_MouseLeave);

                Height = ClientSize.Height;
                Width = ClientSize.Width;
            }

            void bttnNext_MouseEnter(object sender, EventArgs e)
            {
                bttnNext.BackgroundImage = null;
                bttnNext.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Next_Select_Btn));
            }
            void bttnNext_MouseLeave(object sender, EventArgs e)
            {
                bttnNext.BackgroundImage = null;
                bttnNext.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Next_Btn));

            }
            void bttnMenu_MouseEnter(object sender, EventArgs e)
            {
                bttnMenu.BackgroundImage = null;
                bttnMenu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Menu_Select_Btnt));
            }
            void bttnMenu_MouseLeave(object sender, EventArgs e)
            {
                bttnNext.BackgroundImage = null;
                bttnMenu.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Menu_Btn));
            }
        }
        private void bttnMenu_Click(object sender, EventArgs e)
        {
            backToMenuW.Invoke();
        }
    }
}
