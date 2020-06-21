namespace Arkanoid
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnStartGame = new System.Windows.Forms.Button();
            this.bttnHighScore = new System.Windows.Forms.Button();
            this.bttnExitApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.37897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16667F));
            this.tableLayoutPanel1.Controls.Add(this.bttnHighScore, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnExitApplication, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnStartGame, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttnStartGame
            // 
            this.bttnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnStartGame.BackColor = System.Drawing.Color.Black;
            this.bttnStartGame.BackgroundImage = global::Arkanoid.Properties.Resources.Start_Btn;
            this.bttnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnStartGame.FlatAppearance.BorderSize = 0;
            this.bttnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnStartGame.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStartGame.Location = new System.Drawing.Point(221, 148);
            this.bttnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.bttnStartGame.Name = "bttnStartGame";
            this.bttnStartGame.Size = new System.Drawing.Size(160, 69);
            this.bttnStartGame.TabIndex = 0;
            this.bttnStartGame.UseVisualStyleBackColor = false;
            this.bttnStartGame.Click += new System.EventHandler(this.BttnStartGame_Click);
            // 
            // bttnHighScore
            // 
            this.bttnHighScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHighScore.BackColor = System.Drawing.Color.Black;
            this.bttnHighScore.BackgroundImage = global::Arkanoid.Properties.Resources.HighScore_Btn;
            this.bttnHighScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnHighScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHighScore.Location = new System.Drawing.Point(221, 221);
            this.bttnHighScore.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHighScore.Name = "bttnHighScore";
            this.bttnHighScore.Size = new System.Drawing.Size(160, 69);
            this.bttnHighScore.TabIndex = 0;
            this.bttnHighScore.UseVisualStyleBackColor = false;
            this.bttnHighScore.Click += new System.EventHandler(this.BttnViewTop_Click);
            // 
            // bttnExitApplication
            // 
            this.bttnExitApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnExitApplication.BackColor = System.Drawing.Color.Black;
            this.bttnExitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnExitApplication.BackgroundImage")));
            this.bttnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExitApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExitApplication.Location = new System.Drawing.Point(221, 294);
            this.bttnExitApplication.Margin = new System.Windows.Forms.Padding(2);
            this.bttnExitApplication.Name = "bttnExitApplication";
            this.bttnExitApplication.Size = new System.Drawing.Size(160, 70);
            this.bttnExitApplication.TabIndex = 0;
            this.bttnExitApplication.UseVisualStyleBackColor = false;
            this.bttnExitApplication.Click += new System.EventHandler(this.BttnExitApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Arkanoid.Properties.Resources.Title_Arkanoid;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(117, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 142);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnStartGame;
        private System.Windows.Forms.Button bttnHighScore;
        private System.Windows.Forms.Button bttnExitApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

