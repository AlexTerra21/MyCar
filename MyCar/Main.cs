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
    public partial class Main : Form
    {
        /// <summary>
        /// Флаг показывающий, что строка находится в режиме редактирования
        /// </summary>
        Boolean mOnEditRow = false;

        public Main()
        {
            InitializeComponent();
            this.mountlyReportBindingSource.Sort = "Год,Месяц";
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MountlyReport". При необходимости она может быть перемещена или удалена.
            this.mountlyReportTableAdapter.Fill(this.myCarDataSet.MountlyReport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MountlyReport". При необходимости она может быть перемещена или удалена.
            this.mountlyReportTableAdapter.Fill(this.myCarDataSet.MountlyReport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.MonthYear". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myCarDataSet.Fuel". При необходимости она может быть перемещена или удалена.
            this.fuelTableAdapter.Fill(this.myCarDataSet.Fuel);

        }


        private void UpdateNow()
        {
            String lFilter = fuelBindingSource.Filter;
            this.fuelTableAdapter.Update(myCarDataSet);
            this.mountlyReportTableAdapter.Fill(this.myCarDataSet.MountlyReport);
            this.fuelTableAdapter.Fill(this.myCarDataSet.Fuel);
            fuelBindingSource.Filter = lFilter;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void cbFilterMonthYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow SelectedRow = ((DataRowView)cbFilterMonthYear.SelectedItem).Row;
            Int32 lYear = Int32.Parse(SelectedRow["Год"].ToString());
            Int32 lMonth = Int32.Parse(SelectedRow["Месяц"].ToString());
            if (lYear == 0)
            {
                fuelBindingSource.Filter = "";
                return;
            }
            DateTime lDateBegin = new DateTime(lYear, lMonth, 1);
            DateTime lDateEnd = new DateTime(lYear, lMonth, DateTime.DaysInMonth(lYear, lMonth));
            fuelBindingSource.Filter = String.Format("DateFilling >= '{0:yyyy-MM-dd}' AND DateFilling <= '{1:yyyy-MM-dd}'", lDateBegin, lDateEnd);
        }


        private void fuelDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mOnEditRow)
            {
                mOnEditRow = false;
                this.fuelDataGridView.ReadOnly = true;
                this.fuelBindingSource.EndEdit();
                UpdateNow();
            }

        }


        private void btEditRow_Click(object sender, EventArgs e)
        {
            this.fuelDataGridView.ReadOnly = false;
            this.fuelDataGridView.BeginEdit(true);
            mOnEditRow = true;
        }

        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                this.fuelBindingSource.RemoveCurrent();
                this.fuelBindingSource.EndEdit();
                //this.Validate();
                //myCarDataSet.AcceptChanges();
                //this.fuelTableAdapter.DeleteCommand()
                this.fuelTableAdapter.Update(this.myCarDataSet);
                //UpdateNow();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btAddRow_Click(object sender, EventArgs e)
        {
            this.fuelBindingSource.AddNew();

            DataRowView lCurrentRow = fuelBindingSource.Current as DataRowView;
            lCurrentRow["DateFilling"] = DateTime.Today;
            lCurrentRow["Litres"] = 0.0;
            lCurrentRow["PricePerLitre"] = 0.0;
            lCurrentRow["SumFilling"] = 0.0;
            lCurrentRow["Distance"] = 0.0;
            lCurrentRow["Odometr"] = 0.0;

            this.fuelDataGridView.ReadOnly = false;
            this.fuelDataGridView.BeginEdit(true);
            mOnEditRow = true;
        }

      
        private void btReport_Click(object sender, EventArgs e)
        {
            Report lForm = new Report();
            lForm.Show();
        }
    }

    public class FuelRecord
    {
        Int32 Id { get; set; }
        DateTime DateFilling { get; set; }
        Double Litres { get; set; }
        Double PricePerLitre { get; set; }
        Double SumFilling { get; set; }
        Double Distance { get; set; }
        Double Odometr { get; set; }

        public FuelRecord()
        {
            Id = 0;
            DateFilling = DateTime.Now;
            Litres = 0.0;
            PricePerLitre = 0.0;
            SumFilling = 0.0;
            Distance = 0.0;
            Odometr = 0.0;
        }
    }
}
