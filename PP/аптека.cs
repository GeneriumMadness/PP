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
    public partial class аптека : Form
    {
        public аптека()
        {
            InitializeComponent();
        }

        private void аптека_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.аптека". При необходимости она может быть перемещена или удалена.
            this.аптекаTableAdapter.Fill(this.database1DataSet.аптека);
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
