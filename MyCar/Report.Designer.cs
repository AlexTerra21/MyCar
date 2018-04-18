namespace MyCar
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myCarDataSet = new MyCar.MyCarDataSet();
            this.mountlyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountlyReportTableAdapter = new MyCar.MyCarDataSetTableAdapters.MountlyReportTableAdapter();
            this.tableAdapterManager = new MyCar.MyCarDataSetTableAdapters.TableAdapterManager();
            this.mountlyReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myCarDataSet
            // 
            this.myCarDataSet.DataSetName = "MyCarDataSet";
            this.myCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mountlyReportBindingSource
            // 
            this.mountlyReportBindingSource.DataMember = "MountlyReport";
            this.mountlyReportBindingSource.DataSource = this.myCarDataSet;
            // 
            // mountlyReportTableAdapter
            // 
            this.mountlyReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FuelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyCar.MyCarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mountlyReportDataGridView
            // 
            this.mountlyReportDataGridView.AllowUserToAddRows = false;
            this.mountlyReportDataGridView.AllowUserToDeleteRows = false;
            this.mountlyReportDataGridView.AllowUserToResizeColumns = false;
            this.mountlyReportDataGridView.AllowUserToResizeRows = false;
            this.mountlyReportDataGridView.AutoGenerateColumns = false;
            this.mountlyReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mountlyReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.mountlyReportDataGridView.DataSource = this.mountlyReportBindingSource;
            this.mountlyReportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.mountlyReportDataGridView.Name = "mountlyReportDataGridView";
            this.mountlyReportDataGridView.Size = new System.Drawing.Size(753, 300);
            this.mountlyReportDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MonthYear";
            this.dataGridViewTextBoxColumn1.HeaderText = "Месяц/Год";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Километры";
            this.dataGridViewTextBoxColumn4.HeaderText = "Километры";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Литры";
            this.dataGridViewTextBoxColumn5.HeaderText = "Литры";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Затраты";
            this.dataGridViewTextBoxColumn6.HeaderText = "Затраты";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Средняя цена за литр";
            this.dataGridViewTextBoxColumn7.HeaderText = "Средняя цена за литр";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "л / 100 км";
            this.dataGridViewTextBoxColumn8.HeaderText = "л / 100 км";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "руб / 1 км";
            this.dataGridViewTextBoxColumn9.HeaderText = "руб / 1 км";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(340, 321);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Закрыть";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 356);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.mountlyReportDataGridView);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCarDataSet myCarDataSet;
        private System.Windows.Forms.BindingSource mountlyReportBindingSource;
        private MyCarDataSetTableAdapters.MountlyReportTableAdapter mountlyReportTableAdapter;
        private MyCarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mountlyReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btExit;
    }
}