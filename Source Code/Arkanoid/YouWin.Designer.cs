﻿namespace Arkanoid.Properties
{
    partial class YouWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnNext, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnMenu, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Arkanoid.Properties.Resources.YouWin;
            this.pictureBox1.Location = new System.Drawing.Point(165, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttnNext
            // 
            this.bttnNext.BackgroundImage = global::Arkanoid.Properties.Resources.Next_Btn;
            this.bttnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNext.Location = new System.Drawing.Point(230, 225);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(189, 68);
            this.bttnNext.TabIndex = 1;
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // bttnMenu
            // 
            this.bttnMenu.BackgroundImage = global::Arkanoid.Properties.Resources.Menu_Btn;
            this.bttnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMenu.Location = new System.Drawing.Point(230, 299);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Size = new System.Drawing.Size(189, 69);
            this.bttnMenu.TabIndex = 2;
            this.bttnMenu.UseVisualStyleBackColor = true;
            // 
            // YouWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "YouWin";
            this.Text = "YouWin";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnMenu;
    }
}