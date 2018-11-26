namespace MrsMcave
{
    partial class Child_Form_5
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
            this.button_twin = new System.Windows.Forms.Button();
            this.button_triplet = new System.Windows.Forms.Button();
            this.button_quadruplets = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_twin
            // 
            this.button_twin.Location = new System.Drawing.Point(12, 36);
            this.button_twin.Name = "button_twin";
            this.button_twin.Size = new System.Drawing.Size(75, 23);
            this.button_twin.TabIndex = 0;
            this.button_twin.Text = "Twins";
            this.button_twin.UseVisualStyleBackColor = true;
            this.button_twin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_triplet
            // 
            this.button_triplet.Location = new System.Drawing.Point(12, 81);
            this.button_triplet.Name = "button_triplet";
            this.button_triplet.Size = new System.Drawing.Size(75, 23);
            this.button_triplet.TabIndex = 1;
            this.button_triplet.Text = "Triplets";
            this.button_triplet.UseVisualStyleBackColor = true;
            this.button_triplet.Click += new System.EventHandler(this.button_triplet_Click);
            // 
            // button_quadruplets
            // 
            this.button_quadruplets.Location = new System.Drawing.Point(12, 123);
            this.button_quadruplets.Name = "button_quadruplets";
            this.button_quadruplets.Size = new System.Drawing.Size(75, 23);
            this.button_quadruplets.TabIndex = 2;
            this.button_quadruplets.Text = "Quadruplets";
            this.button_quadruplets.UseVisualStyleBackColor = true;
            this.button_quadruplets.Click += new System.EventHandler(this.button_quadruplets_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 316);
            this.listBox1.TabIndex = 3;
            // 
            // Child_Form_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 364);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_quadruplets);
            this.Controls.Add(this.button_triplet);
            this.Controls.Add(this.button_twin);
            this.Name = "Child_Form_5";
            this.Text = "Child_Form_5";
            this.Load += new System.EventHandler(this.Child_Form_5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_twin;
        private System.Windows.Forms.Button button_triplet;
        private System.Windows.Forms.Button button_quadruplets;
        private System.Windows.Forms.ListBox listBox1;
    }
}