namespace Nimet
{
    partial class Nimet
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
            this.NimiLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiLB.Location = new System.Drawing.Point(29, 43);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(462, 20);
            this.NimiLB.TabIndex = 0;
            this.NimiLB.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa: ";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(29, 122);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(68, 20);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            this.NimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiTB.Location = new System.Drawing.Point(497, 43);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(184, 26);
            this.NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkastaBT.Location = new System.Drawing.Point(497, 86);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(98, 35);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = true;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // Nimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 176);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimiLB);
            this.Name = "Nimet";
            this.Text = "Suosikkinimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NimiLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkastaBT;
    }
}

