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
    public partial class pcsale : MaterialForm
    {
        public pcsale()
        {
            InitializeComponent();
        }

        private void pcsale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.pcsale". При необходимости она может быть перемещена или удалена.
            this.pcsaleTableAdapter.Fill(this.database1DataSet1.pcsale);

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
