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
using System.Collections.Generic;



namespace WindowsFormsApp1
{
    public partial class Proby : Form
    {
        private void reload()
        {
            this.пробыTableAdapter.FillBy(this.тестовая_бд_DataSet.Пробы,
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
                    Convert.ToString(mainform.cells[79]));
        }
        public void upd(ArrayList lines, ArrayList orig) // эт для вставки 
        {
            try // проверяем те значения которые являются числом, если оно пустое, то запишем туда -999
            {
                if (Convert.ToString(lines[2]) == "") lines[2] = -999;
                if (Convert.ToString(lines[3]) == "") lines[3] = -999;
                if (Convert.ToString(lines[4]) == "") lines[4] = -999;
                if (Convert.ToString(lines[5]) == "") lines[5] = -999;
                if (Convert.ToString(lines[6]) == "") lines[6] = -999;
                if (Convert.ToString(lines[7]) == "") lines[7] = -999;
                if (Convert.ToString(lines[8]) == "") lines[8] = -999;
                if (Convert.ToString(lines[10]) == "") lines[10] = -999;
                if (Convert.ToString(lines[11]) == "") lines[11] = -999;
                if (Convert.ToString(lines[12]) == "") lines[12] = -999;
                if (Convert.ToString(lines[13]) == "") lines[13] = -999;
                if (Convert.ToString(lines[14]) == "") lines[14] = -999;
                if (Convert.ToString(lines[15]) == "") lines[15] = -999;
                if (Convert.ToString(lines[16]) == "") lines[16] = -999;
                if (Convert.ToString(lines[17]) == "") lines[17] = -999;
            }
            catch
            { }
            try //пытаемся вставить поля в таблицу бд, конертируя соответствующие данные в нужный тип 
            {
                this.пробыTableAdapter.Update(Convert.ToString(lines[0]),
                                                       Convert.ToString(lines[1]),
                                                       Convert.ToDecimal(lines[2]),
                                                       Convert.ToDecimal(lines[3]),
                                                       Convert.ToInt16(lines[4]),
                                                       Convert.ToInt16(lines[5]),
                                                       Convert.ToInt16(lines[6]),
                                                       Convert.ToDecimal(lines[7]),
                                                       Convert.ToDecimal(lines[8]),
                                                       Convert.ToString(lines[9]),
                                                       Convert.ToDecimal(lines[10]),
                                                       Convert.ToDecimal(lines[11]),
                                                       Convert.ToDecimal(lines[12]),
                                                       Convert.ToDecimal(lines[13]),
                                                       Convert.ToDecimal(lines[14]),
                                                       Convert.ToDecimal(lines[15]),
                                                       Convert.ToDecimal(lines[16]),
                                                       Convert.ToDecimal(lines[17]),
                                                       Convert.ToString(lines[18]),
                                                       Convert.ToString(orig[1]));
                this.пробыTableAdapter.Update(this.тестовая_бд_DataSet);
               
            }
            catch (System.Exception ex) // если возникла ошибка 
            {
                MessageBox.Show("Возникла ошибка записи, проверьте поля. Текст ошибки: " + ex.Message, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string errr="";
                for (int i =0;i<=18; i++)
                {
                    errr += Convert.ToString(i) + "     :" + lines[i];

                }
                errr = errr + "    orig    " + orig[0] + "     orig   " + orig[1];
                MessageBox.Show(errr);
            }
            try
            {
                reload();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка"); //если возникла ошибка при обновлении 
            }
        }

        public void ins(ArrayList lines)
        {
            try // проверяем те значения которые являются числом, если оно пустое, то запишем туда -999
            {
                if (Convert.ToString(lines[2]) == "") lines[2] = -999;
                if (Convert.ToString(lines[3]) == "") lines[3] = -999;
                if (Convert.ToString(lines[4]) == "") lines[4] = -999;
                if (Convert.ToString(lines[5]) == "") lines[5] = -999;
                if (Convert.ToString(lines[6]) == "") lines[6] = -999;
                if (Convert.ToString(lines[7]) == "") lines[7] = -999;
                if (Convert.ToString(lines[8]) == "") lines[8] = -999;
                if (Convert.ToString(lines[10]) == "") lines[10] = -999;
                if (Convert.ToString(lines[11]) == "") lines[11] = -999;
                if (Convert.ToString(lines[12]) == "") lines[12] = -999;
                if (Convert.ToString(lines[13]) == "") lines[13] = -999;
                if (Convert.ToString(lines[14]) == "") lines[14] = -999;
                if (Convert.ToString(lines[15]) == "") lines[15] = -999;
                if (Convert.ToString(lines[16]) == "") lines[16] = -999;
                if (Convert.ToString(lines[17]) == "") lines[17] = -999;
            }
            catch
            { }
            try //пытаемся вставить поля в таблицу бд, конертируя соответствующие данные в нужный тип 
            {
                пробыTableAdapter.Insert(Convert.ToString(lines[0]),
                                                       Convert.ToString(lines[1]),
                                                       Convert.ToDouble(lines[2]),
                                                       Convert.ToDouble(lines[3]),
                                                       Convert.ToInt16(lines[4]),
                                                       Convert.ToInt16(lines[5]),
                                                       Convert.ToInt16(lines[6]),
                                                       Convert.ToDouble(lines[7]),
                                                       Convert.ToDouble(lines[8]),
                                                       Convert.ToString(lines[9]),
                                                       Convert.ToDouble(lines[10]),
                                                       Convert.ToDouble(lines[11]),
                                                       Convert.ToDouble(lines[12]),
                                                       Convert.ToDouble(lines[13]),
                                                       Convert.ToDouble(lines[14]),
                                                       Convert.ToDouble(lines[15]),
                                                       Convert.ToDouble(lines[16]),
                                                       Convert.ToDouble(lines[17]),
                                                       Convert.ToString(lines[18]));
                this.пробыTableAdapter.Update(this.тестовая_бд_DataSet);
            }
            catch (System.Exception ex) // если возникла ошибка 
            {
                MessageBox.Show("Возникла ошибка записи, проверьте поля. Текст ошибки: " + ex.Message, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string errr = "";
                for (int i = 0; i <= 18; i++)
                {
                    errr=errr+ Convert.ToString(i) + "     :" + lines[i];

                }
                
                MessageBox.Show(errr);
            }
            try
            {
                reload();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка"); //если возникла ошибка при обновлении 
            }
        }




        public Hamsa mainform;
        public Proby(Hamsa mainform) //переменная формы (необходима для ссыллок на предыдущую форму)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
        public ArrayList cells = new ArrayList(); //массив ячеек(используется для открытия именно определенных записей через выделение)
        private void пробыBindingNavigatorSaveItem_Click(object sender, EventArgs e) //кнопка сохранения изменений 
        {
            this.Validate();
            this.пробыBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);
        }

        private void Form4_Load(object sender, EventArgs e)// выполняется при загрузке
        {
            cells = mainform.cells; //получение значения ячеек для соответствующей фильтрации записей
            tableAdapterManager.Connection.ConnectionString = mainform.Conn; //полуыение строки подключения к базе
             try //попытка выполнить sql запрос на фильтрацию
            {
                reload();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Convert.ToString(mainform.cells.Count),"Ошибка"); // выдаст ошибку если не получилось
            }
        }

        private void пробыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Proby_Resize(object sender, EventArgs e)//после того как сделался ресайз 
        {
            пробыDataGridView.Width = this.Width - 16; // подгоняем размер таблицы под размер формы 
            пробыDataGridView.Height = this.Height - 70;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void svazToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void Proby_FormClosing(object sender, FormClosingEventArgs e) //при закрытии формы выполнится сохранение записей 
        {
            this.Validate();
            this.пробыBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {    
        }
      
        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
        }


        private void fillCTRLToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillCTRLToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void пробыBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)// экспорт в файл. Принцип акой же как и в уловах
        {
            SaveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; //фильтр типа файла
            if (SaveFile.ShowDialog() == DialogResult.OK) //если результат есть
            {
                string path = SaveFile.FileName; // запоминаем имя файла 
                if (path != null) // если имя не пустое
                {
                    try //пытаемся
                    {
                        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default)) // инициализация записывателя
                        {
                            for (int i = 0; i < пробыDataGridView.Rows.Count - 2; i++) //пока не закончатся все строки
                            {
                                for (int j = 0; j <= 18; j++) // считываем ячейки 
                                {

                                    {
                                        if ((Convert.ToString(пробыDataGridView[j, i].Value) != "") && (Convert.ToString(пробыDataGridView[j, i].Value) != "-999")) //проверка на пустоту
                                            sw.Write(Convert.ToString(пробыDataGridView[j, i].Value)); //если не пусто - пишем значение
                                        else sw.Write(Convert.ToString(null));//иначе пишем пустоту
                                        sw.Write(";"); //пишем делители
                                        if (j == 18)//в конце добавляем тоже делитель
                                        {
                                            sw.Write(" ;");
                                        }
                                    }

                                }
                                sw.WriteLine("");//переходы на следующуб линию
                            }
                            sw.Close(); //закрытие считывателя 
                        }
                    }
                    catch (Exception ex)  // если не вышло - выдать ошибку
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message,"Ошибка");
                    }
                }
            }
        }

        public string Error = ""; //строка ошибок
        public bool bl = false; // переменная отвечающая за то , найдена ли ошибка 
        ArrayList erlli = new ArrayList(); //исходная строка с ошибкой 
        ArrayList erll = new ArrayList();// Описание ошибки
        private void импортToolStripMenuItem_Click(object sender, EventArgs e) // кнопка импорта в меню
        {
            { 
                OpFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; //фильтр открытия файла
                if (OpFile.ShowDialog() == DialogResult.OK) // если результат есть
                {
                    erlli.Clear(); //чистим массивы перед работой 
                    erll.Clear();
                     ArrayList lines = new ArrayList(); //массив полей в линии
                    string ll; string str = ""; int count = 0; // ll- строка считаная из фала , str - одно значение , которое вытягивается из строки 
                    string patch = OpFile.FileName; //запоминаем имя файла
                    StreamReader sr = new StreamReader(patch, Encoding.Default);// инициализация считывателя 
                    int li = 0; //номер текущей линии
                    while ((ll = sr.ReadLine()) != null) //пока линии не закончатся 
                    {
                        li++; // увеличиваем номер линии
                        for (int i = 0; i < ll.Length; i++) //пока линия не закончится 
                        {
                            if (ll[i] != ';' || (ll[i] == (Convert.ToChar(13)))) //если не найден переход или найден символ 13
                            {
                                str = str + ll[i]; //записываем текущий символ к значению 
                            }
                            else //иначе
                            {
                                if (str == "") //если пустота - запомним пустое значение
                                {
                                    lines.Add(null);
                                }
                                else
                                    lines.Add(str); //иначе запомним то что считали
                                str = ""; //чистим значение
                                count++; //увеличиваем счетчик 
                            }
                        }      //проверка на пустоту , если числовые значения пустые - записываем -999                   
                        if (lines[2] == null) lines[2] = -999;
                        if (lines[3] == null) lines[3] = -999;
                        if (lines[4] == null) lines[4] = -999;
                        if (lines[5] == null) lines[5] = -999;
                        if (lines[6] == null) lines[6] = -999;
                        if (lines[7] == null) lines[7] = -999;
                        if (lines[8] == null) lines[8] = -999;
                        if (lines[10] == null) lines[10] = -999;
                        if (lines[11] == null) lines[11] = -999;
                        if (lines[12] == null) lines[12] = -999;
                        if (lines[13] == null) lines[13] = -999;
                        if (lines[14] == null) lines[14] = -999;
                        if (lines[15] == null) lines[15] = -999;
                        if (lines[16] == null) lines[16] = -999;
                        if (lines[17] == null) lines[17] = -999;
                        
                        try //попытка вставить значения 
                        { 
                             пробыTableAdapter.Insert(Convert.ToString(lines[0]), 
                                                      Convert.ToString(lines[1]),
                                                      Convert.ToDouble(lines[2]),
                                                      Convert.ToDouble(lines[3]),
                                                      Convert.ToInt16(lines[4]),
                                                      Convert.ToInt16(lines[5]),
                                                      Convert.ToInt16(lines[6]),
                                                      Convert.ToDouble(lines[7]),
                                                      Convert.ToDouble(lines[8]),
                                                      Convert.ToString(lines[9]),
                                                      Convert.ToDouble(lines[10]),
                                                      Convert.ToDouble(lines[11]),
                                                      Convert.ToDouble(lines[12]),
                                                      Convert.ToDouble(lines[13]),
                                                      Convert.ToDouble(lines[14]),
                                                      Convert.ToDouble(lines[15]),
                                                      Convert.ToDouble(lines[16]),
                                                      Convert.ToDouble(lines[17]),
                                                      Convert.ToString(lines[18])); 
                        }
                        catch (System.Exception ex) //если ошибка 
                        {                        
                            erll.Add("Ошибка записи в поле " + Convert.ToString(li) + ", RecordlID = \"" + lines[1] + "\"" + " исходная строка : \n"); //записываем ошибку
                            erlli.Add("{"+ll+"}"); //записываем исхрдную строку
                            bl = true; //переключаем флажок
                        }
                        lines.Clear(); //чистим массив линий 
                        str = ""; //чистим значение
                    }
                    sr.Close(); //закрытие файла
                }

                if (bl != true) this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet); //если ошибка не найдена - обновляем значения 
                if (bl == true) //если есть ошибка 
                {
                    string sl = DateTime.Now.ToString("dd.MM.yy HH_mm_ss"); //запоминаем текущую дату 
                    string patch = "Ошибки импорта/Ошибки импорта  " + sl + ".csv"; //создаем путь к файлу
                    System.Windows.Forms.MessageBox.Show("При импорте произошла ошибка. Для более подробной информации произведите анализ файла  \""+patch+"\" в анализаторе ошибок ", "Список строк с ошибками");
                    using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default))//выводим сообщение об ошибке и создаем файл с ошибками
                    {
                        sw.WriteLine("Ошибка импорта в таблицу ^Пробы^ . Ошибочные строки :");//запись таблицы в которой вознкла ошибка
                        for(int i = 0;i< erll.Count; i++)//запись всего списка ошибок
                        {
                            sw.WriteLine(erll[i]);
                            sw.WriteLine(erlli[i]);
                        }
                        sw.Close(); //закрываем файл
                    }  
                    bl = false; //обратно переключаем ошибку 
                }
                else //иначе пробуем применить фильтр ) 
                    try
                    {
                        reload();
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                    }

            }
        }

        private void поРазмернымГруппаToolStripMenuItem_Click(object sender, EventArgs e) //открытие фильтра по размерным группам
        {
            FiltProbSize subform = new FiltProbSize(this);
            subform.Show();
        }

        private void отключитьФильтрToolStripMenuItem_Click(object sender, EventArgs e) //отключение фильтра
        {
            try
            {
                reload();
                menuStrip1.BackColor = Color.FromArgb(235, 231, 202); //меняем цвет 
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
            }
       
        }

        private void настройкиОтображенияToolStripMenuItem_Click(object sender, EventArgs e) //форма настройки отображения (открытие ее)
        {
            OtobrProb subform = new OtobrProb(this);
            subform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ArrayList zapis = new ArrayList();

            for (int j = 0; j <= 18; j++) // цикл вывода полей 
            {
                {
                    zapis.Add(Convert.ToString(null));
                }
            }
            Sample_Record_Form newForm = new Sample_Record_Form(this);
            newForm.zapis = zapis;
            newForm.orig = zapis;
            newForm.operation = "New";
            newForm.Show();

        }

        private void пробыDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList zapis = new ArrayList();

            for (int j = 0; j <= 18; j++) // цикл вывода полей 
            {
                {
                    if (Convert.ToString(пробыDataGridView[j, пробыDataGridView.CurrentCell.RowIndex].Value) != "-999")
                        zapis.Add(Convert.ToString(пробыDataGridView[j, пробыDataGridView.CurrentCell.RowIndex].Value));
                    else zapis.Add("");
                }
            }
            Sample_Record_Form newForm = new Sample_Record_Form(this);
            newForm.zapis = zapis;
            newForm.orig = zapis;
            newForm.operation = "Redact";
            newForm.Show();
        }
    }
}
