using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etc cc = new Etc();

            cc.a = 2;
            cc.aa();

            Etc dd = new Etc();

            dd.b= 3;
            dd.bb();
        }
    }
}
