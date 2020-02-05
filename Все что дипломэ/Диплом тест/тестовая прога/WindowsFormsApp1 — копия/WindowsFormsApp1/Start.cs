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
//using System.

namespace WindowsFormsApp1
{
    public partial class Vibor : Form
    {
        public string conn;
        public Hamsa subform;
        public Vibor mainform;
        public Vibor()
        {
                InitializeComponent();
        }
        public ArrayList indt = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            string f = "БДРЫБА.mdb"; //"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f);
            
            string ll = "";
            try
            {
                StreamReader sr = new StreamReader("Settings.dat", Encoding.Default);
                while ((ll = sr.ReadLine())!= null)
                {
                    if (ll == "Identificators")
                    {
                        listBox1.Items.Clear();
                        while ((ll= sr.ReadLine())!= "End indf")
                        {
                            string item = "" ;
                            bool str = false;
                            listBox1.Items.Add(ll);
                            for (int i = 0; i < ll.Length; i++)
                            {
                                if ((ll[i] == '*') && (str == false))
                                {
                                    str = true;     
                                } else if ((ll[i] == '*') && (str == true))
                                {
                                    str = false;
                                } else  if (str == true)
                                {
                                  item = item + ll[i];
                                }
                            }
                            indt.Add(item + "%");
                        }
                    }
                }
                sr.Close();      
                indt.Add("%");
            }
            catch
            {
                MessageBox.Show("Файл настроек не найден либо повреждён.Создайте новый либо восстановите путем копирования бекапа из папки \"bacup\". Будут загруженны стандартные настройки ! ", "Ошибка");
                listBox1.Items.Clear();
                indt.Add("A%");
                indt.Add("S%");
                indt.Add("T%");
                indt.Add("%");
                listBox1.Items.Add("Хамса\t\t*A*");
                listBox1.Items.Add("Шпроты\t\t*S*");
                listBox1.Items.Add("Ставрида\t\t*T*");
            }
            if(listBox1.Items.Count == 0)
            {
                listBox1.Items.Clear();
                MessageBox.Show("Файл настроек не найден либо повреждён.Создайте новый либо восстановите путем копирования бекапа из папки \"bacup\". Будут загруженны стандартные настройки ! ", "Ошибка");
                listBox1.Items.Add("Хамса\t\t*A*");
                listBox1.Items.Add("Шпроты\t\t*S*");
                listBox1.Items.Add("Ставрида\t\t*T*");
                indt.Add("A%");
                indt.Add("S%");
                indt.Add("T%");
                indt.Add("%");

            }
            //WindowsFormsApp1.Properties.Settings.Default.Соединение =
            try
            {
                StreamReader sk = new StreamReader("Db.dat", Encoding.Default);
                ll = sk.ReadLine();
                string table = ""; bool ld = false;
                for (int i = 0; i < ll.Length; i++)
                {
                    if (ll[i] == '^') { if (ld == false) ld = true; else ld = false; }
                    else
                    {
                        if (ld == true)
                        {
                            table += ll[i];
                        }
                    }
                }
                sk.Close();
                f = table;
               
            conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f;
            }
            catch
            {
                MessageBox.Show("Не удалось найти файл БД . Откройте новый файл ");
                openFileDialog1.Filter = "mbd files (*.mdb)|*.mdb|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + openFileDialog1.FileName;
                    f = openFileDialog1.FileName;
                    using (StreamWriter sw = new StreamWriter("Db.dat", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("FileBD  ^" + openFileDialog1.FileName + "^");
                        sw.Close();
                    }
                 
                }
            }
            if (System.IO.File.Exists(f)==false )
            {
                MessageBox.Show("Не удалось найти файл БД . Откройте новый файл ");
                openFileDialog1.Filter = "mbd files (*.mdb)|*.mdb|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + openFileDialog1.FileName;
                    f = openFileDialog1.FileName;
                    using (StreamWriter sw = new StreamWriter("Db.dat", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("FileBD  ^" + openFileDialog1.FileName + "^");
                        sw.Close();
                    }
                  
                }
            }
        }

        private void бАBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
        }

        private void уловыBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void уловыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) //Код открытия формы уловов 
        {
           
            Hamsa subForm = new Hamsa(this);
            subForm.Show();
            this.Visible = false;


        }

        private void Vibor_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void Vibor_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idnt = listBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e) //Кнопка отмены создания нового индентификатора
        {
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Enabled = true;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)  //Кнопка сохранения индентификатора 
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                if (oper == 1) // код добавления нового индентификатора 
                {
                    string ll = textBox1.Text + "\t\t" + "*" + textBox2.Text + "*";
                    indt.Add(textBox2.Text + "%");
                    listBox1.Items.Add(ll);
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Enabled = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    using (StreamWriter sw = new StreamWriter("Settings.dat", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Identificators");
                        for (int j = 0; j < listBox1.Items.Count; j++)
                        {
                            sw.WriteLine(listBox1.Items[j]);

                        }
                        sw.WriteLine("End indf");
                        sw.Close();
                    }

                // конец кода добавления индентификатора 
                } if (oper == 0) // Изменение существующего индентификатора 
                {
                    string kls="";
                    int col = 0;
                    for(int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if ((textBox1.Text[i]!=' ') || (textBox1.Text[i] != '\t')){
                            col++;
                            kls += textBox1.Text[i];
                        }else
                        {
                            break; 
                        }
                    }
                    textBox1.Text = kls;
                        if (col <= 7)
                            textBox1.Text += "\t\t";
                        else if(col <= 14)
                        {
                            textBox1.Text += "\t";
                        } else
                    {
                        for (int k = col; k <= 18; k++)
                        {
                            textBox1.Text += ' ';
                        }
                    }

                    string ll = textBox1.Text  + "*" + textBox2.Text + "*";
                    indt[listBox1.SelectedIndex] = (textBox2.Text + "%");
                    listBox1.Items[listBox1.SelectedIndex] = (ll);
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Enabled = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    using (StreamWriter sw = new StreamWriter("Settings.dat", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Identificators");
                        for (int j = 0; j < listBox1.Items.Count; j++)
                        {
                            sw.WriteLine(listBox1.Items[j]);

                        }
                        sw.WriteLine("End indf");
                        sw.Close();
                    }
                } //конец изменения индентификатора 
            }
            else
                MessageBox.Show("Одно из полей пустое либо не правильно указанно ","Ошибка",MessageBoxButtons.OK);
        }
        public int idnt;
        private void добавитьИндентификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Enabled = false;
            button3.Visible = true;
            button4.Visible = true;
            oper = 1;
        }
        public int oper;
        private void изменитьИндентификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean bl = false;
            string ll = Convert.ToString(listBox1.SelectedItem);
            string kl="",sl = "";
            for (int i = 0; i < ll.Length; i++)
            {
                if ((ll[i] != '*')&&(bl == false ))
                {
                    kl += ll[i];
                } else
                {
                    bl = true;
                }
                if ((bl== true )&&(ll[i]!= '*'))
                {
                    sl += ll[i];
                }
            }
            textBox1.Text = null;
            for (int i = 0;i< kl.Length; i++)
            {
                if ((kl[i]) != Convert.ToChar("\t"))
                {
                    textBox1.Text += kl[i];
                }
                else
                    break;
            }
            //textBox1.Text = kl;
            textBox2.Text = sl;
            oper = 0;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Enabled = false;
            button3.Visible = true;
            button4.Visible = true;

        }

        private void удалитьИндентификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (Convert.ToString(MessageBox.Show("Вы действительно хотите удалить индентификатор \n " + listBox1.SelectedItem, "Подтверждение", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation))== "Yes")
            {
                
                indt.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                using (StreamWriter sw = new StreamWriter("Settings.dat", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Identificators");
                    for (int j = 0; j < listBox1.Items.Count; j++)
                    {
                        sw.WriteLine(listBox1.Items[j]);

                    }
                    sw.WriteLine("End indf");
                    sw.Close();
                }
                listBox1.SelectedIndex = indt.Count - 1;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            idnt = indt.Count - 1;
            Hamsa subForm = new Hamsa(this);
            subForm.Show();
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ErrAnal sub = new ErrAnal(this);
            sub.Show();
            this.Hide();
        }
    }
}
