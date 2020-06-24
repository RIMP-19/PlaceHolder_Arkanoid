namespace Arkanoid
{
    partial class GameOverUser
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverUser));
            this.tlpGO = new System.Windows.Forms.TableLayoutPanel();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGO
            // 
            this.tlpGO.ColumnCount = 5;
            this.tlpGO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGO.Controls.Add(this.bttnMenu, 2, 1);
            this.tlpGO.Controls.Add(this.pictureBox1, 1, 0);
            this.tlpGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGO.Location = new System.Drawing.Point(0, 0);
            this.tlpGO.Name = "tlpGO";
            this.tlpGO.RowCount = 3;
            this.tlpGO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpGO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGO.Size = new System.Drawing.Size(567, 365);
            this.tlpGO.TabIndex = 1;
            // 
            // bttnMenu
            // 
            this.bttnMenu.BackgroundImage = global::Arkanoid.Properties.Resources.Menu_Btn;
            this.bttnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMenu.Location = new System.Drawing.Point(200, 222);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Size = new System.Drawing.Size(164, 67);
            this.bttnMenu.TabIndex = 2;
            this.bttnMenu.UseVisualStyleBackColor = true;
            this.bttnMenu.Click += new System.EventHandler(this.bttnMenu_Click);
            this.bttnMenu.Enter += new System.EventHandler(this.bttnMenu_Enter);
            this.bttnMenu.Leave += new System.EventHandler(this.bttnMenu_Leave);
            // 
            // pictureBox1
            // 
            this.tlpGO.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameOverUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tlpGO);
            this.Name = "GameOverUser";
            this.Size = new System.Drawing.Size(567, 365);
            this.tlpGO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGO;
        private System.Windows.Forms.Button bttnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
