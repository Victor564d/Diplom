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
    public partial class FiltrYLR : Form
    {
        Hamsa mainform;
        public void Filters()
        {
            if (comboBox1.SelectedIndex != 0)
            {
                if(comboBox2.SelectedIndex != 0)
                {
                    if (comboBox6.SelectedIndex != 0)
                    {
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox2.SelectedItem), Convert.ToString(comboBox6.SelectedItem),Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else { mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox2.SelectedItem), Convert.ToString("%"), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                } else
                {
                    if (comboBox6.SelectedIndex!= 0)
                    {
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString(comboBox1.SelectedItem), Convert.ToString("%"), Convert.ToString(comboBox6.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else
                    {
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString(comboBox1.SelectedItem), Convert.ToString("%"), Convert.ToString("%"), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                }
            } else
            {
                if (comboBox2.SelectedIndex != 0)
                {
                    if (comboBox6.SelectedIndex != 0)
                    {
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString("%"), Convert.ToString(comboBox2.SelectedItem), Convert.ToString(comboBox6.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else { mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString("%"), Convert.ToString(comboBox2.SelectedItem), Convert.ToString("%"), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                }
                else
                {
                    if (comboBox6.SelectedIndex != 0)
                    {
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString("%"), Convert.ToString("%"), Convert.ToString(comboBox6.SelectedItem), Convert.ToString(mainform.idnt));
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                    }
                    else
                    {
                        mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
                        mainform.уловыTableAdapter.FillRegAll(mainform.тестовая_бд_DataSet.Уловы, Convert.ToString("%"), Convert.ToString("%"), Convert.ToString("%"), Convert.ToString(mainform.idnt));
                    }
                }
            }
        }
        public FiltrYLR(Hamsa mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
        ArrayList dd = new ArrayList();
        private void FiltrYLR_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mainform.уловыDataGridView.Rows.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < dd.Count; j++)
                    if (Convert.ToString(dd[j]) == (Convert.ToString(mainform.уловыDataGridView[5, i].Value)))
                        b = true;
                if (b == false)
                {
                    dd.Add(Convert.ToString(mainform.уловыDataGridView[5, i].Value));
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
                    if (Convert.ToString(dd[j]) == (Convert.ToString(mainform.уловыDataGridView[6, i].Value)))
                        b = true;
                if (b == false)
                {
                    dd.Add(Convert.ToString(mainform.уловыDataGridView[6, i].Value));
                }

            }
            comboBox2.Items.Clear();
            dd.Sort();
            for (int i = 0; i < dd.Count; i++)
                comboBox2.Items.Add(dd[i]);
            dd.Clear();
            for (int i = 0; i < mainform.уловыDataGridView.Rows.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < dd.Count; j++)
                    if (Convert.ToString(dd[j]) == (Convert.ToString(mainform.уловыDataGridView[7, i].Value)))
                        b = true;
                if (b == false)
                {
                    dd.Add(Convert.ToString(mainform.уловыDataGridView[7, i].Value));
                }

            }
            comboBox6.Items.Clear();
            dd.Sort();
            for (int i = 0; i < dd.Count; i++)
                comboBox6.Items.Add(dd[i]);
            comboBox1.Items[0] = "Не задан";
            comboBox2.Items[0] = "Не задан";
            comboBox6.Items[0] = "Не задан";
          
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }
    }
}
