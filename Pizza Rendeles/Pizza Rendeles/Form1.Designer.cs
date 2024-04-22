
namespace Pizza_Rendeles
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
            this.lbl_pizzak = new System.Windows.Forms.Label();
            this.cmb_pizza = new System.Windows.Forms.ComboBox();
            this.num_db = new System.Windows.Forms.NumericUpDown();
            this.btn_Felvetel = new System.Windows.Forms.Button();
            this.grb_meret = new System.Windows.Forms.GroupBox();
            this.rdb_nagy = new System.Windows.Forms.RadioButton();
            this.rdb_normal = new System.Windows.Forms.RadioButton();
            this.rdb_kicsi = new System.Windows.Forms.RadioButton();
            this.grb_extra = new System.Windows.Forms.GroupBox();
            this.chb_kolbasz = new System.Windows.Forms.CheckBox();
            this.chb_hasab = new System.Windows.Forms.CheckBox();
            this.chb_sajt = new System.Windows.Forms.CheckBox();
            this.chb_szosz = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_rendeles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_db)).BeginInit();
            this.grb_meret.SuspendLayout();
            this.grb_extra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pizzak
            // 
            this.lbl_pizzak.AutoSize = true;
            this.lbl_pizzak.Location = new System.Drawing.Point(12, 9);
            this.lbl_pizzak.Name = "lbl_pizzak";
            this.lbl_pizzak.Size = new System.Drawing.Size(70, 25);
            this.lbl_pizzak.TabIndex = 0;
            this.lbl_pizzak.Text = "Pizzak";
            // 
            // cmb_pizza
            // 
            this.cmb_pizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pizza.FormattingEnabled = true;
            this.cmb_pizza.Items.AddRange(new object[] {
            "Magyaros pizza",
            "Sonkás pizza",
            "Ananászos pizza",
            "Gombás pizza",
            "Songoku pizza"});
            this.cmb_pizza.Location = new System.Drawing.Point(17, 38);
            this.cmb_pizza.Name = "cmb_pizza";
            this.cmb_pizza.Size = new System.Drawing.Size(224, 33);
            this.cmb_pizza.TabIndex = 1;
            // 
            // num_db
            // 
            this.num_db.Location = new System.Drawing.Point(247, 39);
            this.num_db.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_db.Name = "num_db";
            this.num_db.Size = new System.Drawing.Size(50, 30);
            this.num_db.TabIndex = 2;
            this.num_db.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Felvetel
            // 
            this.btn_Felvetel.Location = new System.Drawing.Point(317, 39);
            this.btn_Felvetel.Name = "btn_Felvetel";
            this.btn_Felvetel.Size = new System.Drawing.Size(138, 32);
            this.btn_Felvetel.TabIndex = 3;
            this.btn_Felvetel.Text = "Felvétel";
            this.btn_Felvetel.UseVisualStyleBackColor = true;
            this.btn_Felvetel.Click += new System.EventHandler(this.btn_Felvetel_Click);
            // 
            // grb_meret
            // 
            this.grb_meret.Controls.Add(this.rdb_nagy);
            this.grb_meret.Controls.Add(this.rdb_normal);
            this.grb_meret.Controls.Add(this.rdb_kicsi);
            this.grb_meret.Location = new System.Drawing.Point(17, 80);
            this.grb_meret.Name = "grb_meret";
            this.grb_meret.Size = new System.Drawing.Size(280, 143);
            this.grb_meret.TabIndex = 4;
            this.grb_meret.TabStop = false;
            this.grb_meret.Text = "Méret";
            // 
            // rdb_nagy
            // 
            this.rdb_nagy.AutoSize = true;
            this.rdb_nagy.Location = new System.Drawing.Point(6, 103);
            this.rdb_nagy.Name = "rdb_nagy";
            this.rdb_nagy.Size = new System.Drawing.Size(231, 29);
            this.rdb_nagy.TabIndex = 5;
            this.rdb_nagy.TabStop = true;
            this.rdb_nagy.Text = "Nagy (48 cm) - 4000 Ft";
            this.rdb_nagy.UseVisualStyleBackColor = true;
            // 
            // rdb_normal
            // 
            this.rdb_normal.AutoSize = true;
            this.rdb_normal.Location = new System.Drawing.Point(6, 67);
            this.rdb_normal.Name = "rdb_normal";
            this.rdb_normal.Size = new System.Drawing.Size(247, 29);
            this.rdb_normal.TabIndex = 5;
            this.rdb_normal.TabStop = true;
            this.rdb_normal.Text = "Normál (32 cm) - 2400 Ft";
            this.rdb_normal.UseVisualStyleBackColor = true;
            // 
            // rdb_kicsi
            // 
            this.rdb_kicsi.AutoSize = true;
            this.rdb_kicsi.Location = new System.Drawing.Point(6, 31);
            this.rdb_kicsi.Name = "rdb_kicsi";
            this.rdb_kicsi.Size = new System.Drawing.Size(227, 29);
            this.rdb_kicsi.TabIndex = 0;
            this.rdb_kicsi.TabStop = true;
            this.rdb_kicsi.Text = "Kicsi (28 cm) - 2000 Ft";
            this.rdb_kicsi.UseVisualStyleBackColor = true;
            // 
            // grb_extra
            // 
            this.grb_extra.Controls.Add(this.chb_kolbasz);
            this.grb_extra.Controls.Add(this.chb_hasab);
            this.grb_extra.Controls.Add(this.chb_sajt);
            this.grb_extra.Controls.Add(this.chb_szosz);
            this.grb_extra.Location = new System.Drawing.Point(17, 229);
            this.grb_extra.Name = "grb_extra";
            this.grb_extra.Size = new System.Drawing.Size(279, 174);
            this.grb_extra.TabIndex = 5;
            this.grb_extra.TabStop = false;
            this.grb_extra.Text = "Extra feltétek";
            // 
            // chb_kolbasz
            // 
            this.chb_kolbasz.AutoSize = true;
            this.chb_kolbasz.Location = new System.Drawing.Point(6, 140);
            this.chb_kolbasz.Name = "chb_kolbasz";
            this.chb_kolbasz.Size = new System.Drawing.Size(174, 29);
            this.chb_kolbasz.TabIndex = 9;
            this.chb_kolbasz.Text = "Kolbász - 200 Ft";
            this.chb_kolbasz.UseVisualStyleBackColor = true;
            // 
            // chb_hasab
            // 
            this.chb_hasab.AutoSize = true;
            this.chb_hasab.Location = new System.Drawing.Point(6, 103);
            this.chb_hasab.Name = "chb_hasab";
            this.chb_hasab.Size = new System.Drawing.Size(242, 29);
            this.chb_hasab.TabIndex = 8;
            this.chb_hasab.Text = "Hasábburgonya - 600 Ft";
            this.chb_hasab.UseVisualStyleBackColor = true;
            // 
            // chb_sajt
            // 
            this.chb_sajt.AutoSize = true;
            this.chb_sajt.Location = new System.Drawing.Point(6, 67);
            this.chb_sajt.Name = "chb_sajt";
            this.chb_sajt.Size = new System.Drawing.Size(183, 29);
            this.chb_sajt.TabIndex = 7;
            this.chb_sajt.Text = "Extra sajt - 500 Ft";
            this.chb_sajt.UseVisualStyleBackColor = true;
            // 
            // chb_szosz
            // 
            this.chb_szosz.AutoSize = true;
            this.chb_szosz.Location = new System.Drawing.Point(6, 31);
            this.chb_szosz.Name = "chb_szosz";
            this.chb_szosz.Size = new System.Drawing.Size(262, 29);
            this.chb_szosz.TabIndex = 6;
            this.chb_szosz.Text = "Paradicsom szósz - 200 Ft";
            this.chb_szosz.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(317, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(695, 479);
            this.listBox1.TabIndex = 6;
            // 
            // btn_rendeles
            // 
            this.btn_rendeles.Location = new System.Drawing.Point(58, 464);
            this.btn_rendeles.Name = "btn_rendeles";
            this.btn_rendeles.Size = new System.Drawing.Size(183, 64);
            this.btn_rendeles.TabIndex = 7;
            this.btn_rendeles.Text = "Rendelés";
            this.btn_rendeles.UseVisualStyleBackColor = true;
            this.btn_rendeles.Click += new System.EventHandler(this.btn_rendeles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 626);
            this.Controls.Add(this.btn_rendeles);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grb_extra);
            this.Controls.Add(this.grb_meret);
            this.Controls.Add(this.btn_Felvetel);
            this.Controls.Add(this.num_db);
            this.Controls.Add(this.cmb_pizza);
            this.Controls.Add(this.lbl_pizzak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            ((System.ComponentModel.ISupportInitialize)(this.num_db)).EndInit();
            this.grb_meret.ResumeLayout(false);
            this.grb_meret.PerformLayout();
            this.grb_extra.ResumeLayout(false);
            this.grb_extra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pizzak;
        private System.Windows.Forms.ComboBox cmb_pizza;
        private System.Windows.Forms.NumericUpDown num_db;
        private System.Windows.Forms.Button btn_Felvetel;
        private System.Windows.Forms.GroupBox grb_meret;
        private System.Windows.Forms.RadioButton rdb_nagy;
        private System.Windows.Forms.RadioButton rdb_normal;
        private System.Windows.Forms.RadioButton rdb_kicsi;
        private System.Windows.Forms.GroupBox grb_extra;
        private System.Windows.Forms.CheckBox chb_kolbasz;
        private System.Windows.Forms.CheckBox chb_hasab;
        private System.Windows.Forms.CheckBox chb_sajt;
        private System.Windows.Forms.CheckBox chb_szosz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_rendeles;
    }
}

