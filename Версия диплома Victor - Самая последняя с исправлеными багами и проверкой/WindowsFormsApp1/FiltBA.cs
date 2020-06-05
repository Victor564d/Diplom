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
    public partial class FiltBA : Form
    {
        BA mainform;
        public FiltBA(BA mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
        public void Filtr()
        {
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if ((textBox1.Text == "") || (textBox1.Text == "0"))
                    {
                        MessageBox.Show("Введено неверное значение в первое поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Decimal t1, t2;
                        if ((textBox2.Text != "") || (textBox2.Text != "0"))
                        {
                            t2 = Convert.ToDecimal(textBox2.Text);
                            t1 = Convert.ToDecimal(textBox1.Text);
                          //  MessageBox.Show(Convert.ToString(t1))
                            mainform.бАTableAdapter.FillTL(mainform.тестовая_бд_DataSet.БА,
                                Convert.ToString(mainform.cells[0]),
                        Convert.ToString(mainform.cells[1]),
                        Convert.ToString(mainform.cells[2]),
                        Convert.ToString(mainform.cells[3]),
                        Convert.ToString(mainform.cells[4]),
                        Convert.ToString(mainform.cells[5]),
                        Convert.ToString(mainform.cells[6]),
                        Convert.ToString(mainform.cells[7]),
                        Convert.ToString(mainform.cells[8]),
                        Convert.ToString(mainform.cells[9]),
                        Convert.ToString(mainform.cells[10]),
                        Convert.ToString(mainform.cells[11]),
                        Convert.ToString(mainform.cells[12]),
                        Convert.ToString(mainform.cells[13]),
                        Convert.ToString(mainform.cells[14]),
                        Convert.ToString(mainform.cells[15]),
                        Convert.ToString(mainform.cells[16]),
                        Convert.ToString(mainform.cells[17]),
                        Convert.ToString(mainform.cells[18]),
                        Convert.ToString(mainform.cells[19]),
                        Convert.ToString(mainform.cells[20]),
                        Convert.ToString(mainform.cells[21]),
                        Convert.ToString(mainform.cells[22]),
                        Convert.ToString(mainform.cells[23]),
                        Convert.ToString(mainform.cells[24]),
                        Convert.ToString(mainform.cells[25]),
                        Convert.ToString(mainform.cells[26]),
                        Convert.ToString(mainform.cells[27]),
                        Convert.ToString(mainform.cells[28]),
                        Convert.ToString(mainform.cells[29]),
                        Convert.ToString(mainform.cells[30]),
                        Convert.ToString(mainform.cells[31]),
                        Convert.ToString(mainform.cells[32]),
                        Convert.ToString(mainform.cells[33]),
                        Convert.ToString(mainform.cells[34]),
                        Convert.ToString(mainform.cells[35]),
                        Convert.ToString(mainform.cells[36]),
                        Convert.ToString(mainform.cells[37]),
                        Convert.ToString(mainform.cells[38]),
                        Convert.ToString(mainform.cells[39]),
                        Convert.ToString(mainform.cells[40]),
                        Convert.ToString(mainform.cells[41]),
                        Convert.ToString(mainform.cells[42]),
                        Convert.ToString(mainform.cells[43]),
                        Convert.ToString(mainform.cells[44]),
                        Convert.ToString(mainform.cells[45]),
                        Convert.ToString(mainform.cells[46]),
                        Convert.ToString(mainform.cells[47]),
                        Convert.ToString(mainform.cells[48]),
                        Convert.ToString(mainform.cells[49]),
                        Convert.ToString(mainform.cells[50]),
                        Convert.ToString(mainform.cells[51]),
                        Convert.ToString(mainform.cells[52]),
                        Convert.ToString(mainform.cells[53]),
                        Convert.ToString(mainform.cells[54]),
                        Convert.ToString(mainform.cells[55]),
                        Convert.ToString(mainform.cells[56]),
                        Convert.ToString(mainform.cells[57]),
                        Convert.ToString(mainform.cells[58]),
                        Convert.ToString(mainform.cells[59]),
                        Convert.ToString(mainform.cells[60]),
                        Convert.ToString(mainform.cells[61]),
                        Convert.ToString(mainform.cells[62]),
                        Convert.ToString(mainform.cells[63]),
                        Convert.ToString(mainform.cells[64]),
                        Convert.ToString(mainform.cells[65]),
                        Convert.ToString(mainform.cells[66]),
                        Convert.ToString(mainform.cells[67]),
                        Convert.ToString(mainform.cells[68]),
                        Convert.ToString(mainform.cells[69]),
                        Convert.ToString(mainform.cells[70]),
                        Convert.ToString(mainform.cells[71]),
                        Convert.ToString(mainform.cells[72]),
                        Convert.ToString(mainform.cells[73]),
                        Convert.ToString(mainform.cells[74]),
                        Convert.ToString(mainform.cells[75]),
                        Convert.ToString(mainform.cells[76]),
                        Convert.ToString(mainform.cells[77]),
                        Convert.ToString(mainform.cells[78]),
                        Convert.ToString(mainform.cells[79]),
                        t1, t2);
                        }
                        else { MessageBox.Show("Введено неверное значение в второе поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK); }
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if ((textBox1.Text == "") || (textBox1.Text == "0"))
                    {
                        MessageBox.Show("Введено неверное значение в первое поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Decimal t1, t2;
                        if ((textBox2.Text != "") || (textBox2.Text != "0"))
                        {
                            t2 = Convert.ToDecimal(textBox2.Text);
                            t1 = Convert.ToDecimal(textBox1.Text);
                            mainform.бАTableAdapter.FillFL(mainform.тестовая_бд_DataSet.БА,
                                Convert.ToString(mainform.cells[0]),
                        Convert.ToString(mainform.cells[1]),
                        Convert.ToString(mainform.cells[2]),
                        Convert.ToString(mainform.cells[3]),
                        Convert.ToString(mainform.cells[4]),
                        Convert.ToString(mainform.cells[5]),
                        Convert.ToString(mainform.cells[6]),
                        Convert.ToString(mainform.cells[7]),
                        Convert.ToString(mainform.cells[8]),
                        Convert.ToString(mainform.cells[9]),
                        Convert.ToString(mainform.cells[10]),
                        Convert.ToString(mainform.cells[11]),
                        Convert.ToString(mainform.cells[12]),
                        Convert.ToString(mainform.cells[13]),
                        Convert.ToString(mainform.cells[14]),
                        Convert.ToString(mainform.cells[15]),
                        Convert.ToString(mainform.cells[16]),
                        Convert.ToString(mainform.cells[17]),
                        Convert.ToString(mainform.cells[18]),
                        Convert.ToString(mainform.cells[19]),
                        Convert.ToString(mainform.cells[20]),
                        Convert.ToString(mainform.cells[21]),
                        Convert.ToString(mainform.cells[22]),
                        Convert.ToString(mainform.cells[23]),
                        Convert.ToString(mainform.cells[24]),
                        Convert.ToString(mainform.cells[25]),
                        Convert.ToString(mainform.cells[26]),
                        Convert.ToString(mainform.cells[27]),
                        Convert.ToString(mainform.cells[28]),
                        Convert.ToString(mainform.cells[29]),
                        Convert.ToString(mainform.cells[30]),
                        Convert.ToString(mainform.cells[31]),
                        Convert.ToString(mainform.cells[32]),
                        Convert.ToString(mainform.cells[33]),
                        Convert.ToString(mainform.cells[34]),
                        Convert.ToString(mainform.cells[35]),
                        Convert.ToString(mainform.cells[36]),
                        Convert.ToString(mainform.cells[37]),
                        Convert.ToString(mainform.cells[38]),
                        Convert.ToString(mainform.cells[39]),
                        Convert.ToString(mainform.cells[40]),
                        Convert.ToString(mainform.cells[41]),
                        Convert.ToString(mainform.cells[42]),
                        Convert.ToString(mainform.cells[43]),
                        Convert.ToString(mainform.cells[44]),
                        Convert.ToString(mainform.cells[45]),
                        Convert.ToString(mainform.cells[46]),
                        Convert.ToString(mainform.cells[47]),
                        Convert.ToString(mainform.cells[48]),
                        Convert.ToString(mainform.cells[49]),
                        Convert.ToString(mainform.cells[50]),
                        Convert.ToString(mainform.cells[51]),
                        Convert.ToString(mainform.cells[52]),
                        Convert.ToString(mainform.cells[53]),
                        Convert.ToString(mainform.cells[54]),
                        Convert.ToString(mainform.cells[55]),
                        Convert.ToString(mainform.cells[56]),
                        Convert.ToString(mainform.cells[57]),
                        Convert.ToString(mainform.cells[58]),
                        Convert.ToString(mainform.cells[59]),
                        Convert.ToString(mainform.cells[60]),
                        Convert.ToString(mainform.cells[61]),
                        Convert.ToString(mainform.cells[62]),
                        Convert.ToString(mainform.cells[63]),
                        Convert.ToString(mainform.cells[64]),
                        Convert.ToString(mainform.cells[65]),
                        Convert.ToString(mainform.cells[66]),
                        Convert.ToString(mainform.cells[67]),
                        Convert.ToString(mainform.cells[68]),
                        Convert.ToString(mainform.cells[69]),
                        Convert.ToString(mainform.cells[70]),
                        Convert.ToString(mainform.cells[71]),
                        Convert.ToString(mainform.cells[72]),
                        Convert.ToString(mainform.cells[73]),
                        Convert.ToString(mainform.cells[74]),
                        Convert.ToString(mainform.cells[75]),
                        Convert.ToString(mainform.cells[76]),
                        Convert.ToString(mainform.cells[77]),
                        Convert.ToString(mainform.cells[78]),
                        Convert.ToString(mainform.cells[79]),
                        t1, t2);
                        }
                        else { MessageBox.Show("Введено неверное значение в второе поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK); }
                    }
                }
                else
                {
                    if ((textBox1.Text == "") || (textBox1.Text == "0"))
                    {
                        MessageBox.Show("Введено неверное значение в первое поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                   if(comboBox1.SelectedIndex==2) {
                        Decimal t1, t2;
                        if ((textBox2.Text != "") || (textBox2.Text != "0"))
                        {
                            t2 = Convert.ToDecimal(textBox2.Text);
                            t1 = Convert.ToDecimal(textBox1.Text);
                            mainform.бАTableAdapter.FillSL(mainform.тестовая_бд_DataSet.БА,
                                Convert.ToString(mainform.cells[0]),
                        Convert.ToString(mainform.cells[1]),
                        Convert.ToString(mainform.cells[2]),
                        Convert.ToString(mainform.cells[3]),
                        Convert.ToString(mainform.cells[4]),
                        Convert.ToString(mainform.cells[5]),
                        Convert.ToString(mainform.cells[6]),
                        Convert.ToString(mainform.cells[7]),
                        Convert.ToString(mainform.cells[8]),
                        Convert.ToString(mainform.cells[9]),
                        Convert.ToString(mainform.cells[10]),
                        Convert.ToString(mainform.cells[11]),
                        Convert.ToString(mainform.cells[12]),
                        Convert.ToString(mainform.cells[13]),
                        Convert.ToString(mainform.cells[14]),
                        Convert.ToString(mainform.cells[15]),
                        Convert.ToString(mainform.cells[16]),
                        Convert.ToString(mainform.cells[17]),
                        Convert.ToString(mainform.cells[18]),
                        Convert.ToString(mainform.cells[19]),
                        Convert.ToString(mainform.cells[20]),
                        Convert.ToString(mainform.cells[21]),
                        Convert.ToString(mainform.cells[22]),
                        Convert.ToString(mainform.cells[23]),
                        Convert.ToString(mainform.cells[24]),
                        Convert.ToString(mainform.cells[25]),
                        Convert.ToString(mainform.cells[26]),
                        Convert.ToString(mainform.cells[27]),
                        Convert.ToString(mainform.cells[28]),
                        Convert.ToString(mainform.cells[29]),
                        Convert.ToString(mainform.cells[30]),
                        Convert.ToString(mainform.cells[31]),
                        Convert.ToString(mainform.cells[32]),
                        Convert.ToString(mainform.cells[33]),
                        Convert.ToString(mainform.cells[34]),
                        Convert.ToString(mainform.cells[35]),
                        Convert.ToString(mainform.cells[36]),
                        Convert.ToString(mainform.cells[37]),
                        Convert.ToString(mainform.cells[38]),
                        Convert.ToString(mainform.cells[39]),
                        Convert.ToString(mainform.cells[40]),
                        Convert.ToString(mainform.cells[41]),
                        Convert.ToString(mainform.cells[42]),
                        Convert.ToString(mainform.cells[43]),
                        Convert.ToString(mainform.cells[44]),
                        Convert.ToString(mainform.cells[45]),
                        Convert.ToString(mainform.cells[46]),
                        Convert.ToString(mainform.cells[47]),
                        Convert.ToString(mainform.cells[48]),
                        Convert.ToString(mainform.cells[49]),
                        Convert.ToString(mainform.cells[50]),
                        Convert.ToString(mainform.cells[51]),
                        Convert.ToString(mainform.cells[52]),
                        Convert.ToString(mainform.cells[53]),
                        Convert.ToString(mainform.cells[54]),
                        Convert.ToString(mainform.cells[55]),
                        Convert.ToString(mainform.cells[56]),
                        Convert.ToString(mainform.cells[57]),
                        Convert.ToString(mainform.cells[58]),
                        Convert.ToString(mainform.cells[59]),
                        Convert.ToString(mainform.cells[60]),
                        Convert.ToString(mainform.cells[61]),
                        Convert.ToString(mainform.cells[62]),
                        Convert.ToString(mainform.cells[63]),
                        Convert.ToString(mainform.cells[64]),
                        Convert.ToString(mainform.cells[65]),
                        Convert.ToString(mainform.cells[66]),
                        Convert.ToString(mainform.cells[67]),
                        Convert.ToString(mainform.cells[68]),
                        Convert.ToString(mainform.cells[69]),
                        Convert.ToString(mainform.cells[70]),
                        Convert.ToString(mainform.cells[71]),
                        Convert.ToString(mainform.cells[72]),
                        Convert.ToString(mainform.cells[73]),
                        Convert.ToString(mainform.cells[74]),
                        Convert.ToString(mainform.cells[75]),
                        Convert.ToString(mainform.cells[76]),
                        Convert.ToString(mainform.cells[77]),
                        Convert.ToString(mainform.cells[78]),
                        Convert.ToString(mainform.cells[79]),
                        t1, t2);
                        }
                        else { MessageBox.Show("Введено неверное значение в второе поле либо поле пусто ", "Ошибка", MessageBoxButtons.OK); }
                    }
                }
                mainform.menuStrip1.BackColor = Color.FromArgb(248, 243, 43);
            }
        }
        private void FiltBA_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filtr();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtr();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtr();
        }
    }
}
