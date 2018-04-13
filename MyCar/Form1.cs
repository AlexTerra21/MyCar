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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fuelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fuelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myCarDataSet);

        }

        private void fuelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fuelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myCarDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet1.Fuel". При необходимости она может быть перемещена или удалена.
            this.fuelTableAdapter.Fill(this.myCarDataSet1.Fuel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MonthYear". При необходимости она может быть перемещена или удалена.
            this.monthYearTableAdapter.Fill(this.myCarDataSet.MonthYear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.Fuel". При необходимости она может быть перемещена или удалена.
            this.fuelTableAdapter.Fill(this.myCarDataSet.Fuel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow SelectedRow = ((DataRowView)cbFilterMonthYear.SelectedItem).Row;
            MessageBox.Show(String.Format("{0} {1}", SelectedRow["Month"],SelectedRow["Year"]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
