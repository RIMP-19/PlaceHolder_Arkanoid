using Arkanoid.Model;
using Arkanoid.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private ControlArkanoid ca;
        private GameOverUser gO;
        private LogIn start;
        private HighScores topScores;
        public Player player; 
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
            bttnStartGame.BackgroundImage = null;
            bttnStartGame.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Start_Select_Btn));
        }
        void bttnStartGame_MouseLeave(object sender, EventArgs e)
        {
            bttnStartGame.BackgroundImage = null;
            bttnStartGame.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Start_Btn));
        }
        void bttnHighScore_MouseEnter(object sender, EventArgs e)
        { 
            bttnHighScore.BackgroundImage = null;
            bttnHighScore.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HighScore_Select_Btn));
        }
        void bttnHighScore_MouseLeave(object sender, EventArgs e)
        {
            bttnHighScore.BackgroundImage = null;
            bttnHighScore.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HighScore_Btn));
        }
        void bttnExitApplication_MouseEnter(object sender, EventArgs e) {
            bttnExitApplication.BackgroundImage = null;
            bttnExitApplication.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Exit_Select_Btn));
            
        }
        void bttnExitApplication_MouseLeave(object sender, EventArgs e)
        {
            bttnExitApplication.BackgroundImage = null;
            bttnExitApplication.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Exit_Btn));
        }

        bool gP;

      
        private void Form1_Load(object sender, EventArgs e)
        {
            start = new LogIn { Dock = DockStyle.Fill};
            topScores = new HighScores { Dock = DockStyle.Fill };
            ca = new ControlArkanoid();

            ca.Dock = DockStyle.Fill;

            ca.Width = Width;
            ca.Height = Height;



            //cuando termina el juego 
            /* ca.TerminarJuego = (wol) =>
             {
                 ca = null;
                 ca = new ControlArkanoid();
                 ca.Hide();
                 if (wol)
                 {
                 }
                 else
                 {
                     var go = new GameOverUser();
                     Controls.Add(go);
                 }
                 //tableLayoutPanel1.Show();

             };*/

            start.startGame = () =>
            {
                Controls.Remove(start);
                Controls.Add(ca);
            };

            topScores.backMenu = () => 
            {
                Controls.Remove(topScores);
                tableLayoutPanel1.Show();
            };

            ca.GamePage = (wo) =>
            {
                gP = wo;
            };

            ca.TerminarJuego = () =>
            {
                ca = null;
                ca = new ControlArkanoid();
                ca.Refresh();
                ca.Hide();

                if (gP) {


                }
                else
                {
                    tableLayoutPanel1.Show();
                }


            };
            bttnStartGame.Focus();
        }

        private void BttnStartGame_Click(object sender, EventArgs e)
        {            
            tableLayoutPanel1.Hide();
            Controls.Add(start);            
        }

        private void BttnViewTop_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            Controls.Add(topScores);
            topScores.RefreshData();
        }

        private void BttnExitApplication_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
