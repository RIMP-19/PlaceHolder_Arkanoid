using Arkanoid.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private ControlArkanoid ca;
        public Form1()
        {
            InitializeComponent();
            //Start button image
            bttnStartGame.MouseEnter += new EventHandler(bttnStartGame_MouseEnter);
            bttnStartGame.MouseLeave += new EventHandler(bttnStartGame_MouseLeave);

            //High score button image
            bttnHighScore.MouseEnter += new EventHandler(bttnHighScore_MouseEnter);
            bttnHighScore.MouseLeave += new EventHandler(bttnHighScore_MouseLeave);
            //Exit button image
            bttnExitApplication.MouseEnter += new EventHandler(bttnExitApplication_MouseEnter);
            bttnExitApplication.MouseLeave += new EventHandler(bttnExitApplication_MouseLeave);


            // Maximizar ventana en su creacion
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;

        }

        //Buttons change image
        void bttnStartGame_MouseEnter(object sender, EventArgs e)
        {
            this.bttnStartGame.Image = ((System.Drawing.Image)(Properties.Resources.Start_Select_Btn));
            this.bttnStartGame.BackgroundImage = null;

        }
        void bttnStartGame_MouseLeave(object sender, EventArgs e)
        {
            this.bttnStartGame.Image = ((System.Drawing.Image)(Properties.Resources.Start_Btn));
        }
        void bttnHighScore_MouseEnter(object sender, EventArgs e)
        {
            this.bttnHighScore.Image = ((System.Drawing.Image)(Properties.Resources.HighScore_Select_Btn));
            this.bttnHighScore.BackgroundImage = null;
        }
        void bttnHighScore_MouseLeave(object sender, EventArgs e)
        {
            this.bttnHighScore.Image = ((System.Drawing.Image)(Properties.Resources.HighScore_Btn));
        }
        void bttnExitApplication_MouseEnter(object sender, EventArgs e) {
            this.bttnExitApplication.Image = ((System.Drawing.Image)(Properties.Resources.Exit_Select_Btn));
            this.bttnExitApplication.BackgroundImage = null;
        }
        void bttnExitApplication_MouseLeave(object sender, EventArgs e)
        {
            this.bttnExitApplication.Image = ((System.Drawing.Image)(Properties.Resources.Exit_Btn));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            ca = new ControlArkanoid();

            ca.Dock = DockStyle.Fill;

            ca.Width = Width;
            ca.Height = Height;

            //cuando termina el juego 
            ca.TerminarJuego = () =>
            {
                ca = null;
                ca = new ControlArkanoid();
                ca.Hide();
                //tableLayoutPanel1.Show();
            };


        }

        private void BttnStartGame_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            Controls.Add(ca);
            DatosJuego.vidas = 3;
            DatosJuego.puntaje = 0;
        }

        private void BttnViewTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sin implementar aun");
        }

        private void BttnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
