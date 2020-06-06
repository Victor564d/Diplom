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
    public partial class SettingsIDNTF : Form
    {
        ArrayList parms = new ArrayList();
        Vibor mainform;
        idntf[] mas = new idntf[200];
        idntf ram = new idntf();
        public ArrayList indt = new ArrayList();
        string file = "IDNTFParams.dat";



        public SettingsIDNTF(Vibor mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        int count = 0; bool nuls = false;
        private void SettingsIDNTF_Load(object sender, EventArgs e)
        {
            indt = mainform.indt; 
            listBox1.Items.Clear();
            listBox1.Items.AddRange(mainform.listBox1.Items);
            if (System.IO.File.Exists(file) == false)
            {
                MessageBox.Show("Файл конфигурации ограничений показателей не найден,будет создан пустой файл. Пожалуйста , задайте новые настройки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("ПУсто ");
                    sw.Close();
                    button2.Enabled = false;
                }   
            }
             else
            {
                using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                {
                    string line; string str;
                    while((line = sr.ReadLine())!= null)
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
                            }  else
                            {
                                //ram = new idntf();
                               //mas[i] = new idntf();
                            }
                        }
                    }
                }
                //  ram = mas[1];
                //MessageBox.Show(ram.IDent());
               // MessageBox.Show(Convert.ToString(count));
                //parms = mas[0].GetIdnt();
                //MessageBox.Show(Convert.ToString(parms[0]));
                try
                {
                    for (int i = 0; i <= count; i++)
                    {
                        if ((mas[i].IDent() != "") || (mas[i].IDent() != null) || ((mas[i].IDent() != "N/A")))
                        {
                            break;
                        }
                        if (((mas[i].IDent() == "") || (mas[i].IDent() == null) || (mas[i].IDent() != "N/A")) && i == count)
                        {
                            nuls = true;
                        }
                    }
                } catch { }
                    
            }
            if (nuls) 
            {
                MessageBox.Show("Файл конфигурации ограничений показателей пуст. Пожалуйста , задайте новые настройки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ( !nuls)
            {
                for (int i = 0;i< mainform.listBox1.Items.Count; i++)
                {
                    try
                    {
                        string tests = mas[i].IDent();
                    }
                    catch
                    {
                        mas[i] = new idntf();
                    }
                }
                try
                {
                    listBox1.SelectedIndex = 0;     
                }
                catch { }     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            try
            {
                ram = mas[listBox1.SelectedIndex];
                mas[listBox1.SelectedIndex] = new idntf(Convert.ToString(indt[listBox1.SelectedIndex]),
                        Convert.ToDouble(textBox1.Text),
                        Convert.ToDouble(textBox2.Text),
                        Convert.ToDouble(textBox1.Text),
                        Convert.ToDouble(textBox2.Text),
                        Convert.ToDouble(textBox5.Text),
                        Convert.ToDouble(textBox6.Text),
                        Convert.ToDouble(35),  //Вес бюкса макс   textBox5.Text
                        Convert.ToDouble(17), //Вес бюкса  мин   textBox6.Text
                        Convert.ToDouble(textBox5.Text),
                        Convert.ToDouble(textBox6.Text),
                        Convert.ToDouble(textBox5.Text),
                        Convert.ToDouble(textBox6.Text),
                        Convert.ToDouble(textBox13.Text),
                        Convert.ToDouble(textBox14.Text),
                        Convert.ToDouble(textBox15.Text),
                        Convert.ToDouble(textBox16.Text),
                        Convert.ToDouble(textBox17.Text),
                        Convert.ToDouble(textBox18.Text)
                        );
                File.Delete(file);
                using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("@");
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        parms = mas[i].GetIdnt();
                        for (int j = 0; j < parms.Count; j++)
                        {
                            sw.WriteLine(Convert.ToString(parms[j]));
                        }
                        sw.WriteLine("@");
                    }
                    sw.Close();
                }
            } catch (System.Exception ex)
            {
                MessageBox.Show("Возникла ошибка при записи. Код ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mas[listBox1.SelectedIndex] = ram;
            parms = mas[listBox1.SelectedIndex].GetIdnt();
            textBox1.Text = parms[1].ToString();
            textBox2.Text = parms[2].ToString();
            //textBox3.Text = parms[3].ToString();
            //textBox4.Text = parms[4].ToString();
            textBox5.Text = parms[5].ToString();
            textBox6.Text = parms[6].ToString();
            //textBox7.Text = parms[7].ToString();
            //textBox8.Text = parms[8].ToString();
            //textBox9.Text = parms[9].ToString();
            //textBox10.Text = parms[10].ToString();
            //textBox11.Text = parms[11].ToString();
            //textBox12.Text = parms[12].ToString();
            textBox13.Text = parms[13].ToString();
            textBox14.Text = parms[14].ToString();
            textBox15.Text = parms[15].ToString();
            textBox16.Text = parms[16].ToString();
            textBox17.Text = parms[17].ToString();
            textBox18.Text = parms[18].ToString();
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("@");
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    parms = mas[i].GetIdnt();
                    for (int j = 0; j < parms.Count; j++)
                    {
                        sw.WriteLine(Convert.ToString(parms[j]));
                    }
                    sw.WriteLine("@");
                }
                sw.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void SettingsIDNTF_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //тут код смены --------------------------------------------------------
            try
            {
                parms = mas[listBox1.SelectedIndex].GetIdnt();
                textBox1.Text = parms[1].ToString();
                textBox2.Text = parms[2].ToString();
                textBox1.Text = parms[3].ToString();
                textBox2.Text = parms[4].ToString();
                textBox5.Text = parms[5].ToString();
                textBox6.Text = parms[6].ToString();
                textBox5.Text = parms[7].ToString();
                textBox6.Text = parms[8].ToString();
                textBox5.Text = parms[9].ToString();
                textBox6.Text = parms[10].ToString();
                textBox5.Text = parms[11].ToString();
                textBox6.Text = parms[12].ToString();

                textBox13.Text = parms[13].ToString();
                textBox14.Text = parms[14].ToString();
                textBox15.Text = parms[15].ToString();
                textBox16.Text = parms[16].ToString();
                textBox17.Text = parms[17].ToString();
                textBox18.Text = parms[18].ToString();
            }
            catch { }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

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
        public idntf(string idnt,double SizeMax, double SizeMin, double MaxTLFLSL, double MinTLFLSL, double MaxWetWeight, double MinWetWeight,
          double MaxBoxWeight, double MinBoxWeight, double MaxGrosWW, double MinGrosWW, double MaxGrosDW, double MinGrosDW, double MaxDW,
          double MinDW, double MaxTL, double MinTL, double x1, double x2 )
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

