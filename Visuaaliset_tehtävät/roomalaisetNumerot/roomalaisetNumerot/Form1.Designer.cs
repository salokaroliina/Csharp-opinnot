namespace roomalaisetNumerot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.muutaBT = new System.Windows.Forms.Button();
            this.tulosLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna muunnettava luku:";
            // 
            // lukuTB
            // 
            this.lukuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lukuTB.Location = new System.Drawing.Point(262, 112);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(149, 31);
            this.lukuTB.TabIndex = 2;
            // 
            // muutaBT
            // 
            this.muutaBT.BackColor = System.Drawing.Color.PeachPuff;
            this.muutaBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.muutaBT.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muutaBT.Location = new System.Drawing.Point(262, 149);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(149, 33);
            this.muutaBT.TabIndex = 3;
            this.muutaBT.Text = "Muuta luku";
            this.muutaBT.UseVisualStyleBackColor = false;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click);
            // 
            // tulosLB
            // 
            this.tulosLB.AutoSize = true;
            this.tulosLB.BackColor = System.Drawing.Color.Transparent;
            this.tulosLB.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulosLB.ForeColor = System.Drawing.Color.Gold;
            this.tulosLB.Location = new System.Drawing.Point(12, 209);
            this.tulosLB.Name = "tulosLB";
            this.tulosLB.Size = new System.Drawing.Size(82, 38);
            this.tulosLB.TabIndex = 4;
            this.tulosLB.Text = "xxxxx";
            this.tulosLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(665, 308);
            this.Controls.Add(this.tulosLB);
            this.Controls.Add(this.muutaBT);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numeroiden muunto latinalaisista roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lukuTB;
        private System.Windows.Forms.Button muutaBT;
        private System.Windows.Forms.Label tulosLB;
    }
}

