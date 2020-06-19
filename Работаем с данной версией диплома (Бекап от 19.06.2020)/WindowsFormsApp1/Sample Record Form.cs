                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           using System;
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
    public partial class Sample_Record_Form : Form
    {
        //----------------------------------------------Область переменных ------------------------------------------------------//
        public ArrayList zapis = new ArrayList();
        public ArrayList orig = new ArrayList();
        String data;
        String dd, mm, gg;
        public string operation;
        idntf ogr = new idntf();
        string file = "IDNTFParams.dat";
        ArrayList pars;
        //-------------------------------------------конец Области переменных ---------------------------------------------------//
        private Proby mainform;
        public Sample_Record_Form(Proby mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // if (Convert.ToString(MessageBox.Show("Вы действительно хотите начать анализ ошибок? При обработке ошибок работа с основной программой будет заблокирована", "Предуприждение !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == "Yes")
        bool err = false;
        string errs = "";
        private void записатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = false;
            errs = "";
            if (comboBox1.Text != "")
            {
                if (Convert.ToDouble(comboBox1.Text) > Convert.ToDouble(comboBox2.Text)) { errs += "Минимальный размер не может привышать максимальный ! " + Convert.ToChar(13); err = true; } // проверка размеров рыбы (Я)
                
                if ((Convert.ToDouble(comboBox1.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(comboBox1.Text) < Convert.ToDouble(pars[2])))) 
                {
                    err = true;
                    errs += "Поле 'Минимальная длина' не соответствует ограничениям (макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + ")" + Convert.ToChar(13);
                }
            }
            if (comboBox2.Text != "")
                if ((Convert.ToDouble(comboBox2.Text) > Convert.ToDouble(pars[1])) || ((Convert.ToDouble(comboBox2.Text) < Convert.ToDouble(pars[2]))))
            {
                err = true;
                errs += "Поле 'Максимальная длина' не соответствует ограничениям (макс значение - " + Convert.ToString(pars[1]) + ", мин значение - " + Convert.ToString(pars[2]) + ")" + Convert.ToChar(13);
            }
            /* if (textBox11.Text != "")
                 if ((Convert.ToDouble(textBox11.Text) > Convert.ToDouble(pars[13])) || ((Convert.ToDouble(textBox11.Text) < Convert.ToDouble(pars[14]))))
             {
                 err = true;
                 errs += "Поле 'Содержание СВ' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[13]) + ", мин значение - " + Convert.ToString(pars[14]) + Convert.ToChar(13);
             }
             if (textBox10.Text != "")
                 if ((Convert.ToDouble(textBox10.Text) > Convert.ToDouble(pars[15])) || ((Convert.ToDouble(textBox10.Text) < Convert.ToDouble(pars[16]))))
             {
                 err = true;
                 errs += "Поле 'Содержание липидов' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[15]) + ", мин значение - " + Convert.ToString(pars[16]) + Convert.ToChar(13);
             }
             if (textBox12.Text != "")
                 if ((Convert.ToDouble(textBox12.Text) > Convert.ToDouble(pars[15])) || ((Convert.ToDouble(textBox12.Text) < Convert.ToDouble(pars[16]))))
             {
                 err = true;
                 errs += "Поле 'Расчетное содержание липидов' не соответствует ограничениям(макс значение - " + Convert.ToString(pars[15]) + ", мин значение - " + Convert.ToString(pars[16]) + Convert.ToChar(13);
             }*/
            if (textBox15.Text != "" && textBox14.Text != "")
            {
                if (Convert.ToDouble(textBox16.Text) >= Convert.ToDouble(textBox15.Text)) { errs += "Вес бюкса с сухой навеской не может быть больше веса бюкса с сырой навеской ! " + Convert.ToChar(13); err = true; }
            }
            if (textBox15.Text != "" && textBox14.Text != "" && textBox16.Text != "")
            {
                if ((Convert.ToDouble(textBox14.Text) >= Convert.ToDouble(textBox15.Text)) || (Convert.ToDouble(textBox14.Text) >= Convert.ToDouble(textBox16.Text))) { errs += "Вес пустого бюкса не может быть больше веса бюкса с сырой навеской или Бюкса с сухой навеской ! " + Convert.ToChar(13); err = true; }
            }
            if (textBox14.Text != "")
            {
                // проверка веса бюкса (Я)
               

                if ((Convert.ToDouble(textBox14.Text) > Convert.ToDouble(pars[7])) || ((Convert.ToDouble(textBox14.Text) < Convert.ToDouble(pars[8]))))
                {
                    err = true;
                    errs += "Поле 'Вес бюкса' не соответствует ограничениям (макс значение - " + Convert.ToString(pars[7]) + ", мин значение - " + Convert.ToString(pars[8]) + ")" + Convert.ToChar(13);
                }
            }
            if (textBox15.Text != "" && textBox14.Text != "")
                if (((Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox14.Text)) > Convert.ToDouble(pars[9])) || ((Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox14.Text)) < Convert.ToDouble(pars[10])))
            {
                err = true;
                errs += "Поле 'Сырая масса бюкса с навеской' не соответствует ограничениям (макс значение - " + Convert.ToString(Convert.ToDouble(pars[9])+ Convert.ToDouble(textBox14.Text)) + ", мин значение - " + Convert.ToString(Convert.ToDouble(pars[10])+ Convert.ToDouble(textBox14.Text)) + ")" + Convert.ToChar(13);
            }
            if (textBox16.Text != "" && textBox14.Text!="")
                if (((Convert.ToDouble(textBox16.Text) - Convert.ToDouble(textBox14.Text)) > Convert.ToDouble(pars[11])) || ((Convert.ToDouble(textBox16.Text) - (Convert.ToDouble(textBox14.Text)) < Convert.ToDouble(pars[12]))))
            {
                err = true;
                errs += "Поле 'Сухая масса бюкса с навеской' не соответствует ограничениям (макс значение - " + Convert.ToString(Convert.ToDouble(pars[11])+ Convert.ToDouble(textBox14.Text)) + ", мин значение - " + Convert.ToString(Convert.ToDouble(pars[12])+ Convert.ToDouble(textBox14.Text)) + ")" + Convert.ToChar(13);
            }
            if (err)
            {
                if (Convert.ToString(MessageBox.Show("Одно или несколько полей не соответствует ограничениям, проигнорировать ограничения? "+errs, "Предуприждение !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == "Yes") 
                         err = false;
            }
            if (!err)
            {
                zapis[0] = textBox1.Text;//ид пробы
                zapis[1] = textBox2.Text;// ид записи
                zapis[2] = textBox5.Text;//порядковый номер
                zapis[3] = textBox9.Text;//средняя длина 
                zapis[4] = comboBox1.Text;//минимальный размер
                zapis[5] = comboBox2.Text;//максимальный размер
                zapis[6] = textBox7.Text;//количество рыб
                zapis[7] = textBox6.Text;//масса рыбы
                zapis[8] = textBox8.Text;//средняя масса рыбы
                zapis[9] = textBox13.Text;//номер бюкса
                zapis[10] = textBox14.Text;//вес бюкса
                zapis[11] = textBox15.Text;//сырая масса бюкса с навеской
                zapis[12] = textBox17.Text;//масса навески
                zapis[13] = textBox16.Text;//сухая масса бюкса с навеской 
                zapis[14] = textBox18.Text;//масса сухой навески
                zapis[15] = textBox11.Text;//содержание СВ
                zapis[16] = textBox10.Text;//содержание липидов
                zapis[17] = textBox12.Text;//содержание липидов расчетное
                zapis[18] = richTextBox1.Text;//комментарий  
                if (operation == "Redact") mainform.upd(zapis, orig,this);
                if (operation == "New") mainform.ins(zapis,this);
            }
            /*
             idntparams.Add(idnt);
            idntparams.Add(SizeMax);
            idntparams.Add(SizeMin);
            idntparams.Add(MaxTLFLSL);
            idntparams.Add(MinTLFLSL);
            idntparams.Add(MaxWetWeight);
            idntparams.Add(MinWetWeight);
            idntparams.Add(MaxBoxWeight);
            idntparams.Add(MinBoxWeight);
            idntparams.Add(MaxGrosWW);
            idntparams.Add(MinGrosWW);
            idntparams.Add(MaxGrosDW);
            idntparams.Add(MinGrosDW);
            idntparams.Add(MaxDW);
            idntparams.Add(MinDW);
            idntparams.Add(MaxTL);
            idntparams.Add(MinTL);
            idntparams.Add(x1);
            idntparams.Add(x2);             
             */
        }

        private void выполнитьРасчетПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text != "" && textBox7.Text != "")
                    textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) / Convert.ToDouble(textBox7.Text));
                if (textBox16.Text != "" && textBox14.Text != "")
                    textBox18.Text = Convert.ToString(Convert.ToDouble(textBox16.Text) - Convert.ToDouble(textBox14.Text));
                if (textBox15.Text != "" && textBox14.Text != "")
                    textBox17.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox14.Text));
                if (comboBox1.Text != "" && comboBox2.Text != "")
                    textBox9.Text = Convert.ToString((Convert.ToDouble(comboBox1.Text) + Convert.ToDouble(comboBox2.Text)) / 2);

                if (textBox18.Text != "" && textBox17.Text != "")
                    textBox11.Text = Convert.ToString(Convert.ToDouble(textBox18.Text) * 100 / Convert.ToDouble(textBox17.Text));//вфвфвфв

                if (textBox11.Text != "")
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * Convert.ToDouble(pars[17]) + Convert.ToDouble(pars[18]));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При расчете возникла ошибка, проверьте все поля.   Причина ошибки: " + ex.Message, "Ошибка расчета", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void вводДополнительныхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox8.Visible == false) { groupBox8.Visible = true; }
            else { groupBox8.Visible = false; }
        }
        string idnt ;
        private void Sample_Record_Form_Load(object sender, EventArgs e)
        { if (mainform.readOnl)
            {
                записатьToolStripMenuItem.Enabled = false;
            }
            textBox1.Text = Convert.ToString(zapis[0]); //ид пробы
            textBox2.Text = Convert.ToString(zapis[1]);// ид записи
            textBox5.Text = Convert.ToString(zapis[2]);//порядковый номер
            textBox9.Text = Convert.ToString(zapis[3]); //средняя длина 
            comboBox1.Text = Convert.ToString(zapis[4]); //минимальный размер
            comboBox2.Text = Convert.ToString(zapis[5]); //максимальный размер
            textBox7.Text = Convert.ToString(zapis[6]); //количество рыб
            textBox6.Text = Convert.ToString(zapis[7]); //масса рыбы
            textBox8.Text = Convert.ToString(zapis[8]); //средняя масса рыбы
            textBox13.Text = Convert.ToString(zapis[9]); //номер бюкса
            textBox14.Text = Convert.ToString(zapis[10]); //вес бюкса
            textBox15.Text = Convert.ToString(zapis[11]); //сырая масса бюкса с навеской
            textBox17.Text = Convert.ToString(zapis[12]); //масса навески
            textBox16.Text = Convert.ToString(zapis[13]); //сухая масса бюкса с навеской 
            textBox18.Text = Convert.ToString(zapis[14]);  //масса сухой навески
            textBox11.Text = Convert.ToString(zapis[15]); //содержание СВ
            textBox10.Text = Convert.ToString(zapis[16]); //содержание липидов
            textBox12.Text = Convert.ToString(zapis[17]); //содержание липидов расчетное
            richTextBox1.Text = Convert.ToString(zapis[18]); //комментарий 
            idnt =  mainform.idnt;
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
            } catch (Exception ex)
            {
                MessageBox.Show("При открытии формы произошла ошибка загруски установленых ограничений, ограничения не будут учитыватся дальше. Код ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             