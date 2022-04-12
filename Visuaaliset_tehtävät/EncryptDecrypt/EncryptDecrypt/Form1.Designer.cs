namespace EncryptDecrypt
{
    partial class EncryptDecrypt
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
            this.CryptaaBT = new System.Windows.Forms.Button();
            this.NaytaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.CryptattuCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CryptaaBT
            // 
            this.CryptaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptaaBT.Location = new System.Drawing.Point(377, 34);
            this.CryptaaBT.Name = "CryptaaBT";
            this.CryptaaBT.Size = new System.Drawing.Size(153, 29);
            this.CryptaaBT.TabIndex = 0;
            this.CryptaaBT.Text = "Cryptaa";
            this.CryptaaBT.UseVisualStyleBackColor = true;
            this.CryptaaBT.Click += new System.EventHandler(this.CryptaaBT_Click);
            // 
            // NaytaBT
            // 
            this.NaytaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaytaBT.Location = new System.Drawing.Point(377, 80);
            this.NaytaBT.Name = "NaytaBT";
            this.NaytaBT.Size = new System.Drawing.Size(153, 30);
            this.NaytaBT.TabIndex = 1;
            this.NaytaBT.Text = "Näytä salasana";
            this.NaytaBT.UseVisualStyleBackColor = true;
            this.NaytaBT.Click += new System.EventHandler(this.NaytaBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(113, 35);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(258, 26);
            this.SalasanaTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salasana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cryptattu:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(13, 131);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(68, 20);
            this.VastausLB.TabIndex = 6;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // CryptattuCB
            // 
            this.CryptattuCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptattuCB.FormattingEnabled = true;
            this.CryptattuCB.Location = new System.Drawing.Point(113, 80);
            this.CryptattuCB.Name = "CryptattuCB";
            this.CryptattuCB.Size = new System.Drawing.Size(258, 28);
            this.CryptattuCB.TabIndex = 7;

            // 
            // EncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 190);
            this.Controls.Add(this.CryptattuCB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.NaytaBT);
            this.Controls.Add(this.CryptaaBT);
            this.Name = "EncryptDecrypt";
            this.Text = "EncryptDecrypt";
            this.Load += new System.EventHandler(this.EncryptDecrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CryptaaBT;
        private System.Windows.Forms.Button NaytaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.ComboBox CryptattuCB;
    }
}

