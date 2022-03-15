namespace Iän_laskeminen
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
            this.paivamaaraDTP = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuodetLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.PaivatLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paivamaaraDTP
            // 
            this.paivamaaraDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivamaaraDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivamaaraDTP.Location = new System.Drawing.Point(29, 26);
            this.paivamaaraDTP.Name = "paivamaaraDTP";
            this.paivamaaraDTP.Size = new System.Drawing.Size(363, 31);
            this.paivamaaraDTP.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(421, 26);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(98, 31);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuodetLB
            // 
            this.VuodetLB.AutoSize = true;
            this.VuodetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VuodetLB.Location = new System.Drawing.Point(24, 145);
            this.VuodetLB.Name = "VuodetLB";
            this.VuodetLB.Size = new System.Drawing.Size(45, 25);
            this.VuodetLB.TabIndex = 2;
            this.VuodetLB.Text = "xxx";
            this.VuodetLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TunnitLB.Location = new System.Drawing.Point(208, 145);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(45, 25);
            this.TunnitLB.TabIndex = 3;
            this.TunnitLB.Text = "xxx";
            this.TunnitLB.Visible = false;
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuukaudetLB.Location = new System.Drawing.Point(24, 201);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(45, 25);
            this.KuukaudetLB.TabIndex = 4;
            this.KuukaudetLB.Text = "xxx";
            this.KuukaudetLB.Visible = false;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuutitLB.Location = new System.Drawing.Point(208, 201);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(45, 25);
            this.MinuutitLB.TabIndex = 5;
            this.MinuutitLB.Text = "xxx";
            this.MinuutitLB.Visible = false;
            // 
            // PaivatLB
            // 
            this.PaivatLB.AutoSize = true;
            this.PaivatLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivatLB.Location = new System.Drawing.Point(24, 264);
            this.PaivatLB.Name = "PaivatLB";
            this.PaivatLB.Size = new System.Drawing.Size(45, 25);
            this.PaivatLB.TabIndex = 6;
            this.PaivatLB.Text = "xxx";
            this.PaivatLB.Visible = false;
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunnitLB.Location = new System.Drawing.Point(208, 264);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(45, 25);
            this.SekunnitLB.TabIndex = 7;
            this.SekunnitLB.Text = "xxx";
            this.SekunnitLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 351);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.PaivatLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.VuodetLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.paivamaaraDTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker paivamaaraDTP;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VuodetLB;
        private System.Windows.Forms.Label TunnitLB;
        private System.Windows.Forms.Label KuukaudetLB;
        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label PaivatLB;
        private System.Windows.Forms.Label SekunnitLB;
    }
}

