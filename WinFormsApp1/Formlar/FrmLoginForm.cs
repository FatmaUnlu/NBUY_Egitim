using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Crm_Form.Formlar
{
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "admin" && textBox2.Text=="123")
            {
                MessageBox.Show("hoşheldin admin");
                Form1 anaForm = new Form1(); //messageboxta tıklama yapıca ekrana form1 gelir.
                anaForm.Show();
                this.Hide();
            }
        }
    }
}
