
namespace Gyonyoru_Lajos_Gepszam
{
    partial class Form_Kolcsonzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kolcsonzes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1_Kolcsonzoadatok = new System.Windows.Forms.ListBox();
            this.button1_Listaba = new System.Windows.Forms.Button();
            this.button2_Adatbazisba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_Konyv = new System.Windows.Forms.ComboBox();
            this.comboBox2_Berlo = new System.Windows.Forms.ComboBox();
            this.numericUpDown1_Peldany = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2_Adatbazisba);
            this.groupBox1.Controls.Add(this.numericUpDown1_Peldany);
            this.groupBox1.Controls.Add(this.comboBox2_Berlo);
            this.groupBox1.Controls.Add(this.comboBox1_Konyv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzésadatok";
            // 
            // listBox1_Kolcsonzoadatok
            // 
            this.listBox1_Kolcsonzoadatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1_Kolcsonzoadatok.FormattingEnabled = true;
            this.listBox1_Kolcsonzoadatok.ItemHeight = 16;
            this.listBox1_Kolcsonzoadatok.Location = new System.Drawing.Point(339, 0);
            this.listBox1_Kolcsonzoadatok.Name = "listBox1_Kolcsonzoadatok";
            this.listBox1_Kolcsonzoadatok.Size = new System.Drawing.Size(450, 450);
            this.listBox1_Kolcsonzoadatok.TabIndex = 1;
            // 
            // button1_Listaba
            // 
            this.button1_Listaba.Location = new System.Drawing.Point(78, 271);
            this.button1_Listaba.Name = "button1_Listaba";
            this.button1_Listaba.Size = new System.Drawing.Size(226, 23);
            this.button1_Listaba.TabIndex = 2;
            this.button1_Listaba.Text = "Listába tárolja az adatot";
            this.button1_Listaba.UseVisualStyleBackColor = true;
            this.button1_Listaba.Click += new System.EventHandler(this.button1_Listaba_Click);
            // 
            // button2_Adatbazisba
            // 
            this.button2_Adatbazisba.Location = new System.Drawing.Point(65, 354);
            this.button2_Adatbazisba.Name = "button2_Adatbazisba";
            this.button2_Adatbazisba.Size = new System.Drawing.Size(240, 23);
            this.button2_Adatbazisba.TabIndex = 3;
            this.button2_Adatbazisba.Text = "Rögzítés az adatbázisba";
            this.button2_Adatbazisba.UseVisualStyleBackColor = true;
            this.button2_Adatbazisba.Click += new System.EventHandler(this.button2_Adatbazisba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Könyv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bérlő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Példány:";
            // 
            // comboBox1_Konyv
            // 
            this.comboBox1_Konyv.FormattingEnabled = true;
            this.comboBox1_Konyv.Location = new System.Drawing.Point(100, 31);
            this.comboBox1_Konyv.Name = "comboBox1_Konyv";
            this.comboBox1_Konyv.Size = new System.Drawing.Size(205, 24);
            this.comboBox1_Konyv.TabIndex = 3;
            // 
            // comboBox2_Berlo
            // 
            this.comboBox2_Berlo.FormattingEnabled = true;
            this.comboBox2_Berlo.Location = new System.Drawing.Point(88, 82);
            this.comboBox2_Berlo.Name = "comboBox2_Berlo";
            this.comboBox2_Berlo.Size = new System.Drawing.Size(217, 24);
            this.comboBox2_Berlo.TabIndex = 4;
            // 
            // numericUpDown1_Peldany
            // 
            this.numericUpDown1_Peldany.Location = new System.Drawing.Point(185, 144);
            this.numericUpDown1_Peldany.Name = "numericUpDown1_Peldany";
            this.numericUpDown1_Peldany.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Peldany.TabIndex = 5;
            this.numericUpDown1_Peldany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_Kolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.button1_Listaba);
            this.Controls.Add(this.listBox1_Kolcsonzoadatok);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Kolcsonzes";
            this.Text = "Kölcsönzések";
            this.Load += new System.EventHandler(this.Form_Kolcsonzes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1_Kolcsonzoadatok;
        private System.Windows.Forms.Button button1_Listaba;
        private System.Windows.Forms.Button button2_Adatbazisba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1_Konyv;
        private System.Windows.Forms.ComboBox comboBox2_Berlo;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Peldany;
    }
}