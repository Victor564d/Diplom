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
    public partial class Hamsa : Form
    {
        private Vibor mainform;
        public ArrayList cells = new ArrayList();
        public Hamsa(Vibor mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            

        }
        public string Conn;
        public string idnt;
        private void Hamsa_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестовая_бд_DataSet1.Уловы". При необходимости она может быть перемещена или удалена.
            string f = "БДРЫБА.mdb"; //"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + f);
            Conn = mainform.conn;
            tableAdapterManager.Connection.ConnectionString = Conn;


            this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.idnt]));
            try { cells.Add(Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value)); }
            catch { cells.Add(null); }
            for (int i = 1; i <= 80; i++)
                cells.Add(999999);
            idnt = Convert.ToString(mainform.indt[mainform.idnt]);

        }

        private void Hamsa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vibor vibors = new Vibor();
            vibors.Show();
        }

     

        private void уловыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void уловыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.уловыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

        }

        private void Hamsa_ResizeEnd(object sender, EventArgs e)
        {
            
            уловыDataGridView.Width = this.Width - 36;
            уловыDataGridView.Height = this.Height - 74;
           
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
            // if (toolStripComboBox1.SelectedIndex == 1)
            {
                try
                {
                   // this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                }

            }
           // if (toolStripComboBox1.SelectedIndex == 0)
            {
                try
                {
                    this.уловыTableAdapter.Fillall(this.тестовая_бд_DataSet.Уловы);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                }

            }
        }

        private void ShowSetinngsУЛ_Click(object sender, EventArgs e)
        {
            SettingsУл subform  = new SettingsУл(this);
            subform.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Proby subform = new Proby(this);
            subform.Show();

        }

        private void уловыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Ошибка ввода информации в ячейку. Возможно, происходит повторение ключевого поля, не совпадают типы данных или неизвестная ошибка ввода ","Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* SaveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                if (path != null)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                            for (int i = 0; i < уловыDataGridView.Rows.Count - 2; i++)
                            {
                                for (int j = 0; j <= 34; j++)
                                {

                                    {
                                        if (Convert.ToString(уловыDataGridView[j, i].Value) != "")
                                            sw.Write(Convert.ToString(уловыDataGridView[j, i].Value));
                                        else sw.Write(Convert.ToString(null));
                                        sw.Write(";");
                                        if (j == 34)
                                        {
                                            sw.Write(" ;");
                                        }

                                    }

                                }
                                sw.WriteLine("");
                            }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }

            } */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* OpFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (OpFile.ShowDialog() == DialogResult.OK)
            {
                ArrayList lines = new ArrayList();
                string ll; string str = ""; int count = 0;
                string patch = OpFile.FileName;
                StreamReader sr = new StreamReader(patch, Encoding.Default);

                while ((ll = sr.ReadLine()) != null)
                {

                    for (int i = 0; i < ll.Length; i++)
                    {
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
                    // пробыDataGridView.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5], lines[6], lines[7], lines[8], lines[9], lines[10], lines[11], lines[12], lines[13], lines[14], lines[15], lines[16], lines[17]);
                    //пробыTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO Пробы VALUES("+Convert.ToString(lines[0])+")";
                    try
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
                    catch (System.Exception ex)
                   {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                        break;
                    }
                   this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

                    lines.Clear();
                    str = "";
                }


            }
            try
            {
                //this.пробыTableAdapter.Svaz(this.тестовая_бд_DataSet.Пробы, Convert.ToString(mainform.уловыDataGridView[0, mainform.уловыDataGridView.CurrentCell.RowIndex].Value));
                this.уловыTableAdapter.Fill(this.тестовая_бд_DataSet.Уловы);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
            } */
        }
        public string Error = "";
        public bool bl = false;
        ArrayList erlli = new ArrayList();
        ArrayList erll = new ArrayList();
        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (OpFile.ShowDialog() == DialogResult.OK)
            {
                erlli.Clear();
                erll.Clear();
                ArrayList lines = new ArrayList();
                string ll; string str = ""; int count = 0;
                string patch = OpFile.FileName;
                StreamReader sr = new StreamReader(patch, Encoding.Default);
                int li = 0;

                while ((ll = sr.ReadLine()) != null)
                {
                    li++;
                    for (int i = 0; i < ll.Length; i++)
                    {
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
                    // пробыDataGridView.Rows.Add(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5], lines[6], lines[7], lines[8], lines[9], lines[10], lines[11], lines[12], lines[13], lines[14], lines[15], lines[16], lines[17]);
                    //пробыTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO Пробы VALUES("+Convert.ToString(lines[0])+")";
                    try
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
                    }catch
                        { }

                    try
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
                    catch (System.Exception ex)
                    {
                        //System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                        //break;
                        erll.Add("Ошибка записи в поле " + Convert.ToString(li) + ", RecordlID = \"" + lines[1] + "\"" + " исходная строка : \n");
                        erlli.Add("{" + ll + "}");
                        //Error = Error + "Ошибка записи в поле " + Convert.ToString(li) + ", ID Пробы = \"" + lines[1] + "\"" + "\n";
                        bl = true;
                    }
                   

                    lines.Clear();
                    str = "";
                }
                sr.Close();

            }


            if (bl == true)
            {
                string sl = DateTime.Now.ToString("dd.MM.yy HH_mm_ss");
                string patch = "Ошибки импорта/Ошибки импорта  " + sl + ".csv";
                System.Windows.Forms.MessageBox.Show("При импорте произошла ошибка. Для более подробной информации произведите анализ файла  \"" + patch + "\" в анализаторе ошибок ", "Список строк с ошибками");
                using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Ошибка импорта в таблицу ^Уловы^ . Ошибочные строки :");
                    for (int i = 0; i < erll.Count; i++)
                    {
                        sw.WriteLine(erll[i]);
                        sw.WriteLine(erlli[i]);
                    }

                    sw.Close();
                }
                // System.Windows.Forms.MessageBox.Show(Error, "Список строк с ошибками");
                bl = false;
            }
            else
            {
                if (bl != true) this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);
                try
                {
                    //this.пробыTableAdapter.Svaz(this.тестовая_бд_DataSet.Пробы, Convert.ToString(mainform.уловыDataGridView[0, mainform.уловыDataGridView.CurrentCell.RowIndex].Value));
                    this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.listBox1.SelectedIndex]));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                if (path != null)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                        {
                            for (int i = 0; i < уловыDataGridView.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j <= 34; j++)
                                {

                                    {
                                        if ((Convert.ToString(уловыDataGridView[j, i].Value) != "") && (Convert.ToString(уловыDataGridView[j, i].Value) != "-999"))
                                            sw.Write(Convert.ToString(уловыDataGridView[j, i].Value));
                                        else sw.Write(Convert.ToString(null));
                                        sw.Write(";");
                                        if (j == 34)
                                        {
                                            sw.Write(" ;");
                                        }

                                    }

                                }
                                sw.WriteLine("");
                            }
                            sw.Close();
                        } 
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void настройкиОтображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsУл subform = new SettingsУл(this);
            subform.Show();
        }

        private void пробыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proby subform = new Proby(this);
            subform.Show();

        }

        private void уловыBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void уловыDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public string key;
        private void уловыDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode.ToString();
           // cells.Clear();
            // MessageBox.Show(e.KeyCode.ToString());

        }
        public int k = 1;
        private void уловыDataGridView_Click(object sender, EventArgs e)
        {
           
            if (key == "ControlKey")
            {
                try { cells[k] = (Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value)); }
                catch { }
                k++;
            }
            else
            {
                try
                {
                    cells[0] = (Convert.ToString(уловыDataGridView[1, уловыDataGridView.CurrentCell.RowIndex].Value));
                }
                catch { }
                for (int i = 1; i <= 80; i++)
                    cells[i] = (999999);
                k = 1;
            }
        }

        private void уловыDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            key = "";
        }

        private void уловыDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }
      //  string sql = "SELECT        CathID, SamplID, DD, MM, YYYY, Region, Area, Location, Latitude, Longitude, Depth, WaterTemperature, Gear, Vessel, Catch, DateOfProc, Condition, LengthRange, Mode, MeanLength, [Number of ind], [WetWeight, g], [MeanWW, g], MeanDW, [Mean_TL %], [Calculated_TL %], SizeClasses, DW_Samples, TL_Samples, DW_Ind, TL_Ind, BioAnalyses_Ind, Comments, DataSource, DataFile FROM Уловы WHERE(DD = ?) OR(MM = ?) OR(YYYY = ?)";
        private void датеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrsYL subform = new FiltrsYL(this);
            subform.Show();
          //  this.уловыTableAdapter.Adapter.SelectCommand.CommandText = sql;
        }

        private void fillByDateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
          //      this.уловыTableAdapter.FillByDate(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(dDToolStripTextBox.Text, typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(mMToolStripTextBox.Text, typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(yYYYToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void dDToolStripTextBox_Click(object sender, EventArgs e)
        {
          
        }

        private void биологическийАнализToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BA subform = new BA(this);
            subform.Show();
        }

        private void fiillMMBEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.уловыTableAdapter.FiillMMBE(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(mMToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillMMMEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.уловыTableAdapter.FillMMME(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(mMToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillMMEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.уловыTableAdapter.FillMME(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(mMToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillDDBEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.уловыTableAdapter.FillDDBE(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(yYYYToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillDDMEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.уловыTableAdapter.FillDDME(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(yYYYToolStripTextBox1.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillDDEToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            //    this.уловыTableAdapter.FillDDE(this.тестовая_бд_DataSet.Уловы, new System.Nullable<short>(((short)(System.Convert.ChangeType(yYYYToolStripTextBox2.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void отключитьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.уловыTableAdapter.FillBy(this.тестовая_бд_DataSet.Уловы, Convert.ToString(mainform.indt[mainform.idnt]));
            menuStrip1.BackColor = Color.FromArgb(235, 231, 202);
        }

        private void регионуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrYLR subform = new FiltrYLR(this);
            subform.Show();
        }

        private void fillRegAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
          //      this.уловыTableAdapter.FillRegAll(this.тестовая_бд_DataSet.Уловы, regionToolStripTextBox.Text, areaToolStripTextBox.Text, locationToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillRegAllToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cells[0] = "%";
            Proby subform = new Proby(this);
            subform.Show();
            
        }

        private void открытьВсеУловыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cells[0] = "%";
            BA subform = new BA(this);
            subform.Show();

        }
    }
    }

