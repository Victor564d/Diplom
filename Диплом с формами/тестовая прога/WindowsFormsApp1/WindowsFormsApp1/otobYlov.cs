using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsУл : Form
    {
        public Hamsa mainform;
        public SettingsУл(Hamsa mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = mainform.уловыDataGridView.Columns[0].Visible;
            checkBox2.Checked = mainform.уловыDataGridView.Columns[8].Visible;
            checkBox3.Checked = mainform.уловыDataGridView.Columns[9].Visible;
            checkBox6.Checked = mainform.уловыDataGridView.Columns[10].Visible;
            checkBox5.Checked = mainform.уловыDataGridView.Columns[11].Visible;
            checkBox4.Checked = mainform.уловыDataGridView.Columns[12].Visible;
            checkBox10.Checked = mainform.уловыDataGridView.Columns[13].Visible;
            checkBox9.Checked = mainform.уловыDataGridView.Columns[14].Visible;
            checkBox8.Checked = mainform.уловыDataGridView.Columns[15].Visible;
            checkBox7.Checked = mainform.уловыDataGridView.Columns[16].Visible;
            checkBox18.Checked = mainform.уловыDataGridView.Columns[19].Visible;
            checkBox20.Checked = mainform.уловыDataGridView.Columns[17].Visible;
            checkBox19.Checked = mainform.уловыDataGridView.Columns[18].Visible;
            checkBox17.Checked = mainform.уловыDataGridView.Columns[20].Visible;
            checkBox16.Checked = mainform.уловыDataGridView.Columns[21].Visible;
            checkBox15.Checked = mainform.уловыDataGridView.Columns[22].Visible;
            checkBox14.Checked = mainform.уловыDataGridView.Columns[23].Visible;
            checkBox13.Checked = mainform.уловыDataGridView.Columns[24].Visible;
            checkBox12.Checked = mainform.уловыDataGridView.Columns[25].Visible;
            checkBox11.Checked = mainform.уловыDataGridView.Columns[26].Visible;
            checkBox27.Checked = mainform.уловыDataGridView.Columns[27].Visible;
            checkBox26.Checked = mainform.уловыDataGridView.Columns[28].Visible;
            checkBox25.Checked = mainform.уловыDataGridView.Columns[29].Visible;
            checkBox24.Checked = mainform.уловыDataGridView.Columns[30].Visible;
            checkBox21.Checked = mainform.уловыDataGridView.Columns[31].Visible;
            checkBox23.Checked = mainform.уловыDataGridView.Columns[33].Visible;
            checkBox22.Checked = mainform.уловыDataGridView.Columns[34].Visible;
            checkBox1.Text = mainform.уловыDataGridView.Columns[0].HeaderText;
            checkBox2.Text = mainform.уловыDataGridView.Columns[8].HeaderText;
            checkBox3.Text = mainform.уловыDataGridView.Columns[9].HeaderText;
            checkBox6.Text = mainform.уловыDataGridView.Columns[10].HeaderText;
            checkBox5.Text = mainform.уловыDataGridView.Columns[11].HeaderText;
            checkBox4.Text = mainform.уловыDataGridView.Columns[12].HeaderText;
            checkBox10.Text = mainform.уловыDataGridView.Columns[13].HeaderText;
            checkBox9.Text = mainform.уловыDataGridView.Columns[14].HeaderText;
            checkBox8.Text = mainform.уловыDataGridView.Columns[15].HeaderText;
            checkBox7.Text = mainform.уловыDataGridView.Columns[16].HeaderText;
            checkBox18.Text = mainform.уловыDataGridView.Columns[19].HeaderText;
            checkBox20.Text = mainform.уловыDataGridView.Columns[17].HeaderText;
            checkBox19.Text = mainform.уловыDataGridView.Columns[18].HeaderText;
            checkBox17.Text = mainform.уловыDataGridView.Columns[20].HeaderText;
            checkBox16.Text = mainform.уловыDataGridView.Columns[21].HeaderText;
            checkBox15.Text = mainform.уловыDataGridView.Columns[22].HeaderText;
            checkBox14.Text = mainform.уловыDataGridView.Columns[23].HeaderText;
            checkBox13.Text = mainform.уловыDataGridView.Columns[24].HeaderText;
            checkBox12.Text = mainform.уловыDataGridView.Columns[25].HeaderText;
            checkBox11.Text = mainform.уловыDataGridView.Columns[26].HeaderText;
            checkBox27.Text = mainform.уловыDataGridView.Columns[27].HeaderText;
            checkBox26.Text = mainform.уловыDataGridView.Columns[28].HeaderText;
            checkBox25.Text = mainform.уловыDataGridView.Columns[29].HeaderText;
            checkBox24.Text = mainform.уловыDataGridView.Columns[30].HeaderText;
            checkBox21.Text = mainform.уловыDataGridView.Columns[31].HeaderText;
            checkBox23.Text = mainform.уловыDataGridView.Columns[33].HeaderText;
            checkBox22.Text = mainform.уловыDataGridView.Columns[34].HeaderText;


        }

    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[0].Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[8].Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[9].Visible = checkBox3.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[10].Visible = checkBox6.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[11].Visible = checkBox5.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[12].Visible = checkBox4.Checked;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[13].Visible = checkBox10.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[14].Visible = checkBox9.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[15].Visible = checkBox8.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[16].Visible = checkBox7.Checked;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[19].Visible = checkBox18.Checked;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[17].Visible = checkBox20.Checked;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[18].Visible = checkBox19.Checked;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[20].Visible = checkBox17.Checked;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[21].Visible = checkBox16.Checked;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[22].Visible = checkBox15.Checked;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[23].Visible = checkBox14.Checked;

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[24].Visible = checkBox13.Checked;

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
           // mainform.уловыDataGridView.Columns[25].Visible = checkBox12.Checked;

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
         //   mainform.уловыDataGridView.Columns[26].Visible = checkBox11.Checked;

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[27].Visible = checkBox27.Checked;
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[28].Visible = checkBox26.Checked;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
         //   mainform.уловыDataGridView.Columns[29].Visible = checkBox25.Checked;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[30].Visible = checkBox24.Checked;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
         //   mainform.уловыDataGridView.Columns[31].Visible = checkBox21.Checked;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
         //   mainform.уловыDataGridView.Columns[33].Visible = checkBox23.Checked;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
          //  mainform.уловыDataGridView.Columns[34].Visible = checkBox22.Checked;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox6.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
            checkBox10.Checked = false;
            checkBox9.Checked = false;
            checkBox8.Checked = false;
            checkBox7.Checked = false;
            checkBox18.Checked = false;
            checkBox20.Checked = false;
            checkBox19.Checked = false;
            checkBox17.Checked = false;
            checkBox16.Checked = false;
            checkBox15.Checked = false;
            checkBox14.Checked = false;
            checkBox13.Checked = false;
            checkBox12.Checked = false;
            checkBox11.Checked = false;
            checkBox27.Checked = false;
            checkBox26.Checked = false;
            checkBox25.Checked = false;
            checkBox24.Checked = false;
            checkBox21.Checked = false;
            checkBox23.Checked = false;
            checkBox22.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox6.Checked = true;
            checkBox5.Checked = true;
            checkBox4.Checked = true;
            checkBox10.Checked = true;
            checkBox9.Checked = true;
            checkBox8.Checked = true;
            checkBox7.Checked = true;
            checkBox18.Checked = true;
            checkBox20.Checked = true;
            checkBox19.Checked = true;
            checkBox17.Checked = true;
            checkBox16.Checked = true;
            checkBox15.Checked = true;
            checkBox14.Checked = true;
            checkBox13.Checked = true;
            checkBox12.Checked = true;
            checkBox11.Checked = true;
            checkBox27.Checked = true;
            checkBox26.Checked = true;
            checkBox25.Checked = true;
            checkBox24.Checked = true;
            checkBox21.Checked = true;
            checkBox23.Checked = true;
            checkBox22.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform.уловыDataGridView.Columns[0].Visible = checkBox1.Checked;
            mainform.уловыDataGridView.Columns[8].Visible = checkBox2.Checked;
            mainform.уловыDataGridView.Columns[9].Visible = checkBox3.Checked;
            mainform.уловыDataGridView.Columns[10].Visible = checkBox6.Checked;
            mainform.уловыDataGridView.Columns[11].Visible = checkBox5.Checked;
            mainform.уловыDataGridView.Columns[12].Visible = checkBox4.Checked;
            mainform.уловыDataGridView.Columns[13].Visible = checkBox10.Checked;
            mainform.уловыDataGridView.Columns[14].Visible = checkBox9.Checked;
            mainform.уловыDataGridView.Columns[15].Visible = checkBox8.Checked;
            mainform.уловыDataGridView.Columns[16].Visible = checkBox7.Checked;
            mainform.уловыDataGridView.Columns[19].Visible = checkBox18.Checked;
            mainform.уловыDataGridView.Columns[17].Visible = checkBox20.Checked;
            mainform.уловыDataGridView.Columns[18].Visible = checkBox19.Checked;
            mainform.уловыDataGridView.Columns[20].Visible = checkBox17.Checked;
            mainform.уловыDataGridView.Columns[21].Visible = checkBox16.Checked;
            mainform.уловыDataGridView.Columns[22].Visible = checkBox15.Checked;
            mainform.уловыDataGridView.Columns[23].Visible = checkBox14.Checked;
            mainform.уловыDataGridView.Columns[24].Visible = checkBox13.Checked;
            mainform.уловыDataGridView.Columns[25].Visible = checkBox12.Checked;
            mainform.уловыDataGridView.Columns[26].Visible = checkBox11.Checked;
            mainform.уловыDataGridView.Columns[27].Visible = checkBox27.Checked;
            mainform.уловыDataGridView.Columns[28].Visible = checkBox26.Checked;
            mainform.уловыDataGridView.Columns[29].Visible = checkBox25.Checked;
            mainform.уловыDataGridView.Columns[30].Visible = checkBox24.Checked;
            mainform.уловыDataGridView.Columns[31].Visible = checkBox21.Checked;
            mainform.уловыDataGridView.Columns[33].Visible = checkBox23.Checked;
            mainform.уловыDataGridView.Columns[34].Visible = checkBox22.Checked;

        }
    }
}
