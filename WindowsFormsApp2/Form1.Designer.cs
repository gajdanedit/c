﻿namespace WindowsFormsApp2
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
            this.listBox_tagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_orszkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.label_szulev = new System.Windows.Forms.Label();
            this.numericUpDown_irszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_azon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_tagok
            // 
            this.listBox_tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_tagok.FormattingEnabled = true;
            this.listBox_tagok.ItemHeight = 20;
            this.listBox_tagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_tagok.Name = "listBox_tagok";
            this.listBox_tagok.Size = new System.Drawing.Size(120, 597);
            this.listBox_tagok.TabIndex = 0;
            this.listBox_tagok.SelectedIndexChanged += new System.EventHandler(this.listBox_tagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox_orszkod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_szulev);
            this.groupBox1.Controls.Add(this.label_szulev);
            this.groupBox1.Controls.Add(this.numericUpDown_irszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_azon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott tag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_edit);
            this.groupBox2.Controls.Add(this.button_insert);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 159);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(190, 101);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(204, 33);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(190, 66);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(204, 29);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Módosítás";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(190, 25);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(204, 35);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "Létrehozás";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // textBox_orszkod
            // 
            this.textBox_orszkod.Location = new System.Drawing.Point(22, 347);
            this.textBox_orszkod.Name = "textBox_orszkod";
            this.textBox_orszkod.Size = new System.Drawing.Size(100, 26);
            this.textBox_orszkod.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Országkód";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(18, 276);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_szulev.TabIndex = 7;
            this.numericUpDown_szulev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label_szulev
            // 
            this.label_szulev.AutoSize = true;
            this.label_szulev.Location = new System.Drawing.Point(14, 252);
            this.label_szulev.Name = "label_szulev";
            this.label_szulev.Size = new System.Drawing.Size(94, 20);
            this.label_szulev.TabIndex = 6;
            this.label_szulev.Text = "Születési év";
            // 
            // numericUpDown_irszam
            // 
            this.numericUpDown_irszam.Location = new System.Drawing.Point(14, 201);
            this.numericUpDown_irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_irszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Name = "numericUpDown_irszam";
            this.numericUpDown_irszam.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_irszam.TabIndex = 5;
            this.numericUpDown_irszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_irszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Irányítószám";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(10, 128);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(201, 26);
            this.textBox_nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_azon
            // 
            this.textBox_azon.Location = new System.Drawing.Point(10, 58);
            this.textBox_azon.Name = "textBox_azon";
            this.textBox_azon.ReadOnly = true;
            this.textBox_azon.Size = new System.Drawing.Size(100, 26);
            this.textBox_azon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(805, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_tagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tagok nyilvantartasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_azon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_szulev;
        private System.Windows.Forms.NumericUpDown numericUpDown_irszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.TextBox textBox_orszkod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
    }
}

