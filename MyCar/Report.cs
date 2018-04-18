using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MountlyReport". При необходимости она может быть перемещена или удалена.
            this.mountlyReportTableAdapter.Fill(this.myCarDataSet.MountlyReport);
            this.mountlyReportBindingSource.Sort = "Год,Месяц";

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
