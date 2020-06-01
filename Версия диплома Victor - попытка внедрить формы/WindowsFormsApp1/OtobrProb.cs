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
    public partial class OtobrProb : Form
    {
        Proby mainform;
        public OtobrProb(Proby mainform  )
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void OtobrProb_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = mainform.пробыDataGridView.Columns[3].Visible;
            checkBox1.Text = mainform.пробыDataGridView.Columns[3].HeaderText;
            checkBox2.Checked = mainform.пробыDataGridView.Columns[9].Visible;
            checkBox2.Text = mainform.пробыDataGridView.Columns[9].HeaderText;
            checkBox3.Checked = mainform.пробыDataGridView.Columns[10].Visible;
            checkBox3.Text = mainform.пробыDataGridView.Columns[10].HeaderText;
            checkBox4.Checked = mainform.пробыDataGridView.Columns[11].Visible;
            checkBox4.Text = mainform.пробыDataGridView.Columns[11].HeaderText;
            checkBox5.Checked = mainform.пробыDataGridView.Columns[12].Visible;
            checkBox5.Text = mainform.пробыDataGridView.Columns[12].HeaderText;
            checkBox6.Checked = mainform.пробыDataGridView.Columns[13].Visible;
            checkBox6.Text = mainform.пробыDataGridView.Columns[13].HeaderText;
            checkBox7.Checked = mainform.пробыDataGridView.Columns[14].Visible;
            checkBox7.Text = mainform.пробыDataGridView.Columns[14].HeaderText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform.пробыDataGridView.Columns[3].Visible = checkBox1.Checked;
            mainform.пробыDataGridView.Columns[9].Visible = checkBox2.Checked;
            mainform.пробыDataGridView.Columns[10].Visible = checkBox3.Checked;
            mainform.пробыDataGridView.Columns[11].Visible = checkBox4.Checked;
            mainform.пробыDataGridView.Columns[12].Visible = checkBox5.Checked;
            mainform.пробыDataGridView.Columns[13].Visible = checkBox6.Checked;
            mainform.пробыDataGridView.Columns[14].Visible = checkBox7.Checked;
        }
    }
}
