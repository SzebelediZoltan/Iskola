namespace _2025_01_28_DatagridView
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
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.BetoltesBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ModositBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDGV
            // 
            this.tablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDGV.Location = new System.Drawing.Point(181, 12);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.Size = new System.Drawing.Size(604, 405);
            this.tablaDGV.TabIndex = 0;
            this.tablaDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDGV_CellClick);
            // 
            // BetoltesBtn
            // 
            this.BetoltesBtn.Location = new System.Drawing.Point(12, 12);
            this.BetoltesBtn.Name = "BetoltesBtn";
            this.BetoltesBtn.Size = new System.Drawing.Size(127, 32);
            this.BetoltesBtn.TabIndex = 1;
            this.BetoltesBtn.Text = "Adatok betöltése";
            this.BetoltesBtn.UseVisualStyleBackColor = true;
            this.BetoltesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModositBtn
            // 
            this.ModositBtn.Location = new System.Drawing.Point(12, 50);
            this.ModositBtn.Name = "ModositBtn";
            this.ModositBtn.Size = new System.Drawing.Size(126, 30);
            this.ModositBtn.TabIndex = 2;
            this.ModositBtn.Text = "Módosítás";
            this.ModositBtn.UseVisualStyleBackColor = true;
            this.ModositBtn.Visible = false;
            this.ModositBtn.Click += new System.EventHandler(this.ModositBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 432);
            this.Controls.Add(this.ModositBtn);
            this.Controls.Add(this.BetoltesBtn);
            this.Controls.Add(this.tablaDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.Button BetoltesBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ModositBtn;
    }
}

