using System;
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
    public partial class Sample_Record_Form : Form
    {
        //----------------------------------------------Область переменных ------------------------------------------------------//
        public ArrayList zapis = new ArrayList();
        public ArrayList orig = new ArrayList();
        String data;
        String dd, mm, gg;
        public string operation;
        string file = "IDNTFParams.dat";
        idntf ogr = new idntf();
        string idnt = mainfor.idnt;
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

        private void записатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapis[0] = textBox1.Text;
            zapis[1] = textBox2.Text;
            zapis[2] = textBox5.Text;
            zapis[3] = textBox9.Text;
            zapis[4] = textBox3.Text;
            zapis[5] = textBox4.Text;
            zapis[6] = textBox7.Text;
            zapis[7] = textBox6.Text;
            zapis[8] = textBox8.Text;
            zapis[9] = textBox13.Text;
            zapis[10] = textBox14.Text;
            zapis[11] = textBox15.Text;
            zapis[12] = textBox17.Text;
            zapis[13] = textBox16.Text;
            zapis[14] = textBox18.Text;
            zapis[15] = textBox11.Text;
            zapis[16] = textBox10.Text;
            zapis[17] = textBox12.Text;
            zapis[18] = richTextBox1.Text;
            if (operation == "Redact") mainform.upd(zapis, orig);
            if (operation == "New") mainform.ins(zapis);
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
                if (textBox3.Text != "" && textBox4.Text != "")
                    textBox9.Text = Convert.ToString((Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text)) / 2);
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

        private void Sample_Record_Form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(zapis[0]); //ид пробы
            textBox2.Text = Convert.ToString(zapis[1]);// ид записи
            textBox5.Text = Convert.ToString(zapis[2]);//порядковый номер
            textBox9.Text = Convert.ToString(zapis[3]); //средняя длина 
            textBox3.Text = Convert.ToString(zapis[4]); //минимальный размер
            textBox4.Text = Convert.ToString(zapis[5]); //максимальный размер
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
            using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
            {
                string line; string str;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < indt.Count; i++)
                    {
                        if (line == Convert.ToString(indt[i]))
                        {
                            mas[i] = new idntf(line, Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()),
                             Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()), Convert.ToDouble(sr.ReadLine()));
                            count++;
                            break;
                        }
                        else
                        {
                            //ram = new idntf();
                            //mas[i] = new idntf();
                        }
                    }
                }
            }
        }
    }
    public class idntf
    {
        private string idnt;
        private Double SizeMax, SizeMin, MaxTLFLSL, MinTLFLSL, MaxWetWeight, MinWetWeight, MaxBoxWeight, MinBoxWeight,
            MaxGrosWW, MinGrosWW, MaxGrosDW, MinGrosDW, MaxDW, MinDW, MaxTL, MinTL, x1, x2;

        public idntf()
        {
            idnt = "N/A";
        }
        public idntf(string idnt, double SizeMax, double SizeMin, double MaxTLFLSL, double MinTLFLSL, double MaxWetWeight, double MinWetWeight,
          double MaxBoxWeight, double MinBoxWeight, double MaxGrosWW, double MinGrosWW, double MaxGrosDW, double MinGrosDW, double MaxDW,
          double MinDW, double MaxTL, double MinTL, double x1, double x2)
        {
            this.idnt = idnt;
            this.SizeMax = SizeMax;
            this.SizeMin = SizeMin;
            this.MaxTLFLSL = MaxTLFLSL;
            this.MinTLFLSL = MinTLFLSL;
            this.MaxWetWeight = MaxWetWeight;
            this.MinWetWeight = MinWetWeight;
            this.MaxBoxWeight = MaxBoxWeight;
            this.MinBoxWeight = MinBoxWeight;
            this.MaxGrosWW = MaxGrosWW;
            this.MinGrosWW = MinGrosWW;
            this.MaxGrosDW = MaxGrosDW;
            this.MinGrosDW = MinGrosDW;
            this.MaxDW = MaxDW;
            this.MinDW = MinDW;
            this.MaxTL = MaxTL;
            this.MinTL = MinTL;
            this.x1 = x1;
            this.x2 = x2;
        }
        private ArrayList idntparams = new ArrayList();
        public ArrayList GetIdnt()
        {
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
            return idntparams;
        }
        public string IDent()
        {
            return idnt;
        }

        //класс надо переписать, добавить все переменные и пусть он возвращает их (https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/class)
    }
}
