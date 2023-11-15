using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            string kiindulasiFajl = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "pizza.csv";
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes(kiindulasiFajl);
            }
        }

        private void Adatbetoltes(string kiindulasiFajl)
        {
            Adatbetoltes(kiindulasiFajl);
        }
    }
}
