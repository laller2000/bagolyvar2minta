
namespace Gyonyoru_Lajos_Gepszam
{
    partial class Form_Kesesek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kesesek));
            this.comboBox1_Kesesek = new System.Windows.Forms.ComboBox();
            this.listBox1_Kesesek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1_Kesesek
            // 
            this.comboBox1_Kesesek.FormattingEnabled = true;
            this.comboBox1_Kesesek.Location = new System.Drawing.Point(273, 48);
            this.comboBox1_Kesesek.Name = "comboBox1_Kesesek";
            this.comboBox1_Kesesek.Size = new System.Drawing.Size(250, 24);
            this.comboBox1_Kesesek.TabIndex = 0;
            this.comboBox1_Kesesek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Kesesek_SelectedIndexChanged);
            // 
            // listBox1_Kesesek
            // 
            this.listBox1_Kesesek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1_Kesesek.FormattingEnabled = true;
            this.listBox1_Kesesek.ItemHeight = 16;
            this.listBox1_Kesesek.Location = new System.Drawing.Point(0, 190);
            this.listBox1_Kesesek.Name = "listBox1_Kesesek";
            this.listBox1_Kesesek.Size = new System.Drawing.Size(800, 260);
            this.listBox1_Kesesek.TabIndex = 1;
            // 
            // Form_Kesesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1_Kesesek);
            this.Controls.Add(this.comboBox1_Kesesek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Kesesek";
            this.Text = "30 napnál régebben bérelve";
            this.Load += new System.EventHandler(this.Form_Kesesek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_Kesesek;
        private System.Windows.Forms.ListBox listBox1_Kesesek;
    }
}