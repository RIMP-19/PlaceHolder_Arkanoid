using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Controller;
using Arkanoid.Model;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Arkanoid
{
    public partial class HighScores : UserControl
    {
        private Font customFont;
        public Action backMenu; 
        private List<Control> labels;
        public HighScores()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            backMenu.Invoke();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = null;
            btnBack.BackgroundImage = Properties.Resources.Menu_Select_Btnt;
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = null;
            btnBack.BackgroundImage = Properties.Resources.Menu_Btn;
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            customFont = new Font(CustomFontInit().Families[0], 16);
            labels = new List<Control>();

            foreach (Label l in Controls.OfType<Label>())
                l.Font = customFont;

            //foreach (Control control in Controls)
            //{
            //    if(control.GetType() == typeof(Label))
            //    {
            //        labels.Add(control);
            //    }
            //}

            //foreach (Label lbl in labels)
            //{
            //    lbl.Font = customFont;
            //}
            RefreshData();
        }

        public void RefreshData()
        {
            var top10 = PlayerDAO.GetTop10();
            int i = 0, j = 0;
            if (top10 == null)
                return;

            foreach (Label l in tlpMainHS.Controls.OfType<Label>())
            {
                if (l.Name == $"lblTop{i + 1}")
                {
                    l.Text = top10[i].UserName;
                    i++;
                }
                else if (l.Name == $"lblScore{j + 1}")
                {
                    l.Text = top10[j].Score.ToString();
                    j++;
                }
            }                

            //foreach (Label lbl in labels)
            //{
            //    if (nameof(lbl) == $"lblTop{i+1}")
            //    {
            //        lbl.Text = top10[i].UserName;
            //    }
            //    else if (nameof(lbl) == $"lblScore{i+1}")
            //    {
            //        lbl.Text = top10[i].Score.ToString();
            //    }

            //    i++;
            //}
        }


        private PrivateFontCollection CustomFontInit()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.OSA.Length;
            byte[] fontdata = Properties.Resources.OSA;

            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            return pfc;
        }
    }
}
