﻿namespace MrsMcave
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
            this.fileCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileCreator
            // 
            this.fileCreator.Location = new System.Drawing.Point(207, 313);
            this.fileCreator.Name = "fileCreator";
            this.fileCreator.Size = new System.Drawing.Size(120, 23);
            this.fileCreator.TabIndex = 0;
            this.fileCreator.Text = "filebutton";
            this.fileCreator.UseVisualStyleBackColor = true;
            this.fileCreator.Click += new System.EventHandler(this.fileCreator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 471);
            this.Controls.Add(this.fileCreator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileCreator;
    }
}

