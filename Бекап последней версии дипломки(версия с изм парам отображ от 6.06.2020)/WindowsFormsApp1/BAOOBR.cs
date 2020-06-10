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
    public partial class BAOOBR : Form
    {
        BA mainform;
        public BAOOBR(BA mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void BAOOBR_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = mainform.бАDataGridView.Columns[1].Visible;
            checkBox1.Text = mainform.бАDataGridView.Columns[1].HeaderText;
            checkBox2.Checked = mainform.бАDataGridView.Columns[3].Visible;
            checkBox2.Text = mainform.бАDataGridView.Columns[3].HeaderText;
            checkBox3.Checked = mainform.бАDataGridView.Columns[4].Visible;
            checkBox3.Text = mainform.бАDataGridView.Columns[4].HeaderText;
            checkBox4.Checked = mainform.бАDataGridView.Columns[5].Visible;
            checkBox4.Text = mainform.бАDataGridView.Columns[5].HeaderText;
            checkBox5.Checked = mainform.бАDataGridView.Columns[7].Visible;
            checkBox5.Text = mainform.бАDataGridView.Columns[7].HeaderText;
            checkBox6.Checked = mainform.бАDataGridView.Columns[12].Visible;
            checkBox6.Text = mainform.бАDataGridView.Columns[12].HeaderText;
            checkBox7.Checked = mainform.бАDataGridView.Columns[16].Visible;
            checkBox7.Text = mainform.бАDataGridView.Columns[16].HeaderText;
            checkBox8.Checked = mainform.бАDataGridView.Columns[17].Visible;
            checkBox8.Text = mainform.бАDataGridView.Columns[17].HeaderText;
            checkBox9.Checked = mainform.бАDataGridView.Columns[18].Visible;
            checkBox9.Text = mainform.бАDataGridView.Columns[18].HeaderText;
            checkBox10.Checked = mainform.бАDataGridView.Columns[19].Visible;
            checkBox10.Text = mainform.бАDataGridView.Columns[19].HeaderText;
            checkBox11.Checked = mainform.бАDataGridView.Columns[20].Visible;
            checkBox11.Text = mainform.бАDataGridView.Columns[20].HeaderText;
            checkBox12.Checked = mainform.бАDataGridView.Columns[21].Visible;
            checkBox12.Text = mainform.бАDataGridView.Columns[21].HeaderText;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform.бАDataGridView.Columns[1].Visible = checkBox1.Checked;
            mainform.бАDataGridView.Columns[3].Visible = checkBox2.Checked;
            mainform.бАDataGridView.Columns[4].Visible = checkBox3.Checked;
            mainform.бАDataGridView.Columns[5].Visible = checkBox4.Checked;
            mainform.бАDataGridView.Columns[7].Visible = checkBox5.Checked;
            mainform.бАDataGridView.Columns[12].Visible = checkBox6.Checked;
            mainform.бАDataGridView.Columns[16].Visible = checkBox7.Checked;
            mainform.бАDataGridView.Columns[17].Visible = checkBox8.Checked;
            mainform.бАDataGridView.Columns[18].Visible = checkBox9.Checked;
            mainform.бАDataGridView.Columns[19].Visible = checkBox10.Checked;
            mainform.бАDataGridView.Columns[20].Visible = checkBox11.Checked;
            mainform.бАDataGridView.Columns[21].Visible = checkBox12.Checked;
        }
    }
}
