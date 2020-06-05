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
    public partial class BA : Form
    {
        Hamsa mainform;
        public BA(Hamsa mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
        public ArrayList cells;
        private void бАBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бАBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

        }
        ArrayList erlli = new ArrayList();
        ArrayList erll = new ArrayList();
        private void BA_Load(object sender, EventArgs e)
        {
            cells = mainform.cells;
            tableAdapterManager.Connection.ConnectionString = mainform.Conn;


            try
            {
                this.бАTableAdapter.FillBy(this.тестовая_бд_DataSet.БА,
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
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Convert.ToString(mainform.cells.Count), "Ошибка");
            }

        }

        private void BA_Resize(object sender, EventArgs e)
        {
            бАDataGridView.Width = this.Width - 10;
            бАDataGridView.Height = this.Height - 100;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void бАDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public string Error = "";
        public bool bl = false;
        
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
                        if (lines[5] == null) lines[5] = -999;
                        if (lines[3] == null) lines[3] = -999;
                        if (lines[4] == null) lines[4] = -999;
                        if (lines[6] == null) lines[6] = -999;
                        if (lines[7] == null) lines[7] = -999;
                        if (lines[8] == null) lines[8] = -999;
                        if (lines[10] == null) lines[10] = -999;
                        if (lines[11] == null) lines[11] = -999;
                        if (lines[12] == null) lines[12] = -999;
                        if (lines[14] == null) lines[14] = -999;
                        if (lines[15] == null) lines[15] = -999;
                        if (lines[1] == null) lines[1] = -999;
                        if (lines[13] == null) lines[13] = -999;
                        if (lines[17] == null) lines[17] = -999;
                        if (lines[18] == null) lines[18] = -999;
                        if (lines[19] == null) lines[19] = -999;
                        if (lines[20] == null) lines[20] = -999;
                        if (lines[21] == null) lines[21] = -999;
                        if (lines[22] == null) lines[22] = -999;
                        if (lines[23] == null) lines[23] = -999;
                        if (lines[24] == null) lines[24] = -999;


                    }
                    catch
                    { }
                    try
                    {
                       бАTableAdapter.Insert(Convert.ToString(lines[0]),
                                                 Convert.ToString(lines[1]),
                                                 Convert.ToInt16(lines[2]),
                                                 Convert.ToInt16(lines[3]),
                                                 Convert.ToInt16(lines[4]),
                                                 Convert.ToDecimal(lines[5]),
                                                 Convert.ToDecimal(lines[6]),
                                                 Convert.ToDecimal(lines[7]),
                                                 Convert.ToDecimal(lines[8]),
                                                 Convert.ToString(lines[9]),
                                                 Convert.ToInt16(lines[10]),
                                                 Convert.ToInt16(lines[11]),
                                                 Convert.ToString(lines[12]),
                                                 Convert.ToDecimal(lines[13]),
                                                 Convert.ToDecimal(lines[14]),
                                                 Convert.ToDecimal(lines[15]),
                                                 Convert.ToString(lines[16]),
                                                 Convert.ToDouble(lines[17]),
                                                 Convert.ToDouble(lines[18]),
                                                 Convert.ToDouble(lines[19]),
                                                 Convert.ToDouble(lines[20]),
                                                 Convert.ToDouble(lines[21]),
                                                 Convert.ToDouble(lines[22]),
                                                 Convert.ToDouble(lines[23]),
                                                 Convert.ToDouble(lines[24]),
                                                 Convert.ToString(lines[25])
                                                 );
                    //ТУУУУУУУУУУУУУУУУУУТТТТ гдееееееее-то косяк, я хз в чем ошибка , не работает загрузка в бд всего , ошибка в типах данных. при этом , сама ошибка не отображается тут и сейчас , как это фиксить - я хз (
                    //Вотс , исправить ее я так и не смог 
                   //ошибка возникает только с импортом в старую базу , при импорте в текущую базу , все работает нормально (в базу которая БДРЫБА, лежит в этой же папке )
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        erll.Add("Ошибка записи в поле " + Convert.ToString(li) + ", RecordlID = \"" + lines[1] + "\"" + " исходная строка : \n");
                        erlli.Add("{" + ll + "}");

                       // Error = Error + "Ошибка записи в поле " + Convert.ToString(li) + ", ID Пробы = \"" + lines[1] + "\"" + "\n";
                        bl = true;
                    }
                    if (bl != true) this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);

                    lines.Clear();
                    str = "";
                }sr.Close();
            }
            if (bl == true)
            {
                string sl = DateTime.Now.ToString("dd.MM.yy HH_mm_ss");
                string patch = "Ошибки импорта/Ошибки импорта  " + sl + ".csv";
                System.Windows.Forms.MessageBox.Show("При импорте произошла ошибка. Для более подробной информации произведите анализ файла  \"" + patch + "\" в анализаторе ошибок ", "Список строк с ошибками");
                using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Ошибка импорта в таблицу ^БА^ . Ошибочные строки :");
                    for (int i = 0; i < erll.Count; i++)
                    {
                        sw.WriteLine(erll[i]);
                        sw.WriteLine(erlli[i]);
                    }

                    sw.Close();
                }
                bl = false;
            }
            else
            {
                try
                {
                    if (bl != true) this.tableAdapterManager.UpdateAll(this.тестовая_бд_DataSet);
                    //this.пробыTableAdapter.Svaz(this.тестовая_бд_DataSet.Пробы, Convert.ToString(mainform.уловыDataGridView[0, mainform.уловыDataGridView.CurrentCell.RowIndex].Value));
                    this.бАTableAdapter.FillBy(this.тестовая_бд_DataSet.БА,
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
                            for (int i = 0; i < бАDataGridView.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j <= 25; j++)
                                {

                                    {
                                        if ((Convert.ToString(бАDataGridView[j, i].Value) != "") && ((Convert.ToString(бАDataGridView[j, i].Value) != "-999")))
                                            sw.Write(Convert.ToString(бАDataGridView[j, i].Value));
                                        else sw.Write(Convert.ToString(null));
                                        sw.Write(";");
                                        if (j == 25)
                                        {
                                            sw.Write(" ;");
                                        }

                                    }

                                }
                                sw.WriteLine("");
                            } sw.Close();
                        } 
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void фильтрПоTLFLSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltBA subform = new FiltBA(this);
            subform.Show();
        }

        private void отключитьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            menuStrip1.BackColor = Color.FromArgb(235, 231, 202);
            try
            {
                this.бАTableAdapter.FillBy(this.тестовая_бд_DataSet.БА,
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
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка");
            } 
        }

        private void фильтрпПоПолувозрастугенерацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrBAPGS subform = new FiltrBAPGS(this);
            subform.Show();
        }

        private void настройкиОтображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOOBR subform = new BAOOBR(this);
            subform.Show();
                
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
