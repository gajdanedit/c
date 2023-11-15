namespace Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pizzak = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_pizzaatlagar = new System.Windows.Forms.Button();
            this.groupBox1_fizetes = new System.Windows.Forms.GroupBox();
            this.radioButton1_kartya = new System.Windows.Forms.RadioButton();
            this.radioButton1_kp = new System.Windows.Forms.RadioButton();
            this.checkBox1_szamla = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1_betoltes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_pizzaink = new System.Windows.Forms.Label();
            this.groupBox1_fizetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzak
            // 
            this.pizzak.AutoSize = true;
            this.pizzak.Dock = System.Windows.Forms.DockStyle.Top;
            this.pizzak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pizzak.ForeColor = System.Drawing.Color.Maroon;
            this.pizzak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pizzak.Location = new System.Drawing.Point(0, 0);
            this.pizzak.Name = "pizzak";
            this.pizzak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pizzak.Size = new System.Drawing.Size(138, 25);
            this.pizzak.TabIndex = 0;
            this.pizzak.Text = "Rendelj pizzát ";
            this.pizzak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(4, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1_pizzaatlagar
            // 
            this.button1_pizzaatlagar.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1_pizzaatlagar.Location = new System.Drawing.Point(3, 141);
            this.button1_pizzaatlagar.Name = "button1_pizzaatlagar";
            this.button1_pizzaatlagar.Size = new System.Drawing.Size(121, 23);
            this.button1_pizzaatlagar.TabIndex = 2;
            this.button1_pizzaatlagar.Text = "Pizzák átlagára";
            this.button1_pizzaatlagar.UseVisualStyleBackColor = false;
            // 
            // groupBox1_fizetes
            // 
            this.groupBox1_fizetes.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1_fizetes.Controls.Add(this.radioButton1_kartya);
            this.groupBox1_fizetes.Controls.Add(this.radioButton1_kp);
            this.groupBox1_fizetes.Location = new System.Drawing.Point(179, 121);
            this.groupBox1_fizetes.Name = "groupBox1_fizetes";
            this.groupBox1_fizetes.Size = new System.Drawing.Size(175, 88);
            this.groupBox1_fizetes.TabIndex = 3;
            this.groupBox1_fizetes.TabStop = false;
            this.groupBox1_fizetes.Text = "Fizetési lehetőségek";
            // 
            // radioButton1_kartya
            // 
            this.radioButton1_kartya.AutoSize = true;
            this.radioButton1_kartya.Location = new System.Drawing.Point(7, 44);
            this.radioButton1_kartya.Name = "radioButton1_kartya";
            this.radioButton1_kartya.Size = new System.Drawing.Size(55, 17);
            this.radioButton1_kartya.TabIndex = 1;
            this.radioButton1_kartya.TabStop = true;
            this.radioButton1_kartya.Text = "Kártya";
            this.radioButton1_kartya.UseVisualStyleBackColor = true;
            // 
            // radioButton1_kp
            // 
            this.radioButton1_kp.AutoSize = true;
            this.radioButton1_kp.Location = new System.Drawing.Point(7, 20);
            this.radioButton1_kp.Name = "radioButton1_kp";
            this.radioButton1_kp.Size = new System.Drawing.Size(66, 17);
            this.radioButton1_kp.TabIndex = 0;
            this.radioButton1_kp.TabStop = true;
            this.radioButton1_kp.Text = "Kézpénz";
            this.radioButton1_kp.UseVisualStyleBackColor = true;
            // 
            // checkBox1_szamla
            // 
            this.checkBox1_szamla.AutoSize = true;
            this.checkBox1_szamla.BackColor = System.Drawing.Color.Snow;
            this.checkBox1_szamla.Location = new System.Drawing.Point(179, 215);
            this.checkBox1_szamla.Name = "checkBox1_szamla";
            this.checkBox1_szamla.Size = new System.Drawing.Size(95, 17);
            this.checkBox1_szamla.TabIndex = 4;
            this.checkBox1_szamla.Text = "Kérek számlát ";
            this.checkBox1_szamla.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(419, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 5;
            // 
            // button1_betoltes
            // 
            this.button1_betoltes.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1_betoltes.Location = new System.Drawing.Point(5, 55);
            this.button1_betoltes.Name = "button1_betoltes";
            this.button1_betoltes.Size = new System.Drawing.Size(119, 23);
            this.button1_betoltes.TabIndex = 6;
            this.button1_betoltes.Text = "Betöltés";
            this.button1_betoltes.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1;Capricciosa",
            "2;Frutti di Mare",
            "3;Hawaii",
            "4;Vesuvio",
            "5;Sorrento"});
            this.comboBox1.Location = new System.Drawing.Point(4, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(179, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jelezze a pizzák db számát";
            // 
            // label2_pizzaink
            // 
            this.label2_pizzaink.AutoSize = true;
            this.label2_pizzaink.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2_pizzaink.Location = new System.Drawing.Point(5, 85);
            this.label2_pizzaink.Name = "label2_pizzaink";
            this.label2_pizzaink.Size = new System.Drawing.Size(49, 13);
            this.label2_pizzaink.TabIndex = 9;
            this.label2_pizzaink.Text = "Pizzáink:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2_pizzaink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1_betoltes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1_szamla);
            this.Controls.Add(this.groupBox1_fizetes);
            this.Controls.Add(this.button1_pizzaatlagar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pizzak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza winForm alkalmazás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_fizetes.ResumeLayout(false);
            this.groupBox1_fizetes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_pizzaatlagar;
        private System.Windows.Forms.GroupBox groupBox1_fizetes;
        private System.Windows.Forms.RadioButton radioButton1_kartya;
        private System.Windows.Forms.RadioButton radioButton1_kp;
        private System.Windows.Forms.CheckBox checkBox1_szamla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1_betoltes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_pizzaink;
    }
}

