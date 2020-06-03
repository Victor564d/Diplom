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
    public partial class SettingsIDNTF : Form
    {
        ArrayList idntfs = new ArrayList();
        string[] zapis = new  string[20];
        Vibor mainform;
       
 
        public SettingsIDNTF(Vibor mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void SettingsIDNTF_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(mainform.listBox1.Items);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
    public class idntf
    {
      public string idnt(string idnt) {
        return idnt ;
        } //класс надо переписать, добавить все переменные и пусть он возвращает их (https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/class)
    }
}

