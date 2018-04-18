namespace MyCar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label литрыLabel;
            System.Windows.Forms.Label затратыLabel;
            System.Windows.Forms.Label средняя_цена_за_литрLabel;
            System.Windows.Forms.Label л___100_кмLabel;
            System.Windows.Forms.Label руб___1_кмLabel;
            this.километрыLabel = new System.Windows.Forms.Label();
            this.fuelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCarDataSet = new MyCar.MyCarDataSet();
            this.btExit = new System.Windows.Forms.Button();
            this.cbFilterMonthYear = new System.Windows.Forms.ComboBox();
            this.mountlyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelTableAdapter = new MyCar.MyCarDataSetTableAdapters.FuelTableAdapter();
            this.tableAdapterManager = new MyCar.MyCarDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddRow = new System.Windows.Forms.Button();
            this.btEditRow = new System.Windows.Forms.Button();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.mountlyReportTableAdapter = new MyCar.MyCarDataSetTableAdapters.MountlyReportTableAdapter();
            this.километрыLabel1 = new System.Windows.Forms.Label();
            this.литрыLabel1 = new System.Windows.Forms.Label();
            this.затратыLabel1 = new System.Windows.Forms.Label();
            this.средняя_цена_за_литрLabel1 = new System.Windows.Forms.Label();
            this.л___100_кмLabel1 = new System.Windows.Forms.Label();
            this.руб___1_кмLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            литрыLabel = new System.Windows.Forms.Label();
            затратыLabel = new System.Windows.Forms.Label();
            средняя_цена_за_литрLabel = new System.Windows.Forms.Label();
            л___100_кмLabel = new System.Windows.Forms.Label();
            руб___1_кмLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // литрыLabel
            // 
            литрыLabel.AutoSize = true;
            литрыLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            литрыLabel.Location = new System.Drawing.Point(223, 0);
            литрыLabel.Name = "литрыLabel";
            литрыLabel.Size = new System.Drawing.Size(59, 24);
            литрыLabel.TabIndex = 9;
            литрыLabel.Text = "Литры:";
            литрыLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // затратыLabel
            // 
            затратыLabel.AutoSize = true;
            затратыLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            затратыLabel.Location = new System.Drawing.Point(381, 0);
            затратыLabel.Name = "затратыLabel";
            затратыLabel.Size = new System.Drawing.Size(58, 24);
            затратыLabel.TabIndex = 10;
            затратыLabel.Text = "Затраты:";
            затратыLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // средняя_цена_за_литрLabel
            // 
            средняя_цена_за_литрLabel.AutoSize = true;
            средняя_цена_за_литрLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            средняя_цена_за_литрLabel.Location = new System.Drawing.Point(3, 24);
            средняя_цена_за_литрLabel.Name = "средняя_цена_за_литрLabel";
            средняя_цена_за_литрLabel.Size = new System.Drawing.Size(121, 24);
            средняя_цена_за_литрLabel.TabIndex = 12;
            средняя_цена_за_литрLabel.Text = "Средняя цена за литр:";
            средняя_цена_за_литрLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // л___100_кмLabel
            // 
            л___100_кмLabel.AutoSize = true;
            л___100_кмLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            л___100_кмLabel.Location = new System.Drawing.Point(223, 24);
            л___100_кмLabel.Name = "л___100_кмLabel";
            л___100_кмLabel.Size = new System.Drawing.Size(59, 24);
            л___100_кмLabel.TabIndex = 14;
            л___100_кмLabel.Text = "л / 100 км";
            л___100_кмLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // руб___1_кмLabel
            // 
            руб___1_кмLabel.AutoSize = true;
            руб___1_кмLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            руб___1_кмLabel.Location = new System.Drawing.Point(381, 24);
            руб___1_кмLabel.Name = "руб___1_кмLabel";
            руб___1_кмLabel.Size = new System.Drawing.Size(58, 24);
            руб___1_кмLabel.TabIndex = 16;
            руб___1_кмLabel.Text = "руб / 1 км";
            руб___1_кмLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // километрыLabel
            // 
            this.километрыLabel.AutoSize = true;
            this.километрыLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.километрыLabel.Location = new System.Drawing.Point(3, 0);
            this.километрыLabel.Name = "километрыLabel";
            this.километрыLabel.Size = new System.Drawing.Size(121, 24);
            this.километрыLabel.TabIndex = 8;
            this.километрыLabel.Text = "Километры:";
            this.километрыLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelDataGridView
            // 
            this.fuelDataGridView.AllowUserToAddRows = false;
            this.fuelDataGridView.AllowUserToDeleteRows = false;
            this.fuelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fuelDataGridView.AutoGenerateColumns = false;
            this.fuelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fuelDataGridView.DataSource = this.fuelBindingSource;
            this.fuelDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.fuelDataGridView.Location = new System.Drawing.Point(12, 12);
            this.fuelDataGridView.MultiSelect = false;
            this.fuelDataGridView.Name = "fuelDataGridView";
            this.fuelDataGridView.ReadOnly = true;
            this.fuelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fuelDataGridView.Size = new System.Drawing.Size(569, 374);
            this.fuelDataGridView.TabIndex = 1;
            this.fuelDataGridView.SelectionChanged += new System.EventHandler(this.fuelDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateFilling";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SumFilling";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма заправки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 107;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Litres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Литры";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PricePerLitre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена за литр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Расстояние";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Odometr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Одометер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "Fuel";
            this.fuelBindingSource.DataSource = this.myCarDataSet;
            // 
            // myCarDataSet
            // 
            this.myCarDataSet.DataSetName = "MyCarDataSet";
            this.myCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Location = new System.Drawing.Point(601, 505);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbFilterMonthYear
            // 
            this.cbFilterMonthYear.DataSource = this.mountlyReportBindingSource;
            this.cbFilterMonthYear.DisplayMember = "MonthYear";
            this.cbFilterMonthYear.FormattingEnabled = true;
            this.cbFilterMonthYear.Location = new System.Drawing.Point(6, 19);
            this.cbFilterMonthYear.Name = "cbFilterMonthYear";
            this.cbFilterMonthYear.Size = new System.Drawing.Size(183, 21);
            this.cbFilterMonthYear.TabIndex = 3;
            this.cbFilterMonthYear.SelectionChangeCommitted += new System.EventHandler(this.cbFilterMonthYear_SelectionChangeCommitted);
            // 
            // mountlyReportBindingSource
            // 
            this.mountlyReportBindingSource.DataMember = "MountlyReport";
            this.mountlyReportBindingSource.DataSource = this.myCarDataSet;
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelTableAdapter = this.fuelTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyCar.MyCarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbFilterMonthYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // btAddRow
            // 
            this.btAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddRow.Location = new System.Drawing.Point(588, 12);
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Size = new System.Drawing.Size(108, 23);
            this.btAddRow.TabIndex = 6;
            this.btAddRow.Text = "Добавить";
            this.btAddRow.UseVisualStyleBackColor = true;
            this.btAddRow.Click += new System.EventHandler(this.btAddRow_Click);
            // 
            // btEditRow
            // 
            this.btEditRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditRow.Location = new System.Drawing.Point(588, 41);
            this.btEditRow.Name = "btEditRow";
            this.btEditRow.Size = new System.Drawing.Size(108, 23);
            this.btEditRow.TabIndex = 7;
            this.btEditRow.Text = "Редактировать";
            this.btEditRow.UseVisualStyleBackColor = true;
            this.btEditRow.Click += new System.EventHandler(this.btEditRow_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteRow.Location = new System.Drawing.Point(588, 70);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(108, 23);
            this.btDeleteRow.TabIndex = 8;
            this.btDeleteRow.Text = "Удалить";
            this.btDeleteRow.UseVisualStyleBackColor = true;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // mountlyReportTableAdapter
            // 
            this.mountlyReportTableAdapter.ClearBeforeFill = true;
            // 
            // километрыLabel1
            // 
            this.километрыLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "Километры", true));
            this.километрыLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.километрыLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.километрыLabel1.Location = new System.Drawing.Point(130, 0);
            this.километрыLabel1.Name = "километрыLabel1";
            this.километрыLabel1.Size = new System.Drawing.Size(87, 24);
            this.километрыLabel1.TabIndex = 9;
            this.километрыLabel1.Text = "label1";
            this.километрыLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // литрыLabel1
            // 
            this.литрыLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "Литры", true));
            this.литрыLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.литрыLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.литрыLabel1.Location = new System.Drawing.Point(288, 0);
            this.литрыLabel1.Name = "литрыLabel1";
            this.литрыLabel1.Size = new System.Drawing.Size(87, 24);
            this.литрыLabel1.TabIndex = 10;
            this.литрыLabel1.Text = "label1";
            this.литрыLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // затратыLabel1
            // 
            this.затратыLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "Затраты", true));
            this.затратыLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.затратыLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.затратыLabel1.Location = new System.Drawing.Point(445, 0);
            this.затратыLabel1.Name = "затратыLabel1";
            this.затратыLabel1.Size = new System.Drawing.Size(115, 24);
            this.затратыLabel1.TabIndex = 11;
            this.затратыLabel1.Text = "label1";
            this.затратыLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // средняя_цена_за_литрLabel1
            // 
            this.средняя_цена_за_литрLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "Средняя цена за литр", true));
            this.средняя_цена_за_литрLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.средняя_цена_за_литрLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.средняя_цена_за_литрLabel1.Location = new System.Drawing.Point(130, 24);
            this.средняя_цена_за_литрLabel1.Name = "средняя_цена_за_литрLabel1";
            this.средняя_цена_за_литрLabel1.Size = new System.Drawing.Size(87, 24);
            this.средняя_цена_за_литрLabel1.TabIndex = 13;
            this.средняя_цена_за_литрLabel1.Text = "label1";
            this.средняя_цена_за_литрLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // л___100_кмLabel1
            // 
            this.л___100_кмLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "л / 100 км", true));
            this.л___100_кмLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.л___100_кмLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.л___100_кмLabel1.Location = new System.Drawing.Point(288, 24);
            this.л___100_кмLabel1.Name = "л___100_кмLabel1";
            this.л___100_кмLabel1.Size = new System.Drawing.Size(87, 24);
            this.л___100_кмLabel1.TabIndex = 15;
            this.л___100_кмLabel1.Text = "label1";
            this.л___100_кмLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // руб___1_кмLabel1
            // 
            this.руб___1_кмLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mountlyReportBindingSource, "руб / 1 км", true));
            this.руб___1_кмLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.руб___1_кмLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.руб___1_кмLabel1.Location = new System.Drawing.Point(445, 24);
            this.руб___1_кмLabel1.Name = "руб___1_кмLabel1";
            this.руб___1_кмLabel1.Size = new System.Drawing.Size(115, 24);
            this.руб___1_кмLabel1.TabIndex = 17;
            this.руб___1_кмLabel1.Text = "label1";
            this.руб___1_кмLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.километрыLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.руб___1_кмLabel1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(руб___1_кмLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.километрыLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(литрыLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.л___100_кмLabel1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(л___100_кмLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.литрыLabel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(затратыLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.средняя_цена_за_литрLabel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(средняя_цена_за_литрLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.затратыLabel1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 48);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Общие данные за выбраный период";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btDeleteRow);
            this.Controls.Add(this.btEditRow);
            this.Controls.Add(this.btAddRow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.fuelDataGridView);
            this.MinimumSize = new System.Drawing.Size(580, 436);
            this.Name = "Form1";
            this.Text = "Учет топлива";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountlyReportBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCarDataSet myCarDataSet;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private MyCarDataSetTableAdapters.FuelTableAdapter fuelTableAdapter;
        private MyCarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fuelDataGridView;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbFilterMonthYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddRow;
        private System.Windows.Forms.Button btEditRow;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource mountlyReportBindingSource;
        private MyCarDataSetTableAdapters.MountlyReportTableAdapter mountlyReportTableAdapter;
        private System.Windows.Forms.Label километрыLabel1;
        private System.Windows.Forms.Label литрыLabel1;
        private System.Windows.Forms.Label затратыLabel1;
        private System.Windows.Forms.Label средняя_цена_за_литрLabel1;
        private System.Windows.Forms.Label л___100_кмLabel1;
        private System.Windows.Forms.Label руб___1_кмLabel1;
        private System.Windows.Forms.Label километрыLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

