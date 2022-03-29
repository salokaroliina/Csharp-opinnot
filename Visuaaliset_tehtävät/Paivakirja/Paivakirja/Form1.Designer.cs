namespace Paivakirja
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
            this.paivyriTB = new System.Windows.Forms.TextBox();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paivyriTB
            // 
            this.paivyriTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivyriTB.Location = new System.Drawing.Point(12, 12);
            this.paivyriTB.Multiline = true;
            this.paivyriTB.Name = "paivyriTB";
            this.paivyriTB.Size = new System.Drawing.Size(776, 353);
            this.paivyriTB.TabIndex = 0;
            // 
            // lisaaBT
            // 
            this.lisaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaBT.Location = new System.Drawing.Point(101, 371);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(583, 67);
            this.lisaaBT.TabIndex = 1;
            this.lisaaBT.Text = "Tallenna päiväkirjaan";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.paivyriTB);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paivyriTB;
        private System.Windows.Forms.Button lisaaBT;
    }
}

