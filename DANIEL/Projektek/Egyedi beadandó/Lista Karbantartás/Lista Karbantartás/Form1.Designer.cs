
namespace Lista_Karbantartás
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
            this.hozzaad1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.felulre1 = new System.Windows.Forms.Button();
            this.fel1 = new System.Windows.Forms.Button();
            this.le1 = new System.Windows.Forms.Button();
            this.alulra1 = new System.Windows.Forms.Button();
            this.jobbra = new System.Windows.Forms.Button();
            this.balra = new System.Windows.Forms.Button();
            this.torol1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // hozzaad1
            // 
            this.hozzaad1.Location = new System.Drawing.Point(12, 12);
            this.hozzaad1.Name = "hozzaad1";
            this.hozzaad1.Size = new System.Drawing.Size(112, 39);
            this.hozzaad1.TabIndex = 0;
            this.hozzaad1.Text = "Hozzáad";
            this.hozzaad1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 732);
            this.listBox1.TabIndex = 1;
            // 
            // felulre1
            // 
            this.felulre1.Location = new System.Drawing.Point(249, 89);
            this.felulre1.Name = "felulre1";
            this.felulre1.Size = new System.Drawing.Size(112, 36);
            this.felulre1.TabIndex = 2;
            this.felulre1.Text = "Felülre";
            this.felulre1.UseVisualStyleBackColor = true;
            // 
            // fel1
            // 
            this.fel1.Location = new System.Drawing.Point(248, 131);
            this.fel1.Name = "fel1";
            this.fel1.Size = new System.Drawing.Size(112, 36);
            this.fel1.TabIndex = 3;
            this.fel1.Text = "Fel";
            this.fel1.UseVisualStyleBackColor = true;
            // 
            // le1
            // 
            this.le1.Location = new System.Drawing.Point(249, 173);
            this.le1.Name = "le1";
            this.le1.Size = new System.Drawing.Size(112, 36);
            this.le1.TabIndex = 4;
            this.le1.Text = "Le";
            this.le1.UseVisualStyleBackColor = true;
            // 
            // alulra1
            // 
            this.alulra1.Location = new System.Drawing.Point(249, 215);
            this.alulra1.Name = "alulra1";
            this.alulra1.Size = new System.Drawing.Size(112, 36);
            this.alulra1.TabIndex = 5;
            this.alulra1.Text = "Alulra";
            this.alulra1.UseVisualStyleBackColor = true;
            // 
            // jobbra
            // 
            this.jobbra.Location = new System.Drawing.Point(440, 89);
            this.jobbra.Name = "jobbra";
            this.jobbra.Size = new System.Drawing.Size(111, 36);
            this.jobbra.TabIndex = 6;
            this.jobbra.Text = ">";
            this.jobbra.UseVisualStyleBackColor = true;
            // 
            // balra
            // 
            this.balra.Location = new System.Drawing.Point(440, 215);
            this.balra.Name = "balra";
            this.balra.Size = new System.Drawing.Size(111, 36);
            this.balra.TabIndex = 7;
            this.balra.Text = "<";
            this.balra.UseVisualStyleBackColor = true;
            // 
            // torol1
            // 
            this.torol1.Location = new System.Drawing.Point(249, 753);
            this.torol1.Name = "torol1";
            this.torol1.Size = new System.Drawing.Size(111, 36);
            this.torol1.TabIndex = 8;
            this.torol1.Text = "Töröl";
            this.torol1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Location = new System.Drawing.Point(670, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 732);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 801);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.torol1);
            this.Controls.Add(this.balra);
            this.Controls.Add(this.jobbra);
            this.Controls.Add(this.alulra1);
            this.Controls.Add(this.le1);
            this.Controls.Add(this.fel1);
            this.Controls.Add(this.felulre1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hozzaad1);
            this.Font = new System.Drawing.Font("Roboto Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Lista karbantartás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hozzaad1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button felulre1;
        private System.Windows.Forms.Button fel1;
        private System.Windows.Forms.Button le1;
        private System.Windows.Forms.Button alulra1;
        private System.Windows.Forms.Button jobbra;
        private System.Windows.Forms.Button balra;
        private System.Windows.Forms.Button torol1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

