namespace WindowsFormsAppok
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_forrasfajl = new System.Windows.Forms.TextBox();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.listBox_orszaglista = new System.Windows.Forms.ListBox();
            this.button_teruletekatlaga = new System.Windows.Forms.Button();
            this.button_megszamolas = new System.Windows.Forms.Button();
            this.groupBox_mitszamoljunk = new System.Windows.Forms.GroupBox();
            this.radioButton_szazezerfelett = new System.Windows.Forms.RadioButton();
            this.radioButton_legfeljebbszazezer = new System.Windows.Forms.RadioButton();
            this.label_eredmeny = new System.Windows.Forms.Label();
            this.textBox_eredmeny = new System.Windows.Forms.TextBox();
            this.button_kiiras = new System.Windows.Forms.Button();
            this.label_minvagymax = new System.Windows.Forms.Label();
            this.button_maxminkivalasztasa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_orszagkeresese = new System.Windows.Forms.Label();
            this.textBox_keresettorszag = new System.Windows.Forms.TextBox();
            this.checkBox_talalatokjelolese = new System.Windows.Forms.CheckBox();
            this.button_kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_mitszamoljunk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl neve";
            // 
            // textBox_forrasfajl
            // 
            this.textBox_forrasfajl.Location = new System.Drawing.Point(79, 63);
            this.textBox_forrasfajl.Name = "textBox_forrasfajl";
            this.textBox_forrasfajl.Size = new System.Drawing.Size(110, 20);
            this.textBox_forrasfajl.TabIndex = 1;
            // 
            // button_betoltes
            // 
            this.button_betoltes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_betoltes.Location = new System.Drawing.Point(79, 89);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(110, 23);
            this.button_betoltes.TabIndex = 2;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // listBox_orszaglista
            // 
            this.listBox_orszaglista.FormattingEnabled = true;
            this.listBox_orszaglista.Location = new System.Drawing.Point(79, 118);
            this.listBox_orszaglista.Name = "listBox_orszaglista";
            this.listBox_orszaglista.Size = new System.Drawing.Size(110, 264);
            this.listBox_orszaglista.TabIndex = 3;
            // 
            // button_teruletekatlaga
            // 
            this.button_teruletekatlaga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_teruletekatlaga.Location = new System.Drawing.Point(79, 393);
            this.button_teruletekatlaga.Name = "button_teruletekatlaga";
            this.button_teruletekatlaga.Size = new System.Drawing.Size(110, 23);
            this.button_teruletekatlaga.TabIndex = 4;
            this.button_teruletekatlaga.Text = "Területek átlaga";
            this.button_teruletekatlaga.UseVisualStyleBackColor = true;
            this.button_teruletekatlaga.Click += new System.EventHandler(this.button_teruletekatlaga_Click);
            // 
            // button_megszamolas
            // 
            this.button_megszamolas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_megszamolas.Location = new System.Drawing.Point(207, 118);
            this.button_megszamolas.Name = "button_megszamolas";
            this.button_megszamolas.Size = new System.Drawing.Size(182, 23);
            this.button_megszamolas.TabIndex = 5;
            this.button_megszamolas.Text = "Megszámolás";
            this.button_megszamolas.UseVisualStyleBackColor = true;
            this.button_megszamolas.Click += new System.EventHandler(this.button_megszamolas_Click);
            // 
            // groupBox_mitszamoljunk
            // 
            this.groupBox_mitszamoljunk.Controls.Add(this.radioButton_legfeljebbszazezer);
            this.groupBox_mitszamoljunk.Controls.Add(this.radioButton_szazezerfelett);
            this.groupBox_mitszamoljunk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_mitszamoljunk.Location = new System.Drawing.Point(207, 47);
            this.groupBox_mitszamoljunk.Name = "groupBox_mitszamoljunk";
            this.groupBox_mitszamoljunk.Size = new System.Drawing.Size(182, 65);
            this.groupBox_mitszamoljunk.TabIndex = 6;
            this.groupBox_mitszamoljunk.TabStop = false;
            this.groupBox_mitszamoljunk.Text = "Mit számoljunk?";
            // 
            // radioButton_szazezerfelett
            // 
            this.radioButton_szazezerfelett.AutoSize = true;
            this.radioButton_szazezerfelett.Location = new System.Drawing.Point(7, 20);
            this.radioButton_szazezerfelett.Name = "radioButton_szazezerfelett";
            this.radioButton_szazezerfelett.Size = new System.Drawing.Size(163, 17);
            this.radioButton_szazezerfelett.TabIndex = 0;
            this.radioButton_szazezerfelett.TabStop = true;
            this.radioButton_szazezerfelett.Text = "100.000-nél nagyobb területű";
            this.radioButton_szazezerfelett.UseVisualStyleBackColor = true;
            // 
            // radioButton_legfeljebbszazezer
            // 
            this.radioButton_legfeljebbszazezer.AutoSize = true;
            this.radioButton_legfeljebbszazezer.Location = new System.Drawing.Point(6, 42);
            this.radioButton_legfeljebbszazezer.Name = "radioButton_legfeljebbszazezer";
            this.radioButton_legfeljebbszazezer.Size = new System.Drawing.Size(150, 17);
            this.radioButton_legfeljebbszazezer.TabIndex = 1;
            this.radioButton_legfeljebbszazezer.TabStop = true;
            this.radioButton_legfeljebbszazezer.Text = "legfeljebb 100.000 területű";
            this.radioButton_legfeljebbszazezer.UseVisualStyleBackColor = true;
            // 
            // label_eredmeny
            // 
            this.label_eredmeny.AutoSize = true;
            this.label_eredmeny.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_eredmeny.Location = new System.Drawing.Point(207, 148);
            this.label_eredmeny.Name = "label_eredmeny";
            this.label_eredmeny.Size = new System.Drawing.Size(97, 13);
            this.label_eredmeny.TabIndex = 7;
            this.label_eredmeny.Text = "Eredményfájl neve:";
            // 
            // textBox_eredmeny
            // 
            this.textBox_eredmeny.Location = new System.Drawing.Point(210, 165);
            this.textBox_eredmeny.Name = "textBox_eredmeny";
            this.textBox_eredmeny.Size = new System.Drawing.Size(179, 20);
            this.textBox_eredmeny.TabIndex = 8;
            // 
            // button_kiiras
            // 
            this.button_kiiras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_kiiras.Location = new System.Drawing.Point(210, 192);
            this.button_kiiras.Name = "button_kiiras";
            this.button_kiiras.Size = new System.Drawing.Size(179, 23);
            this.button_kiiras.TabIndex = 9;
            this.button_kiiras.Text = "Kiírás";
            this.button_kiiras.UseVisualStyleBackColor = true;
            // 
            // label_minvagymax
            // 
            this.label_minvagymax.AutoSize = true;
            this.label_minvagymax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_minvagymax.Location = new System.Drawing.Point(210, 232);
            this.label_minvagymax.Name = "label_minvagymax";
            this.label_minvagymax.Size = new System.Drawing.Size(126, 13);
            this.label_minvagymax.TabIndex = 10;
            this.label_minvagymax.Text = "Minimum vagy maximum?";
            // 
            // button_maxminkivalasztasa
            // 
            this.button_maxminkivalasztasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_maxminkivalasztasa.Location = new System.Drawing.Point(213, 276);
            this.button_maxminkivalasztasa.Name = "button_maxminkivalasztasa";
            this.button_maxminkivalasztasa.Size = new System.Drawing.Size(176, 23);
            this.button_maxminkivalasztasa.TabIndex = 11;
            this.button_maxminkivalasztasa.Text = "Minimum / Maximum kiválasztása";
            this.button_maxminkivalasztasa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(213, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label_orszagkeresese
            // 
            this.label_orszagkeresese.AutoSize = true;
            this.label_orszagkeresese.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_orszagkeresese.Location = new System.Drawing.Point(214, 316);
            this.label_orszagkeresese.Name = "label_orszagkeresese";
            this.label_orszagkeresese.Size = new System.Drawing.Size(89, 13);
            this.label_orszagkeresese.TabIndex = 13;
            this.label_orszagkeresese.Text = "Ország keresése:";
            // 
            // textBox_keresettorszag
            // 
            this.textBox_keresettorszag.Location = new System.Drawing.Point(214, 333);
            this.textBox_keresettorszag.Name = "textBox_keresettorszag";
            this.textBox_keresettorszag.Size = new System.Drawing.Size(175, 20);
            this.textBox_keresettorszag.TabIndex = 14;
            // 
            // checkBox_talalatokjelolese
            // 
            this.checkBox_talalatokjelolese.AutoSize = true;
            this.checkBox_talalatokjelolese.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_talalatokjelolese.Location = new System.Drawing.Point(214, 365);
            this.checkBox_talalatokjelolese.Name = "checkBox_talalatokjelolese";
            this.checkBox_talalatokjelolese.Size = new System.Drawing.Size(156, 17);
            this.checkBox_talalatokjelolese.TabIndex = 15;
            this.checkBox_talalatokjelolese.Text = "Találatok jelölése a listában";
            this.checkBox_talalatokjelolese.UseVisualStyleBackColor = true;
            // 
            // button_kereses
            // 
            this.button_kereses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_kereses.Location = new System.Drawing.Point(214, 393);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(175, 23);
            this.button_kereses.TabIndex = 16;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(955, 567);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.checkBox_talalatokjelolese);
            this.Controls.Add(this.textBox_keresettorszag);
            this.Controls.Add(this.label_orszagkeresese);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_maxminkivalasztasa);
            this.Controls.Add(this.label_minvagymax);
            this.Controls.Add(this.button_kiiras);
            this.Controls.Add(this.textBox_eredmeny);
            this.Controls.Add(this.label_eredmeny);
            this.Controls.Add(this.groupBox_mitszamoljunk);
            this.Controls.Add(this.button_megszamolas);
            this.Controls.Add(this.button_teruletekatlaga);
            this.Controls.Add(this.listBox_orszaglista);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.textBox_forrasfajl);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Példa Windows Forms alkalmazás";
            this.groupBox_mitszamoljunk.ResumeLayout(false);
            this.groupBox_mitszamoljunk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_forrasfajl;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.ListBox listBox_orszaglista;
        private System.Windows.Forms.Button button_teruletekatlaga;
        private System.Windows.Forms.Button button_megszamolas;
        private System.Windows.Forms.GroupBox groupBox_mitszamoljunk;
        private System.Windows.Forms.RadioButton radioButton_szazezerfelett;
        private System.Windows.Forms.RadioButton radioButton_legfeljebbszazezer;
        private System.Windows.Forms.Label label_eredmeny;
        private System.Windows.Forms.TextBox textBox_eredmeny;
        private System.Windows.Forms.Button button_kiiras;
        private System.Windows.Forms.Label label_minvagymax;
        private System.Windows.Forms.Button button_maxminkivalasztasa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_orszagkeresese;
        private System.Windows.Forms.TextBox textBox_keresettorszag;
        private System.Windows.Forms.CheckBox checkBox_talalatokjelolese;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

