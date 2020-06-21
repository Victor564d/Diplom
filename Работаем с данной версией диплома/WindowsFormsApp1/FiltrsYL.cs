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
namespace WindowsFormsApp1
{
   
    public partial class FiltrsYL : Form
    {
        public Hamsa mainform;
        public FiltrsYL(Hamsa mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
        public ArrayList dd = new ArrayList(1);
        private void FiltrsYL_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mainform.уловыDataGridView.Rows.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < dd.Count; j++)
                    if (Convert.ToInt32(dd[j]) == (Convert.ToInt32(mainform.уловыDataGridView[3, i].Value)))
                         b = true;
                    if (b== false)
                {
                    dd.Add(Convert.ToInt32(mainform.уловыDataGridView[3, i].Value));
                }
              
            }
            comboBox1.Items.Clear();
            dd.Sort();
            for (int i = 0; i < dd.Count; i++) 
            comboBox1.Items.Add(dd[i]);
            dd.Clear();
            for (int i = 0; i < mainform.уловыDataGridView.Rows.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < dd.Count; j++)
                    if (Convert.ToInt32(dd[j]) == (Convert.ToInt32(mainform.уловыDataGridView[4, i].Value)))
                        b = true;
                if (b == false)
                {
                    dd.Add(Convert.ToInt32(mainform.уловыDataGridView[4, i].Value));
                }

            }
            comboBox2.Items.Clear();
            dd.Sort();
            for (int i = 0; i < dd.Count; i++)
                comboBox2.Items.Add(dd[i]);
            comboBox1.Items[0] = "Не задан";
            comboBox2.Items[0] = "Не задан";
            comboBox3.Items[0] = "Не задан";
            comboBox4.Items[0] = "Не задан";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedIndex != 0) || (comboBox4.SelectedIndex != 0))
            {
                
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                if (comboBox2.SelectedIndex != 0)
                    if (comboBox4.SelectedIndex == 1)
                    {
                        mainform.уловыTableAdapter.FillDDBE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        mainform.уловыTableAdapter.FillDDME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox4.SelectedIndex == 3)
                    {
                        mainform.уловыTableAdapter.FillDDE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((comboBox1.SelectedIndex != 0) || (comboBox3.SelectedIndex != 0)))
            {
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                if (comboBox1.SelectedIndex != 0)
                    if (comboBox3.SelectedIndex == 1)
                    {
                        mainform.уловыTableAdapter.FiillMMBE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        mainform.уловыTableAdapter.FillMMME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        mainform.уловыTableAdapter.FillMME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
            }
            else
            {
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedIndex != 0) || (comboBox4.SelectedIndex != 0))
            {
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                if (comboBox2.SelectedIndex != 0)
                    if (comboBox4.SelectedIndex == 1)
                    {
                        mainform.уловыTableAdapter.FillDDBE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        mainform.уловыTableAdapter.FillDDME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox4.SelectedIndex == 3)
                    {
                        mainform.уловыTableAdapter.FillDDE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox2.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex != 0) || (comboBox3.SelectedIndex != 0))
            {
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                if (comboBox1.SelectedIndex != 0)
                    if (comboBox3.SelectedIndex == 1)
                    {
                        mainform.уловыTableAdapter.FiillMMBE(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        mainform.уловыTableAdapter.FillMMME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        mainform.уловыTableAdapter.FillMME(mainform.тестовая_бд_DataSet.Уловы, Convert.ToInt16(comboBox1.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
            }
            else
            {
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
