using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
