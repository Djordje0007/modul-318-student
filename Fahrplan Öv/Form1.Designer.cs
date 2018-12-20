namespace Fahrplan_Öv
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Mail = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Abfahrtsort = new System.Windows.Forms.ComboBox();
            this.comboBox_Ankunftsort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.listBox_Ausgabe = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Sponoring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Mail
            // 
            this.button_Mail.Location = new System.Drawing.Point(439, 13);
            this.button_Mail.Name = "button_Mail";
            this.button_Mail.Size = new System.Drawing.Size(75, 23);
            this.button_Mail.TabIndex = 0;
            this.button_Mail.Text = "Mail";
            this.button_Mail.UseVisualStyleBackColor = true;
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(347, 12);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(75, 23);
            this.button_Help.TabIndex = 1;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox_Abfahrtsort
            // 
            this.comboBox_Abfahrtsort.FormattingEnabled = true;
            this.comboBox_Abfahrtsort.Location = new System.Drawing.Point(28, 67);
            this.comboBox_Abfahrtsort.Name = "comboBox_Abfahrtsort";
            this.comboBox_Abfahrtsort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Abfahrtsort.TabIndex = 3;
            // 
            // comboBox_Ankunftsort
            // 
            this.comboBox_Ankunftsort.FormattingEnabled = true;
            this.comboBox_Ankunftsort.Location = new System.Drawing.Point(220, 67);
            this.comboBox_Ankunftsort.Name = "comboBox_Ankunftsort";
            this.comboBox_Ankunftsort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Ankunftsort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abfahrtsort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ankunftsort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "-->";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.Location = new System.Drawing.Point(220, 277);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(98, 33);
            this.btn_Suchen.TabIndex = 8;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = true;
            // 
            // listBox_Ausgabe
            // 
            this.listBox_Ausgabe.FormattingEnabled = true;
            this.listBox_Ausgabe.Location = new System.Drawing.Point(364, 111);
            this.listBox_Ausgabe.Name = "listBox_Ausgabe";
            this.listBox_Ausgabe.Size = new System.Drawing.Size(424, 199);
            this.listBox_Ausgabe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ankunftszeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dauer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Abfahrtszeit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 505);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button_Sponoring
            // 
            this.button_Sponoring.Location = new System.Drawing.Point(206, 12);
            this.button_Sponoring.Name = "button_Sponoring";
            this.button_Sponoring.Size = new System.Drawing.Size(75, 23);
            this.button_Sponoring.TabIndex = 15;
            this.button_Sponoring.Text = "Sponsoring";
            this.button_Sponoring.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Sponoring);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_Ausgabe);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Ankunftsort);
            this.Controls.Add(this.comboBox_Abfahrtsort);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_Mail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Mail;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Abfahrtsort;
        private System.Windows.Forms.ComboBox comboBox_Ankunftsort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.ListBox listBox_Ausgabe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Sponoring;
    }
}

