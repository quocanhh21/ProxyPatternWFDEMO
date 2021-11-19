using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPatternWFDEMO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject subject = null;
            if(comboBox1.SelectedIndex==0)
            {
                subject = new TOan();
            }    
            else
            {
                subject = new Van();

            }
            Subject proxy = new Proxy(subject);
            richTextBox1.Text += proxy.DoSomeWork();
        }
    }
}
