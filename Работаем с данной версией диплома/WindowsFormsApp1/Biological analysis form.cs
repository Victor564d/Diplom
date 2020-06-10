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
using System.IO;


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
        BA mainform;
        string idnt;
        idntf ogr; ArrayList pars = new ArrayList();
        string file = "IDNTFParams.dat";
        //-------------------------------------------конец Области переменных ---------------------------------------------------//

        public Biological_analysis_form(BA mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           


        }
        bool err = false;
        string errs = "";
        private void записатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = false;
            errs = "";
            if (textBox13.Text != "")
                if ((Convert.ToDouble(textBox13.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(textBox13.Text) < Convert.ToDouble(pars[2]))))
                {
                    err = true;
                    errs += "Поле 'Минимальная длина' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + Convert.ToChar(13);
                }
            if (textBox12.Text != "")
                if ((Convert.ToDouble(textBox12.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(textBox12.Text) < Convert.ToDouble(pars[2]))))
                {
                    err = true;
                    errs += "Поле 'Максимальная длина' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + Convert.ToChar(13);
                }
            if  (textBox7.Text != "")
                if ((Convert.ToDouble(textBox7.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(textBox7.Text) < Convert.ToDouble(pars[2]))))
            {
                err = true;
                errs += "Поле 'Общая длина' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + Convert.ToChar(13);
            }
            if (textBox4.Text != "")
                if ((Convert.ToDouble(textBox4.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(textBox4.Text) < Convert.ToDouble(pars[2]))))
                {
                    err = true;
                    errs += "Поле 'Длина до развилки' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + Convert.ToChar(13);
                }
            if (textBox17.Text != "")
                if ((Convert.ToDouble(textBox17.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(textBox17.Text) < Convert.ToDouble(pars[2]))))
                {
                    err = true;
                    errs += "Поле 'Стандартная длина' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + Convert.ToChar(13);
                }
            if (textBox22.Text != "")
                if ((Convert.ToDouble(textBox22.Text) > Convert.ToDouble(pars[7])) || ((Convert.ToDouble(textBox22.Text) < Convert.ToDouble(pars[8]))))
                {
                    err = true;
                    errs += "Поле 'Вес бюкса' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[7]) + ", мин значение - " + Convert.ToString(pars[8]) + Convert.ToChar(13);
                }
            if (textBox21.Text != "")
                if ((Convert.ToDouble(textBox21.Text) > Convert.ToDouble(pars[5])) || ((Convert.ToDouble(textBox21.Text) < Convert.ToDouble(pars[6]))))
                {
                    err = true;
                    errs += "Поле 'Сырая масса бюкса с навеской' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[5]) + ", мин значение - " + Convert.ToString(pars[6]) + Convert.ToChar(13);
                }
            if (textBox20.Text != "")
                if ((Convert.ToDouble(textBox20.Text) > Convert.ToDouble(pars[5])) || ((Convert.ToDouble(textBox20.Text) < Convert.ToDouble(pars[6]))))
                {
                    err = true;
                    errs += "Поле 'Сухая масса бюкса с навеской' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[5]) + ", мин значение - " + Convert.ToString(pars[6]) + Convert.ToChar(13);
                }
            



            if (err)
            {
                if (Convert.ToString(MessageBox.Show("Одно или несколько полей не соответствует ограничениям, проигнорировать ограничения? " + errs, "Предуприждение !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == "Yes")
                    err = false;
            }
            if (!err)
            {
                zapis[0] = textBox1.Text; //ид пробы	
                zapis[1] = textBox2.Text;//ид записи	
                zapis[2] = textBox5.Text;//порядковый номер	
                zapis[3] = textBox13.Text;//размер1	
                zapis[4] = textBox12.Text;//размер2	
                zapis[5] = textBox7.Text;//Общая длина	
                zapis[6] = textBox4.Text;//Длина до развилки	
                zapis[7] = textBox17.Text;//Стандартная длина	
                zapis[8] = textBox6.Text;//Вес	
                zapis[9] = comboBox1.Text;//пол	
                zapis[10] = textBox8.Text;//стадия зрелости	
                zapis[11] = textBox9.Text;//Ожирение	
                zapis[12] = textBox24.Text;//К упитонности	
                zapis[13] = textBox10.Text;//Возраст	
                zapis[14] = textBox11.Text;//Возраст,лет	
                zapis[15] = textBox3.Text; //Поколение	
                zapis[16] = textBox23.Text;//номер бюкса	
                zapis[17] = textBox22.Text;//Вес бюкса	
                zapis[18] = textBox21.Text;//вес бюкса с сырой навеской	
                zapis[19] = textBox19.Text;// вес навески	
                zapis[20] = textBox20.Text;//Вес бюкса с сухой навеской 	
                zapis[21] = textBox18.Text;//вес сухой навески	
                zapis[22] = textBox15.Text;//содержание св	
                zapis[23] = textBox16.Text;//содержание сл	
                zapis[24] = textBox14.Text;//расчетное сл	
                zapis[25] = richTextBox1.Text;//комментарий 	

                if (operation == "Redact") mainform.upd(zapis, orig);
                if (operation == "New") mainform.ins(zapis);
                this.Close();
            }
        }

        private void Biological_analysis_form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(zapis[0]); //ид пробы
            textBox2.Text = Convert.ToString(zapis[1]);//ид записи
            textBox5.Text = Convert.ToString(zapis[2]);//порядковый номер
            textBox13.Text = Convert.ToString(zapis[3]);//размер1
            textBox12.Text = Convert.ToString(zapis[4]);//размер2
            textBox7.Text = Convert.ToString(zapis[5]);//Общая длина
            textBox4.Text = Convert.ToString(zapis[6]);//Длина до развилки
            textBox17.Text = Convert.ToString(zapis[7]);//Стандартная длина
            textBox6.Text = Convert.ToString(zapis[8]);//Вес
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == Convert.ToString(zapis[9]))
                {
                    comboBox1.SelectedIndex = i;//пол
                    break;
                }
            }
            textBox8.Text = Convert.ToString(zapis[10]);//стадия зрелости
            textBox9.Text = Convert.ToString(zapis[11]);//Ожирение
            textBox24.Text = Convert.ToString(zapis[12]);//К упитонности
            textBox10.Text = Convert.ToString(zapis[13]);//Возраст
            textBox11.Text = Convert.ToString(zapis[14]);//Возраст,лет
            textBox3.Text = Convert.ToString(zapis[15]); //Поколение
            textBox23.Text = Convert.ToString(zapis[16]);//номер бюкса
            textBox22.Text = Convert.ToString(zapis[17]);//Вес бюкса
            textBox21.Text = Convert.ToString(zapis[18]);//вес бюкса с сырой навеской
            textBox19.Text = Convert.ToString(zapis[19]);// вес навески
            textBox20.Text = Convert.ToString(zapis[20]);//Вес бюкса с сухой навеской 
            textBox18.Text = Convert.ToString(zapis[21]);//вес сухой навески
            textBox15.Text = Convert.ToString(zapis[22]);//содержание св
            textBox16.Text = Convert.ToString(zapis[23]);//содержание сл
            textBox14.Text = Convert.ToString(zapis[24]);//расчетное сл
            richTextBox1.Text = Convert.ToString(zapis[25]);//комментарий 
            idnt = mainform.idnt;
            try
            {
                using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                {
                    string line; string str;
                    while ((line = sr.ReadLine()) != null)
                    {

                        if (line == Convert.ToString(idnt))
                        {
                            ogr = new idntf(line, Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()));
                            break;
                        }
                        else
                        {
                            //ram = new idntf();
                            //mas[i] = new idntf();
                        }

                    }
                }
                pars = ogr.GetIdnt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При открытии формы произошла ошибка загруски установленых ограничений, ограничения не будут учитыватся дальше. Код ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void выполнитьРасчетПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBox21.Text != "" && textBox22.Text != "")
                    textBox19.Text = Convert.ToString(Convert.ToDouble(textBox21.Text) - Convert.ToDouble(textBox22.Text));
                if (textBox20.Text != "" && textBox22.Text != "")
                    textBox18.Text = Convert.ToString(Convert.ToDouble(textBox20.Text) - Convert.ToDouble(textBox22.Text));

                if (textBox6.Text != "" && textBox7.Text != "")
                    textBox24.Text = Convert.ToString(100*Convert.ToDouble(textBox6.Text)  / Math.Pow((Convert.ToDouble(textBox7.Text)/10),3));//вфвфвфв

                if (textBox18.Text != "" && textBox19.Text != "")
                    textBox15.Text = Convert.ToString(Convert.ToDouble(textBox18.Text)*100 / Convert.ToDouble(textBox19.Text));//вфвфвфв

                if (textBox15.Text != "")
                    textBox14.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * Convert.ToDouble(pars[17]) + Convert.ToDouble(pars[18]));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При расчете возникла ошибка, проверьте все поля.   Причина ошибки: " + ex.Message, "Ошибка расчета", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
