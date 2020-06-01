using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hamsa : Form
    {
        public void upd(ArrayList lines, ArrayList orig) // эт для вставки 
        {
            try // проверяем те значения которые являются числом, если оно пустое, то запишем туда -999
            {
                if (Convert.ToString(lines[2]) == "") lines[2] = -999;
                if (Convert.ToString(lines[3]) == "") lines[3] = -999;
                if (Convert.ToString(lines[4]) == "") lines[4] = -999;
                if (Convert.ToString(lines[10]) == "") lines[10] = -999;
                if (Convert.ToString(lines[11]) == "") lines[11] = -999;
                if (Convert.ToString(lines[14]) == "") lines[14] = -999;
                if (Convert.ToString(lines[19]) == "") lines[19] = -999;
                if (Convert.ToString(lines[20]) == "") lines[20] = -999;
                if (Convert.ToString(lines[21]) == "") lines[21] = -999;
                if (Convert.ToString(lines[22]) == "") lines[22] = -999;
                if (Convert.ToString(lines[23]) == "") lines[23] = -999;
                if (Convert.ToString(lines[24]) == "") lines[24] = -999;
                if (Convert.ToString(lines[25]) == "") lines[25] = -999;
                if (Convert.ToString(lines[26]) == "") lines[26] = -999;
                if (Convert.ToString(lines[27]) == "") lines[27] = -999;
                if (Convert.ToString(lines[28]) == "") lines[28] = -999;
                if (Convert.ToString(lines[31]) == "") lines[31] = -999;
            }
            catch
            { }
            try //пытаемся вставить поля в таблицу бд, конертируя соответствующие данные в нужный тип 
            {
                уловыTableAdapter.Delete(Convert.ToString(orig[0]));
                
                уловыTableAdapter.Insert(Convert.ToString(lines[0]),
                                         Convert.ToString(lines[1]),
                                         Convert.ToInt16(lines[2]),
                                         Convert.ToInt16(lines[3]),
                                         Convert.ToInt16(lines[4]),
                                         Convert.ToString(lines[5]),
                                         Convert.ToString(lines[6]),
                                         Convert.ToString(lines[7]),
                                         Convert.ToString(lines[8]),
                                         Convert.ToString(lines[9]),
                                         Convert.ToDouble(lines[10]),
                                         Convert.ToDouble(lines[11]),
                                         Convert.ToString(lines[12]),
                                         Convert.ToString(lines[13]),
                                         Convert.ToDouble(lines[14]),
                                         Convert.ToDateTime(lines[15]),
                                         Convert.ToString(lines[16]),
                                         Convert.ToString(lines[17]),
                                         Convert.ToString(lines[18]),
                                         Convert.ToDouble(lines[19]),
                                         Convert.ToDouble(lines[20]),
                                         Convert.ToDouble(lines[21]),
                                         Convert.ToDouble(lines[22]),
                                         Convert.ToDouble(lines[23]),
                                         Convert.ToDouble(lines[24]),
                                         Convert.ToDouble(lines[25]),
                                         Convert.ToDouble(lines[26]),
                                         Convert.ToDouble(lines[27]),
                                         Convert.ToDouble(lines[28]),
                                         Convert.ToString(lines[29]),
                                         Convert.ToString(lines[30]),
                                         Convert.ToDouble(lines[31]),
                                         Convert.ToString(lines[32]),
                                         Convert.ToString(lines[33]),
                                         Convert.ToString(lines[34])//Ниже идет оригинальная запись
                                         );
                this.уловыTableAdapter.Update(this.тестовая_бд_DataSet);//сохраняем обновления в базу
                this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(idnt));
            }
            catch (System.Exception ex) // если возникла ошибка 
            {
                MessageBox.Show("Возникла ошибка записи, проверьте поля. Текст ошибки: " + ex.Message, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(idnt)); //обновляем список на экране
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
                if (Convert.ToString(lines[10]) == "") lines[10] = -999;
                if (Convert.ToString(lines[11]) == "") lines[11] = -999;
                if (Convert.ToString(lines[14]) == "") lines[14] = -999;
                if (Convert.ToString(lines[19]) == "") lines[19] = -999;
                if (Convert.ToString(lines[20]) == "") lines[20] = -999;
                if (Convert.ToString(lines[21]) == "") lines[21] = -999;
                if (Convert.ToString(lines[22]) == "") lines[22] = -999;
                if (Convert.ToString(lines[23]) == "") lines[23] = -999;
                if (Convert.ToString(lines[24]) == "") lines[24] = -999;
                if (Convert.ToString(lines[25]) == "") lines[25] = -999;
                if (Convert.ToString(lines[26]) == "") lines[26] = -999;
                if (Convert.ToString(lines[27]) == "") lines[27] = -999;
                if (Convert.ToString(lines[28]) == "") lines[28] = -999;
                if (Convert.ToString(lines[31]) == "") lines[31] = -999;
            }
            catch
            { }
            try //пытаемся вставить поля в таблицу бд, конертируя соответствующие данные в нужный тип 
            {
                уловыTableAdapter.Insert(Convert.ToString(lines[0]),
                                         Convert.ToString(lines[1]),
                                         Convert.ToInt16(lines[2]),
                                         Convert.ToInt16(lines[3]),
                                         Convert.ToInt16(lines[4]),
                                         Convert.ToString(lines[5]),
                                         Convert.ToString(lines[6]),
                                         Convert.ToString(lines[7]),
                                         Convert.ToString(lines[8]),
                                         Convert.ToString(lines[9]),
                                         Convert.ToDouble(lines[10]),
                                         Convert.ToDouble(lines[11]),
                                         Convert.ToString(lines[12]),
                                         Convert.ToString(lines[13]),
                                         Convert.ToDouble(lines[14]),
                                         Convert.ToDateTime(lines[15]),
                                         Convert.ToString(lines[16]),
                                         Convert.ToString(lines[17]),
                                         Convert.ToString(lines[18]),
                                         Convert.ToDouble(lines[19]),
                                         Convert.ToDouble(lines[20]),
                                         Convert.ToDouble(lines[21]),
                                         Convert.ToDouble(lines[22]),
                                         Convert.ToDouble(lines[23]),
                                         Convert.ToDouble(lines[24]),
                                         Convert.ToDouble(lines[25]),
                                         Convert.ToDouble(lines[26]),
                                         Convert.ToDouble(lines[27]),
                                         Convert.ToDouble(lines[28]),
                                         Convert.ToString(lines[29]),
                                         Convert.ToString(lines[30]),
                                         Convert.ToDouble(lines[31]),
                                         Convert.ToString(lines[32]),
                                         Convert.ToString(lines[33]),
                                         Convert.ToString(lines[34])//Ниже идет оригинальная запись
                                         );
                this.уловыTableAdapter.Update(this.тестовая_бд_DataSet);//сохраняем обновления в базу
            }
            catch (System.Exception ex) // если возникла ошибка 
            {
                MessageBox.Show("Возникла ошибка записи, проверьте поля. Текст ошибки: " + ex.Message, "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(idnt)); //обновляем список на экране
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка"); //если возникла ошибка при обновлении 
            }
        }


        private Vibor mainform;
        public ArrayList cells = new ArrayList(); //массив полей для открытия других форм
        public Hamsa(Vibor mainform)
        {
            this.mainform = mainform;
            InitializeComponent();


        }
        public string Conn; //строка подключения
        public string idnt; //идентификатор формы
        private void Hamsa_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестовая_бд_DataSet1.Уловы". При необходимости она может быть перемещена или удалена.
            string f = "БДРЫБА.mdb"; //"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f);
            Conn = mainform.conn; //получение строки подключения к базе
            tableAdapterManager.Connection.ConnectionString = Conn; //задаем строку подключения
            //MessageBox.Show(this.уловыTableAdapter.Adapter.SelectCommand.CommandText);
           // string query = "SELECT  CathID, SamplID, DD, MM, YYYY, Region, Area, Location, Latitude, Longitude, Depth, WaterTemperature, Gear, Vessel, Catch, DateOfProc, Condition, LengthRange, Mode, MeanLength, [Number of ind], [WetWeight, g],[MeanWW, g], MeanDW, [Mean_TL %], [Calculated_TL %], SizeClasses, DW_Samples, TL_Samples, DW_Ind, TL_Ind, BioAnalyses_Ind, Comments, DataSource, DataFile FROM Уловы WHERE(CathID LIKE ?)";
            // this.tableAdapterManager.УловыTableAdapter.Adapter.SelectCommand.CommandText = query;
            //this.уловыTableAdapter.Adapter.Fill((this.тестовая_бд_DataSet.Уловы));
            this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.idnt]));//вызываем sql с параметром идентификатора
            try { cells.Add(Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value)); } //пытаемся считать значение catchid для дальнейшего открытия каких-либо запросов с базой 
            catch { cells.Add(null); } // иначе вводим null 
            for (int i = 1; i <= 80; i++) //остальные значения заполняем 999999 да бы они не влияли на условия 
                cells.Add(999999);
            idnt = Convert.ToString(mainform.indt[mainform.idnt]);// на всякий , получаем идентификатор с предыдушей формы.
        }

        private void Hamsa_FormClosing(object sender, FormClosingEventArgs e) // при закрытии формы открыть придыдущую 
        {
            Vibor vibors = new Vibor(); //задаем предыдушую форму 
            vibors.Show(); //открываем ее 
        }
        private void уловыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void уловыBindingNavigatorSaveItem_Click(object sender, EventArgs e) // сохранение в бд кнопка сохранить
        {
            this.Validate(); // я хз шо це
            this.уловыBindingSource.EndEdit(); //завершаем изменения 
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);//сохраняем обновления в базу
        }

        private void Hamsa_ResizeEnd(object sender, EventArgs e) //Это подгон размера таблицы под размер формы 
        {
            уловыDataGridView.Width = this.Width - 36; //Это подгон размера таблицы 
            уловыDataGridView.Height = this.Height - 74; //Это подгон размера таблицы 
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void уловыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void ShowSetinngsУЛ_Click(object sender, EventArgs e) // форма настроек отображения при нажатии на кнопку 
        {
            SettingsУл subform = new SettingsУл(this);  //инициализация формы
            subform.Show(); // открытие формы 
        }

        private void Hamsa_Resize(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillallToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //окрытие формы пробы 
        {
            Proby subform = new Proby(this); //Инициализация формы
            subform.Show();// открытие формы
        }

        private void уловыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) //обработка ввода неверных значений 
        {
            System.Windows.Forms.MessageBox.Show("Ошибка ввода информации в ячейку. Возможно, происходит повторение ключевого поля, не совпадают типы данных или неизвестная ошибка ввода ", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e) 
        {
        }

        public string Error = "";// строка ошибки 
        public bool bl = false; // булевская переменная, отображающая , найдена ли ошибка.
        ArrayList erlli = new ArrayList(); //массив куда записывается тип ошибки 
        ArrayList erll = new ArrayList(); //сюда записывается исходная строка в которой ошибка
        private void импортToolStripMenuItem_Click(object sender, EventArgs e) //при выборе импорта в меню
        {
            OpFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"; //задание фильтра для openfile
            if (OpFile.ShowDialog() == DialogResult.OK) //если результат есть 
            {
                erlli.Clear(); //очищаем все массивы перед работой 
                erll.Clear();
                ArrayList lines = new ArrayList(); // массив строк (линий)
                string ll; string str = ""; int count = 0; // ll - это строка которую мы получаем из файла, str - переменная в которую мы считываем временные значения каждого поля
                string patch = OpFile.FileName; // запоминаем имя фала , которое было выбрано
                StreamReader sr = new StreamReader(patch, Encoding.Default); // инициализируем считыватель
                int li = 0; //Счетчик итераций цикла 

                while ((ll = sr.ReadLine()) != null) // пока не закончатся линии
                {
                    li++; //увеличиваем счетчик 
                    for (int i = 0; i < ll.Length; i++) // начинаем посимвольное считывание
                    {
                        if ((ll[i] != ';') || (ll[i] == (Convert.ToChar(13)))) //если найден конец или ; то считываем  
                        {
                            str = str + ll[i]; // в str записываем символ 
                        }
                        else //иначе
                        {
                            if (str == "") // если по итогу str пустой, записываем пустоту
                            {
                                lines.Add(null);
                            }
                            else // иначе добавляем значение 
                                lines.Add(str); 
                            str = ""; // очищаем значение 
                            count++; // увеличиваем колличество 
                        }
                    }
                    try // проверяем те значения которые являются числом, если оно пустое, то запишем туда -999
                    {
                        if (lines[2] == null) lines[2] = -999;
                        if (lines[3] == null) lines[3] = -999;
                        if (lines[4] == null) lines[4] = -999;
                        if (lines[10] == null) lines[10] = -999;
                        if (lines[11] == null) lines[11] = -999;
                        if (lines[14] == null) lines[14] = -999;
                        if (lines[19] == null) lines[19] = -999;
                        if (lines[20] == null) lines[20] = -999;
                        if (lines[21] == null) lines[21] = -999;
                        if (lines[22] == null) lines[22] = -999;
                        if (lines[23] == null) lines[23] = -999;
                        if (lines[24] == null) lines[24] = -999;
                        if (lines[25] == null) lines[25] = -999;
                        if (lines[26] == null) lines[26] = -999;
                        if (lines[27] == null) lines[27] = -999;
                        if (lines[28] == null) lines[28] = -999;
                        if (lines[31] == null) lines[31] = -999;
                    }
                    catch
                    { }
                    try //пытаемся вставить поля в таблицу бд, конертируя соответствующие данные в нужный тип 
                    {
                        уловыTableAdapter.Insert(Convert.ToString(lines[0]),
                                                 Convert.ToString(lines[1]),
                                                 Convert.ToInt16(lines[2]),
                                                 Convert.ToInt16(lines[3]),
                                                 Convert.ToInt16(lines[4]),
                                                 Convert.ToString(lines[5]),
                                                 Convert.ToString(lines[6]),
                                                 Convert.ToString(lines[7]),
                                                 Convert.ToString(lines[8]),
                                                 Convert.ToString(lines[9]),
                                                 Convert.ToDouble(lines[10]),
                                                 Convert.ToDouble(lines[11]),
                                                 Convert.ToString(lines[12]),
                                                 Convert.ToString(lines[13]),
                                                 Convert.ToDouble(lines[14]),
                                                 Convert.ToDateTime(lines[15]),
                                                 Convert.ToString(lines[16]),
                                                 Convert.ToString(lines[17]),
                                                 Convert.ToString(lines[18]),
                                                 Convert.ToDouble(lines[19]),
                                                 Convert.ToDouble(lines[20]),
                                                 Convert.ToDouble(lines[21]),
                                                 Convert.ToDouble(lines[22]),
                                                 Convert.ToDouble(lines[23]),
                                                 Convert.ToDouble(lines[24]),
                                                 Convert.ToDouble(lines[25]),
                                                 Convert.ToDouble(lines[26]),
                                                 Convert.ToDouble(lines[27]),
                                                 Convert.ToDouble(lines[28]),
                                                 Convert.ToString(lines[29]),
                                                 Convert.ToString(lines[30]),
                                                 Convert.ToDouble(lines[31]),
                                                 Convert.ToString(lines[32]),
                                                 Convert.ToString(lines[33]),
                                                 Convert.ToString(lines[34])
                                                 );
                    }
                    catch (System.Exception ex) // если возникла ошибка 
                    {
                        erll.Add("Ошибка записи в поле " + Convert.ToString(li) + ", RecordlID = \"" + lines[1] + "\"" + " исходная строка : \n");//Добавляем строку в ошибочную
                        erlli.Add("{" + ll + "}"); //добовляем исходную строку 
                        bl = true; // переключаем значение переменной , так как мы нашли ошибку.
                    }
                    lines.Clear(); //чистим масив линий 
                    str = ""; // очищаем временную переменную 
                }
                sr.Close(); //после выполнения всего - закрываем файл
            }
            if (bl == true) //если найдена ошибка 
            {
                string sl = DateTime.Now.ToString("dd.MM.yy HH_mm_ss"); // временная переменная хранящая дату 
                string patch = "Ошибки импорта/Ошибки импорта  " + sl + ".csv"; // создаем ссылку на файл списка ошибок 
                System.Windows.Forms.MessageBox.Show("При импорте произошла ошибка. Для более подробной информации произведите анализ файла  \"" + patch + "\" в анализаторе ошибок ", "Список строк с ошибками");
                using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default)) //вывели сообщение об ошибке с сылкой на файл, создаем такой файл
                {
                    sw.WriteLine("Ошибка импорта в таблицу ^Уловы^ . Ошибочные строки :"); //записываем, в какую таблицу мы грузили все это, где возникла ошибка
                    for (int i = 0; i < erll.Count; i++) //цикл записи в файл
                    {
                        sw.WriteLine(erll[i]);
                        sw.WriteLine(erlli[i]);
                    }
                    sw.Close(); //закрываем файл 
                }
                bl = false; //переключаем значение ошибки в false 
            }
            else
            {
                if (bl != true) this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet); //иначе проверяем , точно ли ошибка не найдена, тогда записываем изменения в БД 
                try
                {
                    this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.listBox1.SelectedIndex])); //обновляем список на экране
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка"); //если возникла ошибка при обновлении 
                }
            }
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e) //при вызове экспорта 
        {
            SaveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";  //задаем фильтр для сохранения файла 
            if (SaveFile.ShowDialog() == DialogResult.OK) // если результат получился
            {
                string path = SaveFile.FileName; // запоминаем имя файла
                if (path != null) //если имя файла не пусто
                {
                    try //пытаемся записать все в файл
                    {
                        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default)) // инициализируем записыватель
                        {
                            for (int i = 0; i < уловыDataGridView.Rows.Count - 1; i++) // до конца всего списка текущих записей 
                            {
                                for (int j = 0; j <= 34; j++) // цикл вывода полей 
                                {
                                    {
                                        if ((Convert.ToString(уловыDataGridView[j, i].Value) != "") && (Convert.ToString(уловыDataGridView[j, i].Value) != "-999"))
                                            sw.Write(Convert.ToString(уловыDataGridView[j, i].Value)); //записываем значение если оно не пустое и не -999
                                        else sw.Write(Convert.ToString(null)); //иначе пишем пустоту
                                        sw.Write(";"); //печатаем разделитель 
                                        if (j == 34) //если написали все поля
                                        {
                                            sw.Write(" ;"); //напечатать разделтель
                                        }
                                    }
                                }
                                sw.WriteLine(""); //переходим на следующую строку 
                            }
                            sw.Close(); //после выполнения всего, закрываем файл 
                        }
                    }
                    catch (Exception ex) //при возникновении ошибки
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message); //выводим сообщение об ошибке
                    }
                }
            }
        }

        private void настройкиОтображенияToolStripMenuItem_Click(object sender, EventArgs e) //вызов формы настройки отображения 
        {
            SettingsУл subform = new SettingsУл(this); //инициализация формы
            subform.Show(); //открытие формы 
        }

        private void пробыToolStripMenuItem_Click(object sender, EventArgs e) //открытие формы пробы 
        {
            Proby subform = new Proby(this); //инициализация формы
            subform.Show(); //открытие формы 
        }

        private void уловыBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
        }

        private void уловыDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public string key; //переменная хранящая название кнопки 
        private void уловыDataGridView_KeyDown(object sender, KeyEventArgs e) //при нажатии кнопки
        {
            key = e.KeyCode.ToString(); // считываем значение кнопки
            // cells.Clear();
            // MessageBox.Show(e.KeyCode.ToString());
        }
        public int k = 1;
        private void уловыDataGridView_Click(object sender, EventArgs e) // выполняется при клике 
        {

            if (key == "ControlKey") //если название нажатой кнопки равно ctrl то 
            {
                try { cells[k] = (Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value)); } //пытаемся считать значение выделенной ячейки 
                catch { }
                k++; //счетчик увеличиваем 
            }
            else //иначе 
            {
                try //пытаемся считать значение текущей ячейки
                {
                    cells[0] = (Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value)); // записываем одно значение 
                }
                catch { } 
                for (int i = 1; i <= 80; i++) // остальные значение записываем 9999999
                    cells[i] = (999999);
                k = 1; //количество записей равно одному
            }
        }

        private void уловыDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            key = ""; //если кнопка отпущена - очистить 
        }

        private void уловыDataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }
        //  string sql = "SELECT        CathID, SamplID, DD, MM, YYYY, Region, Area, Location, Latitude, Longitude, Depth, WaterTemperature, Gear, Vessel, Catch, DateOfProc, Condition, LengthRange, Mode, MeanLength, [Number of ind], [WetWeight, g], [MeanWW, g], MeanDW, [Mean_TL %], [Calculated_TL %], SizeClasses, DW_Samples, TL_Samples, DW_Ind, TL_Ind, BioAnalyses_Ind, Comments, DataSource, DataFile FROM Уловы WHERE(DD = ?) OR(MM = ?) OR(YYYY = ?)";
        private void датеToolStripMenuItem_Click(object sender, EventArgs e) //при открытии фильтра
        {
            FiltrsYL subform = new FiltrsYL(this); //инициализируем новую форму 
            subform.Show(); //открыть ее
            //  this.уловыTableAdapter.Adapter.SelectCommand.CommandText = sql;
        }

        private void fillByDateToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void dDToolStripTextBox_Click(object sender, EventArgs e)
        {
        }

        private void биологическийАнализToolStripMenuItem_Click(object sender, EventArgs e) //открытие формы ба при нажатии кнопки
        {
            BA subform = new BA(this); //инициализация формы
            subform.Show(); // отобразить форму
        }

        private void fiillMMBEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillMMMEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillMMEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillDDBEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillDDMEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillDDEToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void отключитьФильтрToolStripMenuItem_Click(object sender, EventArgs e) //при отключении фильтра (менюшка)
        {
            this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.idnt])); //грузим все без фильтра
            menuStrip1.BackColor = Color.FromArgb(235, 231, 202); //возвращаем цвет 
        }

        private void регионуToolStripMenuItem_Click(object sender, EventArgs e) //фильтр по региону
        {
            FiltrYLR subform = new FiltrYLR(this); //инициализация формы 
            subform.Show(); // открытие формы
        }

        private void fillRegAllToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fillRegAllToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e) //открыть все пробы
        {
            cells[0] = "%"; // параметр задаем как процент (любое значение)
            Proby subform = new Proby(this);// инициализируем форму 
            subform.Show(); // открыть форму

        }

        private void открытьВсеУловыToolStripMenuItem_Click(object sender, EventArgs e) //открыть все уловы
        {
            cells[0] = "%"; // параметр задаем как процент (любое значение)
            BA subform = new BA(this); // инициализируем форму 
            subform.Show();// открыть форму

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ArrayList zapis = new ArrayList();

            for (int j = 0; j <= 34; j++) // цикл вывода полей 
            {
                {
                    zapis.Add(null);
                }
            }
            Catch_Record_Form newForm = new Catch_Record_Form(this);
            newForm.operation = "New";
            newForm.zapis = zapis;
            newForm.orig = zapis;
            newForm.Show();
            
        }

        private void уловыDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList zapis = new ArrayList();

            for (int j = 0; j <= 34; j++) // цикл вывода полей 
            {
                {
                    if (Convert.ToString(уловыDataGridView[j, уловыDataGridView.CurrentCell.RowIndex].Value) != "-999")
                        zapis.Add(Convert.ToString(уловыDataGridView[j, уловыDataGridView.CurrentCell.RowIndex].Value));
                    else zapis.Add("");
                }
            }


            Catch_Record_Form newForm = new Catch_Record_Form(this);
            newForm.zapis = zapis;
            newForm.orig = zapis;
            newForm.operation = "Redact";
            newForm.Show();
        }
    }
}

