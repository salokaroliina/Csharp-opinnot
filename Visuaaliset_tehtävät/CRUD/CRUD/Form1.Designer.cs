namespace CRUD
{
    partial class OpiskelijaRekisteri
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
            this.IdLB = new System.Windows.Forms.Label();
            this.EnimiLB = new System.Windows.Forms.Label();
            this.SnimiLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SpostiLB = new System.Windows.Forms.Label();
            this.OnroLB = new System.Windows.Forms.Label();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.OnroTB = new System.Windows.Forms.TextBox();
            this.SpostiTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.IdTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLB
            // 
            this.IdLB.AutoSize = true;
            this.IdLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLB.Location = new System.Drawing.Point(12, 12);
            this.IdLB.Name = "IdLB";
            this.IdLB.Size = new System.Drawing.Size(33, 20);
            this.IdLB.TabIndex = 0;
            this.IdLB.Text = "ID:";
            // 
            // EnimiLB
            // 
            this.EnimiLB.AutoSize = true;
            this.EnimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnimiLB.Location = new System.Drawing.Point(12, 52);
            this.EnimiLB.Name = "EnimiLB";
            this.EnimiLB.Size = new System.Drawing.Size(87, 20);
            this.EnimiLB.TabIndex = 1;
            this.EnimiLB.Text = "ETUNIMI:";
            // 
            // SnimiLB
            // 
            this.SnimiLB.AutoSize = true;
            this.SnimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnimiLB.Location = new System.Drawing.Point(12, 97);
            this.SnimiLB.Name = "SnimiLB";
            this.SnimiLB.Size = new System.Drawing.Size(101, 20);
            this.SnimiLB.TabIndex = 2;
            this.SnimiLB.Text = "SUKUNIMI:";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhLB.Location = new System.Drawing.Point(370, 12);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(91, 20);
            this.PuhLB.TabIndex = 3;
            this.PuhLB.Text = "PUHELIN:";
            // 
            // SpostiLB
            // 
            this.SpostiLB.AutoSize = true;
            this.SpostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpostiLB.Location = new System.Drawing.Point(370, 52);
            this.SpostiLB.Name = "SpostiLB";
            this.SpostiLB.Size = new System.Drawing.Size(127, 20);
            this.SpostiLB.TabIndex = 4;
            this.SpostiLB.Text = "SÄHKÖPOSTI:";
            // 
            // OnroLB
            // 
            this.OnroLB.AutoSize = true;
            this.OnroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnroLB.Location = new System.Drawing.Point(370, 97);
            this.OnroLB.Name = "OnroLB";
            this.OnroLB.Size = new System.Drawing.Size(154, 20);
            this.OnroLB.TabIndex = 5;
            this.OnroLB.Text = "OPISKELIJANRO:";
            // 
            // EnimiTB
            // 
            this.EnimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnimiTB.Location = new System.Drawing.Point(124, 46);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(199, 26);
            this.EnimiTB.TabIndex = 7;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnimiTB.Location = new System.Drawing.Point(124, 91);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(199, 26);
            this.SnimiTB.TabIndex = 8;
            // 
            // OnroTB
            // 
            this.OnroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnroTB.Location = new System.Drawing.Point(530, 91);
            this.OnroTB.Name = "OnroTB";
            this.OnroTB.Size = new System.Drawing.Size(199, 26);
            this.OnroTB.TabIndex = 11;
            // 
            // SpostiTB
            // 
            this.SpostiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpostiTB.Location = new System.Drawing.Point(530, 46);
            this.SpostiTB.Name = "SpostiTB";
            this.SpostiTB.Size = new System.Drawing.Size(199, 26);
            this.SpostiTB.TabIndex = 10;
            // 
            // PuhTB
            // 
            this.PuhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhTB.Location = new System.Drawing.Point(530, 6);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(199, 26);
            this.PuhTB.TabIndex = 9;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaBT.Location = new System.Drawing.Point(12, 134);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(115, 33);
            this.TyhjennaBT.TabIndex = 12;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(150, 134);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(115, 33);
            this.TallennaBT.TabIndex = 13;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivitaBT.Location = new System.Drawing.Point(291, 134);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(115, 33);
            this.PaivitaBT.TabIndex = 14;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(430, 134);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(115, 33);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 173);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(925, 352);
            this.TietotauluDG.TabIndex = 16;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // IdTB
            // 
            this.IdTB.Enabled = false;
            this.IdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(124, 9);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(199, 26);
            this.IdTB.TabIndex = 17;
            // 
            // OpiskelijaRekisteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 537);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.OnroTB);
            this.Controls.Add(this.SpostiTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.OnroLB);
            this.Controls.Add(this.SpostiLB);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.SnimiLB);
            this.Controls.Add(this.EnimiLB);
            this.Controls.Add(this.IdLB);
            this.Name = "OpiskelijaRekisteri";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.OpiskelijaRekisteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLB;
        private System.Windows.Forms.Label EnimiLB;
        private System.Windows.Forms.Label SnimiLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label SpostiLB;
        private System.Windows.Forms.Label OnroLB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox OnroTB;
        private System.Windows.Forms.TextBox SpostiTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.TextBox IdTB;
    }
}

