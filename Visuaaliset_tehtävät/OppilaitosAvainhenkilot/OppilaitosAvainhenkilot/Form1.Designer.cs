namespace OppilaitosAvainhenkilot
{
    partial class AvainhenkilotForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.OppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OosoiteLB = new System.Windows.Forms.Label();
            this.OpostinumeroLB = new System.Windows.Forms.Label();
            this.OpuhelinLB = new System.Windows.Forms.Label();
            this.OpostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.VsahkopostiLB = new System.Windows.Forms.Label();
            this.VpuhelinLB = new System.Windows.Forms.Label();
            this.VosastoLB = new System.Windows.Forms.Label();
            this.VtitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse vastuuhenkilö:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse oppilaitos:";
            // 
            // OppilaitoksetCB
            // 
            this.OppilaitoksetCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppilaitoksetCB.FormattingEnabled = true;
            this.OppilaitoksetCB.Location = new System.Drawing.Point(12, 98);
            this.OppilaitoksetCB.Name = "OppilaitoksetCB";
            this.OppilaitoksetCB.Size = new System.Drawing.Size(140, 32);
            this.OppilaitoksetCB.TabIndex = 3;
            this.OppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitoksetCB_SelectedIndexChanged);
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(266, 98);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(186, 32);
            this.VastuuhenkiloCB.TabIndex = 4;
            this.VastuuhenkiloCB.TextChanged += new System.EventHandler(this.VastuuhenkiloCB_TextChanged);
            // 
            // OosoiteLB
            // 
            this.OosoiteLB.AutoSize = true;
            this.OosoiteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OosoiteLB.Location = new System.Drawing.Point(12, 152);
            this.OosoiteLB.Name = "OosoiteLB";
            this.OosoiteLB.Size = new System.Drawing.Size(64, 24);
            this.OosoiteLB.TabIndex = 5;
            this.OosoiteLB.Text = "Osoite";
            // 
            // OpostinumeroLB
            // 
            this.OpostinumeroLB.AutoSize = true;
            this.OpostinumeroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpostinumeroLB.Location = new System.Drawing.Point(12, 180);
            this.OpostinumeroLB.Name = "OpostinumeroLB";
            this.OpostinumeroLB.Size = new System.Drawing.Size(116, 24);
            this.OpostinumeroLB.TabIndex = 6;
            this.OpostinumeroLB.Text = "Postinumero";
            // 
            // OpuhelinLB
            // 
            this.OpuhelinLB.AutoSize = true;
            this.OpuhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpuhelinLB.Location = new System.Drawing.Point(12, 237);
            this.OpuhelinLB.Name = "OpuhelinLB";
            this.OpuhelinLB.Size = new System.Drawing.Size(140, 24);
            this.OpuhelinLB.TabIndex = 7;
            this.OpuhelinLB.Text = "Puhelinnumero";
            // 
            // OpostitoimipaikkaLB
            // 
            this.OpostitoimipaikkaLB.AutoSize = true;
            this.OpostitoimipaikkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpostitoimipaikkaLB.Location = new System.Drawing.Point(12, 209);
            this.OpostitoimipaikkaLB.Name = "OpostitoimipaikkaLB";
            this.OpostitoimipaikkaLB.Size = new System.Drawing.Size(142, 24);
            this.OpostitoimipaikkaLB.TabIndex = 8;
            this.OpostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // VsahkopostiLB
            // 
            this.VsahkopostiLB.AutoSize = true;
            this.VsahkopostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsahkopostiLB.Location = new System.Drawing.Point(262, 209);
            this.VsahkopostiLB.Name = "VsahkopostiLB";
            this.VsahkopostiLB.Size = new System.Drawing.Size(102, 24);
            this.VsahkopostiLB.TabIndex = 13;
            this.VsahkopostiLB.Text = "Sähköposti";
            // 
            // VpuhelinLB
            // 
            this.VpuhelinLB.AutoSize = true;
            this.VpuhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VpuhelinLB.Location = new System.Drawing.Point(262, 237);
            this.VpuhelinLB.Name = "VpuhelinLB";
            this.VpuhelinLB.Size = new System.Drawing.Size(140, 24);
            this.VpuhelinLB.TabIndex = 12;
            this.VpuhelinLB.Text = "Puhelinnumero";
            // 
            // VosastoLB
            // 
            this.VosastoLB.AutoSize = true;
            this.VosastoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VosastoLB.Location = new System.Drawing.Point(262, 180);
            this.VosastoLB.Name = "VosastoLB";
            this.VosastoLB.Size = new System.Drawing.Size(68, 24);
            this.VosastoLB.TabIndex = 11;
            this.VosastoLB.Text = "Osasto";
            // 
            // VtitteliLB
            // 
            this.VtitteliLB.AutoSize = true;
            this.VtitteliLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VtitteliLB.Location = new System.Drawing.Point(262, 152);
            this.VtitteliLB.Name = "VtitteliLB";
            this.VtitteliLB.Size = new System.Drawing.Size(53, 24);
            this.VtitteliLB.TabIndex = 10;
            this.VtitteliLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 310);
            this.Controls.Add(this.VsahkopostiLB);
            this.Controls.Add(this.VpuhelinLB);
            this.Controls.Add(this.VosastoLB);
            this.Controls.Add(this.VtitteliLB);
            this.Controls.Add(this.OpostitoimipaikkaLB);
            this.Controls.Add(this.OpuhelinLB);
            this.Controls.Add(this.OpostinumeroLB);
            this.Controls.Add(this.OosoiteLB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.OppilaitoksetCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OppilaitoksetCB;
        private System.Windows.Forms.ComboBox VastuuhenkiloCB;
        private System.Windows.Forms.Label OosoiteLB;
        private System.Windows.Forms.Label OpostinumeroLB;
        private System.Windows.Forms.Label OpuhelinLB;
        private System.Windows.Forms.Label OpostitoimipaikkaLB;
        private System.Windows.Forms.Label VsahkopostiLB;
        private System.Windows.Forms.Label VpuhelinLB;
        private System.Windows.Forms.Label VosastoLB;
        private System.Windows.Forms.Label VtitteliLB;
    }
}

