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
        //----------------------------------------------������� ���������� ------------------------------------------------------//
        public ArrayList zapis = new ArrayList();
        public ArrayList orig = new ArrayList();
        String data;
        String dd, mm, gg;
        public string operation;
        idntf ogr = new idntf();
        string file = "IDNTFParams.dat";
        ArrayList pars;
        //-------------------------------------------����� ������� ���������� ---------------------------------------------------//
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

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("��� ������� �������� ������, ��������� ��� ����.   ������� ������: " + ex.Message, "������ �������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox8.Visible == false) { groupBox8.Visible = true; }
            else { groupBox8.Visible = false; }
        }
        string idnt ;
        private void Sample_Record_Form_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(zapis[0]); //�� �����
            textBox2.Text = Convert.ToString(zapis[1]);// �� ������
            textBox5.Text = Convert.ToString(zapis[2]);//���������� �����
            textBox9.Text = Convert.ToString(zapis[3]); //������� ����� 
            textBox3.Text = Convert.ToString(zapis[4]); //����������� ������
            textBox4.Text = Convert.ToString(zapis[5]); //������������ ������
            textBox7.Text = Convert.ToString(zapis[6]); //���������� ���
            textBox6.Text = Convert.ToString(zapis[7]); //����� ����
            textBox8.Text = Convert.ToString(zapis[8]); //������� ����� ����
            textBox13.Text = Convert.ToString(zapis[9]); //����� �����
            textBox14.Text = Convert.ToString(zapis[10]); //��� �����
            textBox15.Text = Convert.ToString(zapis[11]); //����� ����� ����� � ��������
            textBox17.Text = Convert.ToString(zapis[12]); //����� �������
            textBox16.Text = Convert.ToString(zapis[13]); //����� ����� ����� � �������� 
            textBox18.Text = Convert.ToString(zapis[14]);  //����� ����� �������
            textBox11.Text = Convert.ToString(zapis[15]); //���������� ��
            textBox10.Text = Convert.ToString(zapis[16]); //���������� �������
            textBox12.Text = Convert.ToString(zapis[17]); //���������� ������� ���������
            richTextBox1.Text = Convert.ToString(zapis[18]); //����������� 
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
                MessageBox.Show("��� �������� ����� ��������� ������ �������� ������������ �����������, ����������� �� ����� ���������� ������. ��� ������: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           