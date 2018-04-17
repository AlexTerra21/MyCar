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
            monthYearBindingSource.Sort = " Year,Month";
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MonthYear". При необходимости она может быть перемещена или удалена.
            this.monthYearTableAdapter.Fill(this.myCarDataSet.MonthYear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.Fuel". При необходимости она может быть перемещена или удалена.
            this.fuelTableAdapter.Fill(this.myCarDataSet.Fuel);

        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            DataRow SelectedRow = ((DataRowView)cbFilterMonthYear.SelectedItem).Row;
            Int32 lYear = Int32.Parse(SelectedRow["Year"].ToString());
            Int32 lMonth = Int32.Parse(SelectedRow["Month"].ToString());
            if (lYear == 0)
            {
                fuelBindingSource.Filter = "";
                return;
            }
            DateTime lDateBegin = new DateTime(lYear, lMonth, 1);
            DateTime lDateEnd = new DateTime(lYear, lMonth, DateTime.DaysInMonth(lYear,lMonth));


            fuelBindingSource.Filter = String.Format("DateFilling >= '{0:yyyy-MM-dd}' AND DateFilling <= '{1:yyyy-MM-dd}'", lDateBegin, lDateEnd);
            //"DateFilling >= '20180101' "; //+ d.ToShortDateString();
            
            //MessageBox.Show(String.Format("{0} {1}", SelectedRow["Month"], SelectedRow["Year"]));
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
