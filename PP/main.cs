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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auth form = new auth();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            аптека form = new аптека();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            школа_1 form = new школа_1();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            школа_2 form = new школа_2();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            мясокомбинат form = new мясокомбинат();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
