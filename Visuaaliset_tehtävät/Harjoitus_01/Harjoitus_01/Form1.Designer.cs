namespace Harjoitus_01
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
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Location = new System.Drawing.Point(36, 76);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(106, 23);
            this.VaihdaBT.TabIndex = 0;
            this.VaihdaBT.Text = "Vaihda teksti";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(33, 50);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(43, 13);
            this.OtsikkoLB.TabIndex = 1;
            this.OtsikkoLB.Text = "Otsikko";
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.VaihdaBT);
            this.Name = "Form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VaihdaBT;
        private System.Windows.Forms.Label OtsikkoLB;
    }
}

