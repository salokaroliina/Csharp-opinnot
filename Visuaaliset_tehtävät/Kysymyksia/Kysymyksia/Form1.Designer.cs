namespace Kysymyksia
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(241, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARB.Location = new System.Drawing.Point(241, 38);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(38, 24);
            this.ARB.TabIndex = 1;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRB.Location = new System.Drawing.Point(241, 61);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(38, 24);
            this.BRB.TabIndex = 2;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRB.Location = new System.Drawing.Point(241, 84);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(38, 24);
            this.CRB.TabIndex = 3;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRB.Location = new System.Drawing.Point(241, 107);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(39, 24);
            this.DRB.TabIndex = 4;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLB.Location = new System.Drawing.Point(24, 38);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(186, 20);
            this.KysymysLB.TabIndex = 5;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            this.KysymysLB.Click += new System.EventHandler(this.KysymysLB_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(24, 139);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(30, 20);
            this.VastausLB.TabIndex = 7;
            this.VastausLB.Text = "xxx";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 254);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Controls.Add(this.DRB);
            this.Controls.Add(this.CRB);
            this.Controls.Add(this.BRB);
            this.Controls.Add(this.ARB);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "10 kysymystä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ARB;
        private System.Windows.Forms.RadioButton BRB;
        private System.Windows.Forms.RadioButton CRB;
        private System.Windows.Forms.RadioButton DRB;
        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label VastausLB;
    }
}

