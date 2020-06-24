using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Arkanoid.Model;

namespace Arkanoid.View
{
    public partial class LogIn : UserControl
    {
        public Action startGame;
        private Form1 parentForm;
        public LogIn()
        {
            InitializeComponent();
            lblName.Font = new Font(CustomFontInit().Families[0], lblName.Font.Size);
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

        private void BtnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = null;
            btnNext.BackgroundImage = Properties.Resources.Next_Select_Btn;
        }

        private void BtnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = null;
            btnNext.BackgroundImage = Properties.Resources.Next_Btn;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            
            if (txtUser.Text == "") { 
                MessageBox.Show("No se permite dejar vacío el nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPlayer = new Player
            {
                UserName = txtUser.Text,
                Score = 0
            };

            parentForm.player.UserName = newPlayer.UserName;
            parentForm.player.Score = newPlayer.Score;

            PlayerDAO.CreateNew(newPlayer);
            startGame.Invoke();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            parentForm = (this.Parent as Form1);
            txtUser.Text = "";
        }
    }
}
