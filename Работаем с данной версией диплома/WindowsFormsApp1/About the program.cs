using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class About_the_program : Form
    {
        Vibor mainform;
        public About_the_program(Vibor mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void About_the_program_Load(object sender, EventArgs e)
        {

        }

        private void About_the_program_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Dispose();
        }
    }
}
