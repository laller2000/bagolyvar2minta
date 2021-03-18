
namespace Gyonyoru_Lajos_Gepszam
{
    partial class Form_Navigalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Navigalo));
            this.button1_Kolcsonzes = new System.Windows.Forms.Button();
            this.button2_Kesesek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Kolcsonzes
            // 
            this.button1_Kolcsonzes.Location = new System.Drawing.Point(254, 103);
            this.button1_Kolcsonzes.Name = "button1_Kolcsonzes";
            this.button1_Kolcsonzes.Size = new System.Drawing.Size(109, 44);
            this.button1_Kolcsonzes.TabIndex = 0;
            this.button1_Kolcsonzes.Text = "Kölcsönzés";
            this.button1_Kolcsonzes.UseVisualStyleBackColor = true;
            this.button1_Kolcsonzes.Click += new System.EventHandler(this.button1_Kolcsonzes_Click);
            // 
            // button2_Kesesek
            // 
            this.button2_Kesesek.Location = new System.Drawing.Point(515, 103);
            this.button2_Kesesek.Name = "button2_Kesesek";
            this.button2_Kesesek.Size = new System.Drawing.Size(87, 44);
            this.button2_Kesesek.TabIndex = 1;
            this.button2_Kesesek.Text = "Késések";
            this.button2_Kesesek.UseVisualStyleBackColor = true;
            this.button2_Kesesek.Click += new System.EventHandler(this.button2_Kesesek_Click);
            // 
            // Form_Navigalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Kesesek);
            this.Controls.Add(this.button1_Kolcsonzes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Navigalo";
            this.Text = "Könyvkölcsönzés";
            this.Load += new System.EventHandler(this.Form_Navigalo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Kolcsonzes;
        private System.Windows.Forms.Button button2_Kesesek;
    }
}

