using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Catch_Record_Form : Form
    {
        //----------------------------------------------Область переменных ------------------------------------------------------//
       public  ArrayList zapis = new ArrayList();
        public ArrayList orig = new ArrayList();
        String data;
        String dd, mm, gg;
        public string operation;
        //-------------------------------------------конец Области переменных ---------------------------------------------------//
        private Hamsa mainform;
        public Catch_Record_Form(Hamsa mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Catch_Record_Form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(zapis[0]);
            textBox2.Text = Convert.ToString(zapis[1]);
            textBox3.Text = Convert.ToString(zapis[2]);
            textBox5.Text = Convert.ToString(zapis[3]);
            textBox4.Text = Convert.ToString(zapis[4]);
            textBox6.Text = Convert.ToString(zapis[5]);
            textBox7.Text = Convert.ToString(zapis[6]);
            textBox8.Text = Convert.ToString(zapis[7]);
            textBox9.Text = Convert.ToString(zapis[8]);
            textBox10.Text = Convert.ToString(zapis[9]);
            textBox14.Text = Convert.ToString(zapis[10]);
            textBox13.Text = Convert.ToString(zapis[11]);
            textBox15.Text = Convert.ToString(zapis[12]);
            textBox16.Text = Convert.ToString(zapis[13]);
            textBox17.Text = Convert.ToString(zapis[14]);
            textBox18.Text = Convert.ToString(zapis[15]);
            textBox19.Text = Convert.ToString(zapis[16]);
            textBox31.Text = Convert.ToString(zapis[17]);
            textBox12.Text = Convert.ToString(zapis[18]);
            textBox24.Text = Convert.ToString(zapis[19]);
            textBox25.Text = Convert.ToString(zapis[20]);
            textBox23.Text = Convert.ToString(zapis[21]);
            textBox30.Text = Convert.ToString(zapis[22]);
            textBox33.Text = Convert.ToString(zapis[23]);
            textBox26.Text = Convert.ToString(zapis[24]);
            textBox27.Text = Convert.ToString(zapis[25]);
            textBox21.Text = Convert.ToString(zapis[26]);
            textBox28.Text = Convert.ToString(zapis[27]);
            textBox22.Text = Convert.ToString(zapis[28]);
            textBox29.Text = Convert.ToString(zapis[29]);
            textBox34.Text = Convert.ToString(zapis[30]);
            textBox32.Text = Convert.ToString(zapis[31]);
            richTextBox1.Text = Convert.ToString(zapis[32]);
            textBox20.Text = Convert.ToString(zapis[33]);
            textBox11.Text = Convert.ToString(zapis[34]);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void вводДополнительныхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox8.Visible == false) { groupBox8.Visible = true; }
            else { groupBox8.Visible = false; }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void просмотрДополнительныхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox6.Visible == false) { groupBox6.Visible = true; }
            else { groupBox6.Visible = false; }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void записатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            {
                zapis[0] = textBox1.Text;
                zapis[1] = textBox2.Text;
                zapis[2] = textBox3.Text;
                zapis[3] = textBox5.Text;
                zapis[4] = textBox4.Text;
                zapis[5] = textBox6.Text;
                zapis[6] = textBox7.Text;
                zapis[7] = textBox8.Text;
                zapis[8] = textBox9.Text;
                zapis[9] = textBox10.Text;
                zapis[10] = textBox14.Text;
                zapis[11] = textBox13.Text;
                zapis[12] = textBox15.Text;
                zapis[13] = textBox16.Text;
                zapis[14] = textBox17.Text;
                if (textBox18.Text != "")
                    zapis[15] = textBox18.Text;
                else zapis[15] = (null);
                if (Convert.ToString(orig[15]) == "")
                    orig[15] = (null);
                zapis[16] = textBox19.Text;
                zapis[17] = textBox31.Text;
                zapis[18] = textBox12.Text;
                zapis[19] = textBox24.Text;
                zapis[20] = textBox25.Text;
                zapis[21] = textBox23.Text;
                zapis[22] = textBox30.Text;
                zapis[23] = textBox33.Text;
                zapis[24] = textBox26.Text;
                zapis[25] = textBox27.Text;
                zapis[26] = textBox21.Text;
                zapis[27] = textBox28.Text;
                zapis[28] = textBox22.Text;
                zapis[29] = textBox29.Text;
                zapis[30] = textBox34.Text;
                zapis[31] = textBox32.Text;
                zapis[32] = richTextBox1.Text;
                zapis[33] = textBox20.Text;
                zapis[34] = textBox11.Text;
              
            }
            if (operation == "Redact") mainform.upd(zapis, orig);
            if (operation == "New") mainform.ins(zapis);
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
