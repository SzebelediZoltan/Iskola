namespace Administracios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fILEToolStripMenuItem = new ToolStripMenuItem();
            sAVEToolStripMenuItem = new ToolStripMenuItem();
            lOADToolStripMenuItem = new ToolStripMenuItem();
            cLOSEToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            felujitando = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            cim = new TextBox();
            label3 = new Label();
            evszam = new NumericUpDown();
            label4 = new Label();
            szerzo1 = new TextBox();
            addSzerzo = new Button();
            konyvek = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)evszam).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fILEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(397, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            fILEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sAVEToolStripMenuItem, lOADToolStripMenuItem, cLOSEToolStripMenuItem });
            fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            fILEToolStripMenuItem.Size = new Size(37, 20);
            fILEToolStripMenuItem.Text = "File";
            // 
            // sAVEToolStripMenuItem
            // 
            sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            sAVEToolStripMenuItem.Size = new Size(103, 22);
            sAVEToolStripMenuItem.Text = "Save";
            sAVEToolStripMenuItem.Click += sAVEToolStripMenuItem_Click;
            // 
            // lOADToolStripMenuItem
            // 
            lOADToolStripMenuItem.Name = "lOADToolStripMenuItem";
            lOADToolStripMenuItem.Size = new Size(103, 22);
            lOADToolStripMenuItem.Text = "Open";
            lOADToolStripMenuItem.Click += lOADToolStripMenuItem_Click;
            // 
            // cLOSEToolStripMenuItem
            // 
            cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            cLOSEToolStripMenuItem.Size = new Size(103, 22);
            cLOSEToolStripMenuItem.Text = "Close";
            cLOSEToolStripMenuItem.Click += cLOSEToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 1;
            button1.Text = "Új elem felvétele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // felujitando
            // 
            felujitando.AutoSize = true;
            felujitando.Location = new Point(84, 56);
            felujitando.Name = "felujitando";
            felujitando.Size = new Size(15, 14);
            felujitando.TabIndex = 2;
            felujitando.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Felújítandó";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Cím";
            // 
            // cim
            // 
            cim.Location = new Point(84, 76);
            cim.Name = "cim";
            cim.Size = new Size(100, 23);
            cim.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Évszám";
            // 
            // evszam
            // 
            evszam.Location = new Point(84, 105);
            evszam.Name = "evszam";
            evszam.Size = new Size(120, 23);
            evszam.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Szerzők";
            // 
            // szerzo1
            // 
            szerzo1.Location = new Point(84, 134);
            szerzo1.Name = "szerzo1";
            szerzo1.Size = new Size(100, 23);
            szerzo1.TabIndex = 9;
            // 
            // addSzerzo
            // 
            addSzerzo.Font = new Font("Segoe UI", 9F);
            addSzerzo.Location = new Point(190, 134);
            addSzerzo.Name = "addSzerzo";
            addSzerzo.Size = new Size(23, 23);
            addSzerzo.TabIndex = 10;
            addSzerzo.Text = "+";
            addSzerzo.UseVisualStyleBackColor = true;
            addSzerzo.Click += addSzerzo_Click;
            // 
            // konyvek
            // 
            konyvek.FormattingEnabled = true;
            konyvek.ItemHeight = 15;
            konyvek.Location = new Point(219, 27);
            konyvek.Name = "konyvek";
            konyvek.Size = new Size(165, 124);
            konyvek.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 163);
            Controls.Add(konyvek);
            Controls.Add(addSzerzo);
            Controls.Add(szerzo1);
            Controls.Add(label4);
            Controls.Add(evszam);
            Controls.Add(label3);
            Controls.Add(cim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(felujitando);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)evszam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem sAVEToolStripMenuItem;
        private ToolStripMenuItem lOADToolStripMenuItem;
        private ToolStripMenuItem cLOSEToolStripMenuItem;
        private Button button1;
        private CheckBox felujitando;
        private Label label1;
        private Label label2;
        private TextBox cim;
        private Label label3;
        private NumericUpDown evszam;
        private Label label4;
        private TextBox szerzo1;
        private Button addSzerzo;
        private ListBox konyvek;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
