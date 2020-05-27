using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;
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
        private void Form1_Load(object sender, EventArgs e) // выполняется при загрузке формы 
        {
            string f = "БДРЫБА.mdb"; //"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f);

            string ll = "";
            try // начало попытки считывания файла , в котором хранятся настройки индентификаторов.
            {
                StreamReader sr = new StreamReader("Settings.dat", Encoding.Default); //Считыватель
                while ((ll = sr.ReadLine()) != null) // пока есть линии - считываем 
                {
                    if (ll == "Identificators") // Если мы нашли ключевое слово 
                    {
                        listBox1.Items.Clear(); // Чистим список идентификаторов
                        while ((ll = sr.ReadLine()) != "End indf") //пока не будет найдено следующее ключевое слово
                        {
                            string item = ""; // временная переменная 
                            bool str = false; //
                            listBox1.Items.Add(ll);
                            for (int i = 0; i < ll.Length; i++)
                            {
                                if ((ll[i] == '*') && (str == false)) //если находим звездочку, а до этого ее не находили
                                {
                                    str = true;
                                }
                                else if ((ll[i] == '*') && (str == true)) //если нашли звездочку, при этом до этого тоже она была
                                {
                                    str = false;
                                }
                                else if (str == true) //Побуквенное считывание 
                                {
                                    item = item + ll[i];
                                }
                            }
                            indt.Add(item + "%"); //Записываем индентификатор в массив идентификаторов
                        }
                    }
                }
                sr.Close();  //закрываем файл    
                indt.Add("%"); // пустое значение 
            }
            catch // если не вышло считать файл
            {
                MessageBox.Show("Файл настроек не найден либо повреждён.Создайте новый либо восстановите путем копирования бекапа из папки \"bacup\". Будут загруженны стандартные настройки ! ", "Ошибка");
                listBox1.Items.Clear(); //выдали сообщение об ошибке , очистили список выводимый на экран 
                indt.Add("A%"); //записываем в массив идентификаторов стандарные значения
                indt.Add("S%");
                indt.Add("T%");
                indt.Add("%");
                listBox1.Items.Add("Хамса\t\t*A*"); // выводим в лист бокс список текущих идентификаторов
                listBox1.Items.Add("Шпроты\t\t*S*");
                listBox1.Items.Add("Ставрида\t\t*T*");
            }
            if (listBox1.Items.Count == 0) //если все считалось , но идентификаторы все же не загрузились 
            {
                listBox1.Items.Clear();
                MessageBox.Show("Файл настроек не найден либо повреждён.Создайте новый либо восстановите путем копирования бекапа из папки \"bacup\". Будут загруженны стандартные настройки ! ", "Ошибка");
                listBox1.Items.Add("Хамса\t\t*A*"); //выдали сообщение об ошибке , очистили список выводимый на экран 
                listBox1.Items.Add("Шпроты\t\t*S*");
                listBox1.Items.Add("Ставрида\t\t*T*");
                indt.Add("A%");//записываем в массив идентификаторов стандарные значения
                indt.Add("S%");
                indt.Add("T%");
                indt.Add("%");

            }
            //WindowsFormsApp1.Properties.Settings.Default.Соединение =
            StreamReader sk;
            try {  } catch { }   // инициализация считывателя
            try // попытка считывания файла хранещего ссылку на БД 
            {
                sk = new StreamReader("Db.dat", Encoding.Default);
                ll = sk.ReadLine(); //считываем линию
                string table = ""; bool ld = false; //временные переменные
                for (int i = 0; i < ll.Length; i++) // цыкл побуквенного считывания 
                {
                    if (ll[i] == '^')  // если нашли кавычку , переключаем значение переменной ld
                    {
                        if (ld == false) ld = true; else ld = false;
                    }
                    else
                    {
                        if (ld == true) // пока ld истино - считываем побуквенно 
                        {
                            table += ll[i];
                        }
                    }
                }
                sk.Close(); // закрываем файл
                f = table; // получили переменную подключения

                conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f; // создаем строку подключения
            }
            catch // если не удалось считать файл настройки, 
            {
               
                MessageBox.Show("Не удалось найти файл БД . Откройте новый файл "); //выдаем сообщение об ошибке
                openFileDialog1.Filter = "mbd files (*.mdb)|*.mdb|All files (*.*)|*.*"; // вызываем окно выбора файла  
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // если результат вернулся успешно 
                {
                    conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + openFileDialog1.FileName; // формируем строку подключения
                    f = openFileDialog1.FileName; // запоминаем ссылку на файл
                    using (StreamWriter sw = new StreamWriter("Db.dat", false, System.Text.Encoding.Default)) // создаем новый файл конфигурации БД
                    {
                        sw.WriteLine("FileBD  ^" + openFileDialog1.FileName + "^"); // записываем в новый файл переменную ссылки на бд
                        sw.Close();
                    }

                }
            }
            if (System.IO.File.Exists(f) == false) // если же файл не доступен (файл не найден)
            {
                MessageBox.Show("Не удалось найти файл БД . Откройте новый файл "); // выдаем сообщение об ошибке 
                openFileDialog1.Filter = "mbd files (*.mdb)|*.mdb|All files (*.*)|*.*"; // вызываем окно выбора файла  
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // если результат вернулся успешно 
                {
                    conn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + openFileDialog1.FileName; // формируем строку подключения
                    f = openFileDialog1.FileName; // запоминаем ссылку на файл
                    using (StreamWriter sw = new StreamWriter("Db.dat", false, System.Text.Encoding.Default))  // создаем новый файл конфигурации БД
                    {
                        sw.WriteLine("FileBD  ^" + openFileDialog1.FileName + "^");   // записываем в новый файл переменную ссылки на бд
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
                }
                if (oper == 0) // Изменение существующего индентификатора 
                {
                    string kls = "";
                    int col = 0;
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if ((textBox1.Text[i] != ' ') || (textBox1.Text[i] != '\t'))
                        {
                            col++;
                            kls += textBox1.Text[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    textBox1.Text = kls;
                    if (col <= 7)
                        textBox1.Text += "\t\t";
                    else if (col <= 14)
                    {
                        textBox1.Text += "\t";
                    }
                    else
                    {
                        for (int k = col; k <= 18; k++)
                        {
                            textBox1.Text += ' ';
                        }
                    }

                    string ll = textBox1.Text + "*" + textBox2.Text + "*";
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
                MessageBox.Show("Одно из полей пустое либо не правильно указанно ", "Ошибка", MessageBoxButtons.OK);
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
        private void изменитьИндентификаторToolStripMenuItem_Click(object sender, EventArgs e)// изменение текущего идентификатора
        {
            Boolean bl = false;
            string ll = Convert.ToString(listBox1.SelectedItem);
            string kl = "", sl = "";
            for (int i = 0; i < ll.Length; i++)
            {
                if ((ll[i] != '*') && (bl == false))
                {
                    kl += ll[i];
                }
                else
                {
                    bl = true;
                }
                if ((bl == true) && (ll[i] != '*'))
                {
                    sl += ll[i];
                }
            }
            textBox1.Text = null;
            for (int i = 0; i < kl.Length; i++)
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

        private void удалитьИндентификаторToolStripMenuItem_Click(object sender, EventArgs e)// удаление индентификатора 
        {
            if (Convert.ToString(MessageBox.Show("Вы действительно хотите удалить индентификатор \n " + listBox1.SelectedItem, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == "Yes")
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

        private void button2_Click_1(object sender, EventArgs e) // откртие форму уловов с учетом идентификатора 
        {
            idnt = indt.Count - 1;
            Hamsa subForm = new Hamsa(this);
            subForm.Show();
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e) // открытие формы анализа ошибок 
        {
            ErrAnal sub = new ErrAnal(this);
            sub.Show();
            this.Hide();
        }
    }
}
