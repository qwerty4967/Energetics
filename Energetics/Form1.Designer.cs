﻿namespace Energetics
{
    partial class Form1
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
            this.lblTemporary = new System.Windows.Forms.Label();
            this.btnSolar = new System.Windows.Forms.Button();
            this.btnNuclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemporary
            // 
            this.lblTemporary.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporary.Location = new System.Drawing.Point(254, 42);
            this.lblTemporary.Name = "lblTemporary";
            this.lblTemporary.Size = new System.Drawing.Size(278, 66);
            this.lblTemporary.TabIndex = 0;
            this.lblTemporary.Text = "Please select the game you want to play:";
            this.lblTemporary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolar
            // 
            this.btnSolar.AllowDrop = true;
            this.btnSolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSolar.Location = new System.Drawing.Point(276, 150);
            this.btnSolar.Name = "btnSolar";
            this.btnSolar.Size = new System.Drawing.Size(220, 67);
            this.btnSolar.TabIndex = 1;
            this.btnSolar.Text = "Solar";
            this.btnSolar.UseVisualStyleBackColor = true;
            this.btnSolar.Click += new System.EventHandler(this.btnSolar_Click);
            // 
            // btnNuclear
            // 
            this.btnNuclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnNuclear.Location = new System.Drawing.Point(276, 238);
            this.btnNuclear.Name = "btnNuclear";
            this.btnNuclear.Size = new System.Drawing.Size(220, 67);
            this.btnNuclear.TabIndex = 2;
            this.btnNuclear.Text = "Nuclear";
            this.btnNuclear.UseVisualStyleBackColor = true;
            this.btnNuclear.Click += new System.EventHandler(this.btnNuclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuclear);
            this.Controls.Add(this.btnSolar);
            this.Controls.Add(this.lblTemporary);
            this.Name = "Form1";
            this.Text = "Energetics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemporary;
        private System.Windows.Forms.Button btnSolar;
        private System.Windows.Forms.Button btnNuclear;
    }
}

