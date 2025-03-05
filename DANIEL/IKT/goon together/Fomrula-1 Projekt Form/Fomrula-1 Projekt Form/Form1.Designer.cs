namespace Fomrula_1_Projekt_Form
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
            this.EvekLista = new System.Windows.Forms.ListBox();
            this.PalyakLista = new System.Windows.Forms.ListBox();
            this.VersenyData = new System.Windows.Forms.DataGridView();
            this.KivalasztottData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VersenyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KivalasztottData)).BeginInit();
            this.SuspendLayout();
            // 
            // EvekLista
            // 
            this.EvekLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EvekLista.FormattingEnabled = true;
            this.EvekLista.ItemHeight = 31;
            this.EvekLista.Location = new System.Drawing.Point(104, 12);
            this.EvekLista.Name = "EvekLista";
            this.EvekLista.Size = new System.Drawing.Size(300, 159);
            this.EvekLista.TabIndex = 0;
            this.EvekLista.SelectedIndexChanged += new System.EventHandler(this.EvekLista_SelectedIndexChanged);
            // 
            // PalyakLista
            // 
            this.PalyakLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PalyakLista.FormattingEnabled = true;
            this.PalyakLista.ItemHeight = 31;
            this.PalyakLista.Location = new System.Drawing.Point(592, 12);
            this.PalyakLista.Name = "PalyakLista";
            this.PalyakLista.Size = new System.Drawing.Size(300, 159);
            this.PalyakLista.TabIndex = 1;
            this.PalyakLista.SelectedIndexChanged += new System.EventHandler(this.PalyakLista_SelectedIndexChanged);
            // 
            // VersenyData
            // 
            this.VersenyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersenyData.Location = new System.Drawing.Point(318, 355);
            this.VersenyData.Name = "VersenyData";
            this.VersenyData.Size = new System.Drawing.Size(734, 314);
            this.VersenyData.TabIndex = 2;
            this.VersenyData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VersenyData_CellContentClick);
            // 
            // KivalasztottData
            // 
            this.KivalasztottData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KivalasztottData.Location = new System.Drawing.Point(25, 197);
            this.KivalasztottData.Name = "KivalasztottData";
            this.KivalasztottData.Size = new System.Drawing.Size(734, 314);
            this.KivalasztottData.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.KivalasztottData);
            this.Controls.Add(this.VersenyData);
            this.Controls.Add(this.PalyakLista);
            this.Controls.Add(this.EvekLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VersenyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KivalasztottData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EvekLista;
        private System.Windows.Forms.ListBox PalyakLista;
        private System.Windows.Forms.DataGridView VersenyData;
        private System.Windows.Forms.DataGridView KivalasztottData;
    }
}

