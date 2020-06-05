using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Biological_analysis_form : Form
    {
        //----------------------------------------------Область переменных ------------------------------------------------------//
        public ArrayList zapis = new ArrayList();
        public ArrayList orig = new ArrayList();
        String data;
        String dd, mm, gg;
        public string operation;
        //-------------------------------------------конец Области переменных ---------------------------------------------------//

        public Biological_analysis_form(BA bA)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void вводДополнительныхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox6.Visible == false) { groupBox6.Visible = true; }
            else { groupBox6.Visible = false; }
        }
    }
}
