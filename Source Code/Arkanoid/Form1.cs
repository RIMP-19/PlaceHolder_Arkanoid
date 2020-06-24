﻿using Arkanoid.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        //public static Action backToMenu;
        private ControlArkanoid ca;
        private GameOverUser gO;
        private Winner w;
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
            gO = new GameOverUser
            {
                Dock = DockStyle.Fill
             };
            gO.backToMenu = () =>
            {
                Controls.Remove(gO);
                tableLayoutPanel1.Show();
            };

            w = new Winner
            {
                Dock = DockStyle.Fill
            };
            w.backToMenuW = () =>
            {
                Controls.Remove(w);
                tableLayoutPanel1.Show();
            };

            ca = new ControlArkanoid();
            ca.Dock = DockStyle.Fill;
            ca.Width = Width;
            ca.Height = Height;

            ca.GamePage = (wo) =>
            {
                gP = wo;
            };

            ca.TerminarJuego = () =>
            {
                Controls.Remove(ca);
                ca = null;
                DatosJuego.vidas = 3;
                DatosJuego.puntaje = 0;
                DatosJuego.ticksRealizados = 0;
                ca = new ControlArkanoid
                {
                    Dock = DockStyle.Fill,
                };
                ca.Width = Width;
                ca.Height = Height;

                if (gP) {
                    Controls.Add(w);
                }
                else
                {
                    Controls.Add(gO);
                }
            };
            bttnStartGame.Focus();
        }

        private void BttnStartGame_Click(object sender, EventArgs e)
        {
            DatosJuego.vidas = 3;
            DatosJuego.ticksRealizados = 0;
            DatosJuego.puntaje = 0;
            tableLayoutPanel1.Hide();
            Controls.Add(ca);
            bttnStartGame.Focus();

            ca.GamePage = (wo) =>
            {
                gP = wo;
            };

            ca.TerminarJuego = () =>
            {
                Controls.Remove(ca);
                ca = null;
                DatosJuego.vidas = 3;
                DatosJuego.puntaje = 0;
                ca = new ControlArkanoid
                {
                    Dock = DockStyle.Fill,
                };
                ca.Width = Width;
                ca.Height = Height;

                if (gP)
                {
                    Controls.Add(w);
                }
                else
                {
                    Controls.Add(gO);
                }
            };
            bttnStartGame.Focus();
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
