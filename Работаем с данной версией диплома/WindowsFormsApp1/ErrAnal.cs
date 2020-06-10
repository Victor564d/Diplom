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
    public partial class ErrAnal : Form
    {
        Vibor mainform;
        public ErrAnal(Vibor mainform )
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        public string ErDT(string tb, ArrayList lines, int countlin)
        {
            int idnt = 3; int colCount = 0; ; string er = "Ошибок нет"; bool erdet = false;
            if (tb == "Уловы") { idnt = 0; colCount = 35; }
            if (tb == "Пробы") { idnt = 1; colCount = 19; }
            if (tb == "БА") { idnt = 2;    colCount = 26; }
            if (countlin != colCount)
            {
                er = "Колличество ячеек в строке не совпадает  с количесвом ячеек таблицы , в которую происходит импорт .";
                if (countlin == 35)
                {
                    er += "Возможно данные данные из таблицы \"Уловы\"";
                    counterr++;
                }
                if (countlin == 19)
                {
                    er += "Возможно данные данные из таблицы \"Пробы\"";
                    counterr++;
                }
                if (countlin == 26)
                {
                    er += "Возможно данные данные из таблицы \"БА\"";
                    counterr++;
                }
            }
            else
            {
                if (idnt == 0)
                {
                    er = "";
                    for (int j = 0;j< уловыDataGridView.Rows.Count; j++)
                    {
                        if (Convert.ToString(lines[0])== Convert.ToString(уловыDataGridView[0,j].Value))
                        {
                            er += "Запись с ключевым полем \"" + Convert.ToString(lines[0]) + "\" уже существует ";
                            counterr++;
                        }
                    }
                    try
                    {
                        short kl = Convert.ToInt16(lines[2]);
                    }
                        catch (Exception ex)
                    {
                            er = "Ошибка в поле 2 :" + ex.Message + ". ";
                    }
                    try
                    {
                        short kl = Convert.ToInt16(lines[3]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 3 :" + ex.Message + ". ";
                    }
                    try
                    {
                        short kl = Convert.ToInt16(lines[4]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 4 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[10]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 10 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[11]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 11 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[14]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 14 :" + ex.Message + ". ";
                    }
                    try
                    {
                        DateTime kl = Convert.ToDateTime(lines[15]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 15 :" + ex.Message + ". ";
                    }
                    for (int j= 19; j<= 28; j++)
                    {
                        try
                        {
                            double kl = Convert.ToDouble(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле "+Convert.ToString(j)+" :" + ex.Message + ". ";
                        }
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[31]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 31 :" + ex.Message + ". ";
                    }

                } 
                if (idnt == 1)
                {
                    er = "";
                    for (int j = 0; j < пробыDataGridView.Rows.Count; j++)
                    {
                        if (Convert.ToString(lines[1]) == Convert.ToString(пробыDataGridView[1, j].Value))
                        {
                            er += "Запись с ключевым полем \"" + Convert.ToString(lines[1]) + "\" уже существует ";
                            counterr++;
                        }
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[2]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 2 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[3]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 3 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[7]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 7 :" + ex.Message + ". ";
                    }
                    try
                    {
                        double kl = Convert.ToDouble(lines[8]);
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле " + Convert.ToString(8) + " :" + ex.Message + ". ";
                    }
                    for (int j = 10; j <= 17; j++)
                    {
                        try
                        {
                            double kl = Convert.ToDouble(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле " + Convert.ToString(j) + " :" + ex.Message + ". ";
                        }
                    }
                    
                }
                if (idnt == 2)
                {
                    er = "";
                    for (int j = 0; j < бАDataGridView.Rows.Count; j++)
                    {
                        if (Convert.ToString(lines[1]) == Convert.ToString(бАDataGridView[1, j].Value))
                        {
                            er += "Запись с ключевым полем \"" + Convert.ToString(lines[1]) + "\" уже существует ";
                            counterr++;
                        }
                    }
                    for (int j = 2; j <= 4; j++) // 2 3 4 
                    {
                        try
                        {
                            double kl = Convert.ToInt16(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле " + Convert.ToString(j) + " :" + ex.Message + ". ";
                        }
                    }
                    for (int j = 5; j <= 8; j++) //5 6 7 8 
                    {
                        try
                        {
                            decimal kl = Convert.ToDecimal(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле " + Convert.ToString(j) + " :" + ex.Message + ". ";
                        }
                    }
                    try
                    {
                        short kl = Convert.ToInt16(lines[10]); //10
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 10 :" + ex.Message + ". ";
                    }
                    try
                    {
                        short kl = Convert.ToInt16(lines[11]); //11
                    }
                    catch (Exception ex)
                    {
                        er = "Ошибка в поле 11 :" + ex.Message + ". ";
                    }
                    for (int j = 12; j <= 15; j++) //12 13 14 15 
                    {
                        try
                        {
                            decimal kl = Convert.ToDecimal(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле " + Convert.ToString(j) + " :" + ex.Message + ". ";
                        }
                    }
                    for (int j = 17; j <= 24; j++) //12 13 14 15 
                    {
                        try
                        {
                            double kl = Convert.ToDouble(lines[j]);
                        }
                        catch (Exception ex)
                        {
                            er = "Ошибка в поле " + Convert.ToString(j) + " :" + ex.Message + ". ";
                        }
                    }
                }
            }
            return(er);
        }
        ArrayList cells = new ArrayList();
        public int counterr = 0;
        private void ErrAnal_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 80; i++)
            {
                cells.Add("%");
            }
            tableAdapterManager.Connection.ConnectionString = mainform.conn;
            уловыTableAdapter.Connection.ConnectionString = mainform.conn;
            пробыTableAdapter.Connection.ConnectionString = mainform.conn;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестовая_бд_DataSet.Уловы". При необходимости она может быть перемещена или удалена.
            this.уловыTableAdapter.Fill(this.тестовая_бд_DataSet.Уловы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестовая_бд_DataSet.Пробы". При необходимости она может быть перемещена или удалена.
            this.пробыTableAdapter.Fill(this.тестовая_бд_DataSet.Пробы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестовая_бд_DataSet.БА". При необходимости она может быть перемещена или удалена.
             { this.бАTableAdapter.FillBy11(this.тестовая_бд_DataSet.БА,"%"); }
           
            //catch (Exception ex)
            {
                
            }
                 

        }

        private void ErrAnal_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
        }
        public string patch;

        private void button1_Click(object sender, EventArgs e)
        {
            OpFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (OpFile.ShowDialog() == DialogResult.OK)
            {
                patch = OpFile.FileName;
                label2.Text = patch;
            }
        }

        private void OpFile_FileOk(object sender, CancelEventArgs e)
        {

        }
        string err;
        private void button2_Click(object sender, EventArgs e)
        {
            if (patch == null) { MessageBox.Show("Откройте файл для анализа", "Предуприждение"); }else 
            if (Convert.ToString(MessageBox.Show("Вы действительно хотите начать анализ ошибок? При обработке ошибок работа с основной программой будет заблокирована", "Предуприждение !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == "Yes")
            {
                counterr = 0;
                richTextBox1.Text = "";
                ArrayList lines = new ArrayList();
                string ll; string str = ""; int count = 0;
                string patch = OpFile.FileName;
                StreamReader sr = new StreamReader(patch, Encoding.Default);
                int li = 0;
                int cornt = 0;
                while ((ll = sr.ReadLine()) != null)
                {
                    cornt++;
                   //richTextBox1.Text += ll;
                }
                sr.Close();
                progressBar1.Maximum = cornt;
                progressBar1.Value = 0;
                sr = new StreamReader(patch, Encoding.Default);
                ll = sr.ReadLine();
                string table=""; bool ld = false;
                for(int i = 0; i < ll.Length; i++)
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
                label5.Text = "Работа с таблицей : " + table;
                ld = false;
                string sl = DateTime.Now.ToString("dd.MM.yy HH_mm_ss");
                string patc = "Отчеты обработки ошибок/Отчет обработки от " + sl + ".txt"; 
                using (StreamWriter sw = new StreamWriter(patc, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Результат анализа ошибок в файле :" + patch);
                    while ((ll = sr.ReadLine()) != null)
                    {
                        li++;
                        for (int i = 0; i < ll.Length; i++)
                        {
                            if ((ll[i] == '{') || (ll[i] == '}')) { if (ld == false) ld = true; else ld = false; }
                            else
                            {
                                if (ld == true) 
                                if ((ll[i] != ';') || (ll[i] == (Convert.ToChar(13))))
                                {
                                    str = str + ll[i];
                                }
                                else
                                {
                                    if (str == "")
                                    {
                                        lines.Add(null);
                                    }
                                    else
                                        lines.Add(str);
                                    str = "";
                                    count++;
                                }
                            }
                        }
                        count -= 1;
                        if (count >= 1)
                        {
                            int i = 0;
                            label4.Text = ll;
                            err = ErDT(table, lines, count);
                            richTextBox1.Text += ll+"\n";
                            i = richTextBox1.Text.IndexOf(ll, i);
                            richTextBox1.SelectionStart = i;
                            richTextBox1.SelectionLength = ll.Length;
                            richTextBox1.SelectionColor = Color.Red;
                            richTextBox1.SelectionColor = Color.Black;
                            richTextBox1.Text = richTextBox1.Text +"Следующие ошибки: " +err + "\n";
                            richTextBox1.Text += "------------------------------------------------------------------------------------------------------------------\n";
                            // richTextBox1.Text = richTextBox1.Text + "В строке " + ll;
                            // richTextBox1.Text = richTextBox1.Text + err + "\n";
                            sw.WriteLine("Строка :" + ll);
                            sw.WriteLine("Все ошибки в строке:");
                            sw.WriteLine(err);
                        }
                        progressBar1.Value = progressBar1.Value + 1 ;
                        ld = false;
                        err = "";
                        count = 0;
                        lines.Clear();
                        if (counterr >= 15)
                        {
                            if (Convert.ToString(MessageBox.Show("Найдено более 15 однотипных ошибок. Прекратить проверку файла на ошибки?", "Предуприждение !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == "Yes")
                            {
                                break;
                            } else
                            {
                                counterr = -999999999;
                            }

                        }
                        
                    }
                    sw.Close();
                    progressBar1.Value = progressBar1.Maximum;
                    MessageBox.Show("Анализ ошибок завершен . Отчет находится в папке \"Отчеты обработки ошибок\"", "Сообщение");
                    progressBar1.Value = progressBar1.Minimum;
                }
            }
        }

        private void бАBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.бАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

        }

        private void бАBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.бАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

        }
    }
}
