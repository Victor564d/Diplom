namespace WindowsFormsApp1
{
    partial class ErrAnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrAnal));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OpFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.пробыDataGridView = new System.Windows.Forms.DataGridView();
            this.уловыDataGridView = new System.Windows.Forms.DataGridView();
            this.уловыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пробыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бАDataGridView = new System.Windows.Forms.DataGridView();
            this.бАTableAdapter = new WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters.БАTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters.TableAdapterManager();
            this.пробыTableAdapter = new WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters.ПробыTableAdapter();
            this.уловыTableAdapter = new WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters.УловыTableAdapter();
            this.тестовая_бд_DataSet = new WindowsFormsApp1.Тестовая_бд_DataSet();
            this.cathIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samplIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yYYYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetWeightGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanWWGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanDWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeClassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWSamplesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLSamplesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bioAnalysesIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetWeighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanWWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxWeightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLWWDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedTL2017DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetWeightgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLWWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedTL2015DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.пробыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уловыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уловыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пробыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бАDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тестовая_бд_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бАBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1067, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // OpFile
            // 
            this.OpFile.FileName = "openFileDialog1";
            this.OpFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpFile_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1067, 322);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Обрабатываемый файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Откройте файл.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Запустить анализ ошибок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Текущая обрабатываемая строка :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Работа с таблицей :";
            // 
            // пробыDataGridView
            // 
            this.пробыDataGridView.AllowUserToDeleteRows = false;
            this.пробыDataGridView.AutoGenerateColumns = false;
            this.пробыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пробыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleIDDataGridViewTextBoxColumn1,
            this.recordIDDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn1,
            this.midSizeDataGridViewTextBoxColumn,
            this.size1DataGridViewTextBoxColumn1,
            this.size2DataGridViewTextBoxColumn1,
            this.fishNumberDataGridViewTextBoxColumn,
            this.wetWeighDataGridViewTextBoxColumn,
            this.meanWWDataGridViewTextBoxColumn,
            this.boxNoDataGridViewTextBoxColumn,
            this.boxWeightDataGridViewTextBoxColumn1,
            this.grossWWDataGridViewTextBoxColumn1,
            this.netWWDataGridViewTextBoxColumn1,
            this.grossDWDataGridViewTextBoxColumn1,
            this.netDWDataGridViewTextBoxColumn1,
            this.dWDataGridViewTextBoxColumn1,
            this.tLWWDataGridViewTextBoxColumn1,
            this.calculatedTL2017DataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn2});
            this.пробыDataGridView.DataSource = this.пробыBindingSource;
            this.пробыDataGridView.Location = new System.Drawing.Point(295, 95);
            this.пробыDataGridView.Name = "пробыDataGridView";
            this.пробыDataGridView.ReadOnly = true;
            this.пробыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.пробыDataGridView.TabIndex = 12;
            this.пробыDataGridView.Visible = false;
            // 
            // уловыDataGridView
            // 
            this.уловыDataGridView.AllowUserToDeleteRows = false;
            this.уловыDataGridView.AutoGenerateColumns = false;
            this.уловыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.уловыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cathIDDataGridViewTextBoxColumn,
            this.samplIDDataGridViewTextBoxColumn,
            this.dDDataGridViewTextBoxColumn,
            this.mMDataGridViewTextBoxColumn,
            this.yYYYDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.waterTemperatureDataGridViewTextBoxColumn,
            this.gearDataGridViewTextBoxColumn,
            this.vesselDataGridViewTextBoxColumn,
            this.catchDataGridViewTextBoxColumn,
            this.dateOfProcDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.lengthRangeDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.meanLengthDataGridViewTextBoxColumn,
            this.numberOfIndDataGridViewTextBoxColumn,
            this.wetWeightGDataGridViewTextBoxColumn1,
            this.meanWWGDataGridViewTextBoxColumn,
            this.meanDWDataGridViewTextBoxColumn,
            this.meanTLDataGridViewTextBoxColumn,
            this.calculatedTLDataGridViewTextBoxColumn,
            this.sizeClassesDataGridViewTextBoxColumn,
            this.dWSamplesDataGridViewTextBoxColumn,
            this.tLSamplesDataGridViewTextBoxColumn,
            this.dWIndDataGridViewTextBoxColumn,
            this.tLIndDataGridViewTextBoxColumn,
            this.bioAnalysesIndDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn1,
            this.dataSourceDataGridViewTextBoxColumn,
            this.dataFileDataGridViewTextBoxColumn});
            this.уловыDataGridView.DataSource = this.уловыBindingSource;
            this.уловыDataGridView.Location = new System.Drawing.Point(799, 112);
            this.уловыDataGridView.Name = "уловыDataGridView";
            this.уловыDataGridView.ReadOnly = true;
            this.уловыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.уловыDataGridView.TabIndex = 12;
            this.уловыDataGridView.Visible = false;
            // 
            // уловыBindingSource
            // 
            this.уловыBindingSource.DataMember = "Уловы";
            this.уловыBindingSource.DataSource = this.тестовая_бд_DataSet;
            // 
            // пробыBindingSource
            // 
            this.пробыBindingSource.DataMember = "Пробы";
            this.пробыBindingSource.DataSource = this.тестовая_бд_DataSet;
            // 
            // бАDataGridView
            // 
            this.бАDataGridView.AllowUserToDeleteRows = false;
            this.бАDataGridView.AutoGenerateColumns = false;
            this.бАDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.бАDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.бАDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.бАDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleIDDataGridViewTextBoxColumn,
            this.indIDDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.size1DataGridViewTextBoxColumn,
            this.size2DataGridViewTextBoxColumn,
            this.tLDataGridViewTextBoxColumn,
            this.fLDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.wetWeightgDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.fatnessDataGridViewTextBoxColumn,
            this.cFDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.corrAgeDataGridViewTextBoxColumn,
            this.generationDataGridViewTextBoxColumn,
            this.boxNumberDataGridViewTextBoxColumn,
            this.boxWeightDataGridViewTextBoxColumn,
            this.grossWWDataGridViewTextBoxColumn,
            this.netWWDataGridViewTextBoxColumn,
            this.grossDWDataGridViewTextBoxColumn,
            this.netDWDataGridViewTextBoxColumn,
            this.dWDataGridViewTextBoxColumn,
            this.tLWWDataGridViewTextBoxColumn,
            this.calculatedTL2015DataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.бАDataGridView.DataSource = this.бАBindingSource;
            this.бАDataGridView.Location = new System.Drawing.Point(203, 59);
            this.бАDataGridView.Name = "бАDataGridView";
            this.бАDataGridView.ReadOnly = true;
            this.бАDataGridView.Size = new System.Drawing.Size(618, 324);
            this.бАDataGridView.TabIndex = 13;
            this.бАDataGridView.Visible = false;
            // 
            // бАTableAdapter
            // 
            this.бАTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БАTableAdapter = this.бАTableAdapter;
            this.tableAdapterManager.ПробыTableAdapter = this.пробыTableAdapter;
            this.tableAdapterManager.УловыTableAdapter = this.уловыTableAdapter;
            // 
            // пробыTableAdapter
            // 
            this.пробыTableAdapter.ClearBeforeFill = true;
            // 
            // уловыTableAdapter
            // 
            this.уловыTableAdapter.ClearBeforeFill = true;
            // 
            // тестовая_бд_DataSet
            // 
            this.тестовая_бд_DataSet.DataSetName = "Тестовая_бд_DataSet";
            this.тестовая_бд_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cathIDDataGridViewTextBoxColumn
            // 
            this.cathIDDataGridViewTextBoxColumn.DataPropertyName = "CathID";
            this.cathIDDataGridViewTextBoxColumn.HeaderText = "CathID";
            this.cathIDDataGridViewTextBoxColumn.Name = "cathIDDataGridViewTextBoxColumn";
            this.cathIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // samplIDDataGridViewTextBoxColumn
            // 
            this.samplIDDataGridViewTextBoxColumn.DataPropertyName = "SamplID";
            this.samplIDDataGridViewTextBoxColumn.HeaderText = "SamplID";
            this.samplIDDataGridViewTextBoxColumn.Name = "samplIDDataGridViewTextBoxColumn";
            this.samplIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDDataGridViewTextBoxColumn
            // 
            this.dDDataGridViewTextBoxColumn.DataPropertyName = "DD";
            this.dDDataGridViewTextBoxColumn.HeaderText = "DD";
            this.dDDataGridViewTextBoxColumn.Name = "dDDataGridViewTextBoxColumn";
            this.dDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mMDataGridViewTextBoxColumn
            // 
            this.mMDataGridViewTextBoxColumn.DataPropertyName = "MM";
            this.mMDataGridViewTextBoxColumn.HeaderText = "MM";
            this.mMDataGridViewTextBoxColumn.Name = "mMDataGridViewTextBoxColumn";
            this.mMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yYYYDataGridViewTextBoxColumn
            // 
            this.yYYYDataGridViewTextBoxColumn.DataPropertyName = "YYYY";
            this.yYYYDataGridViewTextBoxColumn.HeaderText = "YYYY";
            this.yYYYDataGridViewTextBoxColumn.Name = "yYYYDataGridViewTextBoxColumn";
            this.yYYYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waterTemperatureDataGridViewTextBoxColumn
            // 
            this.waterTemperatureDataGridViewTextBoxColumn.DataPropertyName = "WaterTemperature";
            this.waterTemperatureDataGridViewTextBoxColumn.HeaderText = "WaterTemperature";
            this.waterTemperatureDataGridViewTextBoxColumn.Name = "waterTemperatureDataGridViewTextBoxColumn";
            this.waterTemperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gearDataGridViewTextBoxColumn
            // 
            this.gearDataGridViewTextBoxColumn.DataPropertyName = "Gear";
            this.gearDataGridViewTextBoxColumn.HeaderText = "Gear";
            this.gearDataGridViewTextBoxColumn.Name = "gearDataGridViewTextBoxColumn";
            this.gearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vesselDataGridViewTextBoxColumn
            // 
            this.vesselDataGridViewTextBoxColumn.DataPropertyName = "Vessel";
            this.vesselDataGridViewTextBoxColumn.HeaderText = "Vessel";
            this.vesselDataGridViewTextBoxColumn.Name = "vesselDataGridViewTextBoxColumn";
            this.vesselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catchDataGridViewTextBoxColumn
            // 
            this.catchDataGridViewTextBoxColumn.DataPropertyName = "Catch";
            this.catchDataGridViewTextBoxColumn.HeaderText = "Catch";
            this.catchDataGridViewTextBoxColumn.Name = "catchDataGridViewTextBoxColumn";
            this.catchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfProcDataGridViewTextBoxColumn
            // 
            this.dateOfProcDataGridViewTextBoxColumn.DataPropertyName = "DateOfProc";
            this.dateOfProcDataGridViewTextBoxColumn.HeaderText = "DateOfProc";
            this.dateOfProcDataGridViewTextBoxColumn.Name = "dateOfProcDataGridViewTextBoxColumn";
            this.dateOfProcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthRangeDataGridViewTextBoxColumn
            // 
            this.lengthRangeDataGridViewTextBoxColumn.DataPropertyName = "LengthRange";
            this.lengthRangeDataGridViewTextBoxColumn.HeaderText = "LengthRange";
            this.lengthRangeDataGridViewTextBoxColumn.Name = "lengthRangeDataGridViewTextBoxColumn";
            this.lengthRangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meanLengthDataGridViewTextBoxColumn
            // 
            this.meanLengthDataGridViewTextBoxColumn.DataPropertyName = "MeanLength";
            this.meanLengthDataGridViewTextBoxColumn.HeaderText = "MeanLength";
            this.meanLengthDataGridViewTextBoxColumn.Name = "meanLengthDataGridViewTextBoxColumn";
            this.meanLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfIndDataGridViewTextBoxColumn
            // 
            this.numberOfIndDataGridViewTextBoxColumn.DataPropertyName = "Number of ind";
            this.numberOfIndDataGridViewTextBoxColumn.HeaderText = "Number of ind";
            this.numberOfIndDataGridViewTextBoxColumn.Name = "numberOfIndDataGridViewTextBoxColumn";
            this.numberOfIndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wetWeightGDataGridViewTextBoxColumn1
            // 
            this.wetWeightGDataGridViewTextBoxColumn1.DataPropertyName = "WetWeight, g";
            this.wetWeightGDataGridViewTextBoxColumn1.HeaderText = "WetWeight, g";
            this.wetWeightGDataGridViewTextBoxColumn1.Name = "wetWeightGDataGridViewTextBoxColumn1";
            this.wetWeightGDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // meanWWGDataGridViewTextBoxColumn
            // 
            this.meanWWGDataGridViewTextBoxColumn.DataPropertyName = "MeanWW, g";
            this.meanWWGDataGridViewTextBoxColumn.HeaderText = "MeanWW, g";
            this.meanWWGDataGridViewTextBoxColumn.Name = "meanWWGDataGridViewTextBoxColumn";
            this.meanWWGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meanDWDataGridViewTextBoxColumn
            // 
            this.meanDWDataGridViewTextBoxColumn.DataPropertyName = "MeanDW";
            this.meanDWDataGridViewTextBoxColumn.HeaderText = "MeanDW";
            this.meanDWDataGridViewTextBoxColumn.Name = "meanDWDataGridViewTextBoxColumn";
            this.meanDWDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meanTLDataGridViewTextBoxColumn
            // 
            this.meanTLDataGridViewTextBoxColumn.DataPropertyName = "Mean_TL%";
            this.meanTLDataGridViewTextBoxColumn.HeaderText = "Mean_TL%";
            this.meanTLDataGridViewTextBoxColumn.Name = "meanTLDataGridViewTextBoxColumn";
            this.meanTLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculatedTLDataGridViewTextBoxColumn
            // 
            this.calculatedTLDataGridViewTextBoxColumn.DataPropertyName = "Calculated_TL%";
            this.calculatedTLDataGridViewTextBoxColumn.HeaderText = "Calculated_TL%";
            this.calculatedTLDataGridViewTextBoxColumn.Name = "calculatedTLDataGridViewTextBoxColumn";
            this.calculatedTLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeClassesDataGridViewTextBoxColumn
            // 
            this.sizeClassesDataGridViewTextBoxColumn.DataPropertyName = "SizeClasses";
            this.sizeClassesDataGridViewTextBoxColumn.HeaderText = "SizeClasses";
            this.sizeClassesDataGridViewTextBoxColumn.Name = "sizeClassesDataGridViewTextBoxColumn";
            this.sizeClassesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dWSamplesDataGridViewTextBoxColumn
            // 
            this.dWSamplesDataGridViewTextBoxColumn.DataPropertyName = "DW_Samples";
            this.dWSamplesDataGridViewTextBoxColumn.HeaderText = "DW_Samples";
            this.dWSamplesDataGridViewTextBoxColumn.Name = "dWSamplesDataGridViewTextBoxColumn";
            this.dWSamplesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tLSamplesDataGridViewTextBoxColumn
            // 
            this.tLSamplesDataGridViewTextBoxColumn.DataPropertyName = "TL_Samples";
            this.tLSamplesDataGridViewTextBoxColumn.HeaderText = "TL_Samples";
            this.tLSamplesDataGridViewTextBoxColumn.Name = "tLSamplesDataGridViewTextBoxColumn";
            this.tLSamplesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dWIndDataGridViewTextBoxColumn
            // 
            this.dWIndDataGridViewTextBoxColumn.DataPropertyName = "DW_Ind";
            this.dWIndDataGridViewTextBoxColumn.HeaderText = "DW_Ind";
            this.dWIndDataGridViewTextBoxColumn.Name = "dWIndDataGridViewTextBoxColumn";
            this.dWIndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tLIndDataGridViewTextBoxColumn
            // 
            this.tLIndDataGridViewTextBoxColumn.DataPropertyName = "TL_Ind";
            this.tLIndDataGridViewTextBoxColumn.HeaderText = "TL_Ind";
            this.tLIndDataGridViewTextBoxColumn.Name = "tLIndDataGridViewTextBoxColumn";
            this.tLIndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bioAnalysesIndDataGridViewTextBoxColumn
            // 
            this.bioAnalysesIndDataGridViewTextBoxColumn.DataPropertyName = "BioAnalyses_Ind";
            this.bioAnalysesIndDataGridViewTextBoxColumn.HeaderText = "BioAnalyses_Ind";
            this.bioAnalysesIndDataGridViewTextBoxColumn.Name = "bioAnalysesIndDataGridViewTextBoxColumn";
            this.bioAnalysesIndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn1
            // 
            this.commentsDataGridViewTextBoxColumn1.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn1.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn1.Name = "commentsDataGridViewTextBoxColumn1";
            this.commentsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataSourceDataGridViewTextBoxColumn
            // 
            this.dataSourceDataGridViewTextBoxColumn.DataPropertyName = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn.HeaderText = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn.Name = "dataSourceDataGridViewTextBoxColumn";
            this.dataSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFileDataGridViewTextBoxColumn
            // 
            this.dataFileDataGridViewTextBoxColumn.DataPropertyName = "DataFile";
            this.dataFileDataGridViewTextBoxColumn.HeaderText = "DataFile";
            this.dataFileDataGridViewTextBoxColumn.Name = "dataFileDataGridViewTextBoxColumn";
            this.dataFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleIDDataGridViewTextBoxColumn1
            // 
            this.sampleIDDataGridViewTextBoxColumn1.DataPropertyName = "SampleID";
            this.sampleIDDataGridViewTextBoxColumn1.HeaderText = "SampleID";
            this.sampleIDDataGridViewTextBoxColumn1.Name = "sampleIDDataGridViewTextBoxColumn1";
            this.sampleIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noDataGridViewTextBoxColumn1
            // 
            this.noDataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn1.HeaderText = "No";
            this.noDataGridViewTextBoxColumn1.Name = "noDataGridViewTextBoxColumn1";
            this.noDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // midSizeDataGridViewTextBoxColumn
            // 
            this.midSizeDataGridViewTextBoxColumn.DataPropertyName = "MidSize";
            this.midSizeDataGridViewTextBoxColumn.HeaderText = "MidSize";
            this.midSizeDataGridViewTextBoxColumn.Name = "midSizeDataGridViewTextBoxColumn";
            this.midSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // size1DataGridViewTextBoxColumn1
            // 
            this.size1DataGridViewTextBoxColumn1.DataPropertyName = "Size1";
            this.size1DataGridViewTextBoxColumn1.HeaderText = "Size1";
            this.size1DataGridViewTextBoxColumn1.Name = "size1DataGridViewTextBoxColumn1";
            this.size1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // size2DataGridViewTextBoxColumn1
            // 
            this.size2DataGridViewTextBoxColumn1.DataPropertyName = "Size2";
            this.size2DataGridViewTextBoxColumn1.HeaderText = "Size2";
            this.size2DataGridViewTextBoxColumn1.Name = "size2DataGridViewTextBoxColumn1";
            this.size2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fishNumberDataGridViewTextBoxColumn
            // 
            this.fishNumberDataGridViewTextBoxColumn.DataPropertyName = "FishNumber";
            this.fishNumberDataGridViewTextBoxColumn.HeaderText = "FishNumber";
            this.fishNumberDataGridViewTextBoxColumn.Name = "fishNumberDataGridViewTextBoxColumn";
            this.fishNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wetWeighDataGridViewTextBoxColumn
            // 
            this.wetWeighDataGridViewTextBoxColumn.DataPropertyName = "WetWeigh";
            this.wetWeighDataGridViewTextBoxColumn.HeaderText = "WetWeigh";
            this.wetWeighDataGridViewTextBoxColumn.Name = "wetWeighDataGridViewTextBoxColumn";
            this.wetWeighDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meanWWDataGridViewTextBoxColumn
            // 
            this.meanWWDataGridViewTextBoxColumn.DataPropertyName = "MeanWW";
            this.meanWWDataGridViewTextBoxColumn.HeaderText = "MeanWW";
            this.meanWWDataGridViewTextBoxColumn.Name = "meanWWDataGridViewTextBoxColumn";
            this.meanWWDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxNoDataGridViewTextBoxColumn
            // 
            this.boxNoDataGridViewTextBoxColumn.DataPropertyName = "BoxNo";
            this.boxNoDataGridViewTextBoxColumn.HeaderText = "BoxNo";
            this.boxNoDataGridViewTextBoxColumn.Name = "boxNoDataGridViewTextBoxColumn";
            this.boxNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxWeightDataGridViewTextBoxColumn1
            // 
            this.boxWeightDataGridViewTextBoxColumn1.DataPropertyName = "BoxWeight";
            this.boxWeightDataGridViewTextBoxColumn1.HeaderText = "BoxWeight";
            this.boxWeightDataGridViewTextBoxColumn1.Name = "boxWeightDataGridViewTextBoxColumn1";
            this.boxWeightDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // grossWWDataGridViewTextBoxColumn1
            // 
            this.grossWWDataGridViewTextBoxColumn1.DataPropertyName = "GrossWW";
            this.grossWWDataGridViewTextBoxColumn1.HeaderText = "GrossWW";
            this.grossWWDataGridViewTextBoxColumn1.Name = "grossWWDataGridViewTextBoxColumn1";
            this.grossWWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // netWWDataGridViewTextBoxColumn1
            // 
            this.netWWDataGridViewTextBoxColumn1.DataPropertyName = "NetWW";
            this.netWWDataGridViewTextBoxColumn1.HeaderText = "NetWW";
            this.netWWDataGridViewTextBoxColumn1.Name = "netWWDataGridViewTextBoxColumn1";
            this.netWWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // grossDWDataGridViewTextBoxColumn1
            // 
            this.grossDWDataGridViewTextBoxColumn1.DataPropertyName = "GrossDW";
            this.grossDWDataGridViewTextBoxColumn1.HeaderText = "GrossDW";
            this.grossDWDataGridViewTextBoxColumn1.Name = "grossDWDataGridViewTextBoxColumn1";
            this.grossDWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // netDWDataGridViewTextBoxColumn1
            // 
            this.netDWDataGridViewTextBoxColumn1.DataPropertyName = "NetDW";
            this.netDWDataGridViewTextBoxColumn1.HeaderText = "NetDW";
            this.netDWDataGridViewTextBoxColumn1.Name = "netDWDataGridViewTextBoxColumn1";
            this.netDWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dWDataGridViewTextBoxColumn1
            // 
            this.dWDataGridViewTextBoxColumn1.DataPropertyName = "DW%";
            this.dWDataGridViewTextBoxColumn1.HeaderText = "DW%";
            this.dWDataGridViewTextBoxColumn1.Name = "dWDataGridViewTextBoxColumn1";
            this.dWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tLWWDataGridViewTextBoxColumn1
            // 
            this.tLWWDataGridViewTextBoxColumn1.DataPropertyName = "TL%WW";
            this.tLWWDataGridViewTextBoxColumn1.HeaderText = "TL%WW";
            this.tLWWDataGridViewTextBoxColumn1.Name = "tLWWDataGridViewTextBoxColumn1";
            this.tLWWDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // calculatedTL2017DataGridViewTextBoxColumn
            // 
            this.calculatedTL2017DataGridViewTextBoxColumn.DataPropertyName = "Calculated TL% 2017";
            this.calculatedTL2017DataGridViewTextBoxColumn.HeaderText = "Calculated TL% 2017";
            this.calculatedTL2017DataGridViewTextBoxColumn.Name = "calculatedTL2017DataGridViewTextBoxColumn";
            this.calculatedTL2017DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn2
            // 
            this.commentsDataGridViewTextBoxColumn2.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn2.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn2.Name = "commentsDataGridViewTextBoxColumn2";
            this.commentsDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // бАBindingSource
            // 
            this.бАBindingSource.DataMember = "БА";
            this.бАBindingSource.DataSource = this.тестовая_бд_DataSet;
            // 
            // sampleIDDataGridViewTextBoxColumn
            // 
            this.sampleIDDataGridViewTextBoxColumn.DataPropertyName = "SampleID";
            this.sampleIDDataGridViewTextBoxColumn.HeaderText = "SampleID";
            this.sampleIDDataGridViewTextBoxColumn.Name = "sampleIDDataGridViewTextBoxColumn";
            this.sampleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // indIDDataGridViewTextBoxColumn
            // 
            this.indIDDataGridViewTextBoxColumn.DataPropertyName = "IndID";
            this.indIDDataGridViewTextBoxColumn.HeaderText = "IndID";
            this.indIDDataGridViewTextBoxColumn.Name = "indIDDataGridViewTextBoxColumn";
            this.indIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.indIDDataGridViewTextBoxColumn.Width = 58;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 46;
            // 
            // size1DataGridViewTextBoxColumn
            // 
            this.size1DataGridViewTextBoxColumn.DataPropertyName = "Size1";
            this.size1DataGridViewTextBoxColumn.HeaderText = "Size1";
            this.size1DataGridViewTextBoxColumn.Name = "size1DataGridViewTextBoxColumn";
            this.size1DataGridViewTextBoxColumn.ReadOnly = true;
            this.size1DataGridViewTextBoxColumn.Width = 58;
            // 
            // size2DataGridViewTextBoxColumn
            // 
            this.size2DataGridViewTextBoxColumn.DataPropertyName = "Size2";
            this.size2DataGridViewTextBoxColumn.HeaderText = "Size2";
            this.size2DataGridViewTextBoxColumn.Name = "size2DataGridViewTextBoxColumn";
            this.size2DataGridViewTextBoxColumn.ReadOnly = true;
            this.size2DataGridViewTextBoxColumn.Width = 58;
            // 
            // tLDataGridViewTextBoxColumn
            // 
            this.tLDataGridViewTextBoxColumn.DataPropertyName = "TL";
            this.tLDataGridViewTextBoxColumn.HeaderText = "TL";
            this.tLDataGridViewTextBoxColumn.Name = "tLDataGridViewTextBoxColumn";
            this.tLDataGridViewTextBoxColumn.ReadOnly = true;
            this.tLDataGridViewTextBoxColumn.Width = 45;
            // 
            // fLDataGridViewTextBoxColumn
            // 
            this.fLDataGridViewTextBoxColumn.DataPropertyName = "FL";
            this.fLDataGridViewTextBoxColumn.HeaderText = "FL";
            this.fLDataGridViewTextBoxColumn.Name = "fLDataGridViewTextBoxColumn";
            this.fLDataGridViewTextBoxColumn.ReadOnly = true;
            this.fLDataGridViewTextBoxColumn.Width = 44;
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            this.sLDataGridViewTextBoxColumn.ReadOnly = true;
            this.sLDataGridViewTextBoxColumn.Width = 45;
            // 
            // wetWeightgDataGridViewTextBoxColumn
            // 
            this.wetWeightgDataGridViewTextBoxColumn.DataPropertyName = "WetWeight,_g";
            this.wetWeightgDataGridViewTextBoxColumn.HeaderText = "WetWeight,_g";
            this.wetWeightgDataGridViewTextBoxColumn.Name = "wetWeightgDataGridViewTextBoxColumn";
            this.wetWeightgDataGridViewTextBoxColumn.ReadOnly = true;
            this.wetWeightgDataGridViewTextBoxColumn.Width = 101;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 50;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.ReadOnly = true;
            this.stageDataGridViewTextBoxColumn.Width = 60;
            // 
            // fatnessDataGridViewTextBoxColumn
            // 
            this.fatnessDataGridViewTextBoxColumn.DataPropertyName = "Fatness";
            this.fatnessDataGridViewTextBoxColumn.HeaderText = "Fatness";
            this.fatnessDataGridViewTextBoxColumn.Name = "fatnessDataGridViewTextBoxColumn";
            this.fatnessDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatnessDataGridViewTextBoxColumn.Width = 69;
            // 
            // cFDataGridViewTextBoxColumn
            // 
            this.cFDataGridViewTextBoxColumn.DataPropertyName = "CF";
            this.cFDataGridViewTextBoxColumn.HeaderText = "CF";
            this.cFDataGridViewTextBoxColumn.Name = "cFDataGridViewTextBoxColumn";
            this.cFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFDataGridViewTextBoxColumn.Width = 45;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age ";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age ";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 51;
            // 
            // corrAgeDataGridViewTextBoxColumn
            // 
            this.corrAgeDataGridViewTextBoxColumn.DataPropertyName = "Corr# Age";
            this.corrAgeDataGridViewTextBoxColumn.HeaderText = "Corr# Age";
            this.corrAgeDataGridViewTextBoxColumn.Name = "corrAgeDataGridViewTextBoxColumn";
            this.corrAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.corrAgeDataGridViewTextBoxColumn.Width = 80;
            // 
            // generationDataGridViewTextBoxColumn
            // 
            this.generationDataGridViewTextBoxColumn.DataPropertyName = "Generation";
            this.generationDataGridViewTextBoxColumn.HeaderText = "Generation";
            this.generationDataGridViewTextBoxColumn.Name = "generationDataGridViewTextBoxColumn";
            this.generationDataGridViewTextBoxColumn.ReadOnly = true;
            this.generationDataGridViewTextBoxColumn.Width = 84;
            // 
            // boxNumberDataGridViewTextBoxColumn
            // 
            this.boxNumberDataGridViewTextBoxColumn.DataPropertyName = "Box number";
            this.boxNumberDataGridViewTextBoxColumn.HeaderText = "Box number";
            this.boxNumberDataGridViewTextBoxColumn.Name = "boxNumberDataGridViewTextBoxColumn";
            this.boxNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.boxNumberDataGridViewTextBoxColumn.Width = 88;
            // 
            // boxWeightDataGridViewTextBoxColumn
            // 
            this.boxWeightDataGridViewTextBoxColumn.DataPropertyName = "Box weight";
            this.boxWeightDataGridViewTextBoxColumn.HeaderText = "Box weight";
            this.boxWeightDataGridViewTextBoxColumn.Name = "boxWeightDataGridViewTextBoxColumn";
            this.boxWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.boxWeightDataGridViewTextBoxColumn.Width = 84;
            // 
            // grossWWDataGridViewTextBoxColumn
            // 
            this.grossWWDataGridViewTextBoxColumn.DataPropertyName = "Gross WW";
            this.grossWWDataGridViewTextBoxColumn.HeaderText = "Gross WW";
            this.grossWWDataGridViewTextBoxColumn.Name = "grossWWDataGridViewTextBoxColumn";
            this.grossWWDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossWWDataGridViewTextBoxColumn.Width = 84;
            // 
            // netWWDataGridViewTextBoxColumn
            // 
            this.netWWDataGridViewTextBoxColumn.DataPropertyName = "Net WW";
            this.netWWDataGridViewTextBoxColumn.HeaderText = "Net WW";
            this.netWWDataGridViewTextBoxColumn.Name = "netWWDataGridViewTextBoxColumn";
            this.netWWDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWWDataGridViewTextBoxColumn.Width = 74;
            // 
            // grossDWDataGridViewTextBoxColumn
            // 
            this.grossDWDataGridViewTextBoxColumn.DataPropertyName = "Gross DW";
            this.grossDWDataGridViewTextBoxColumn.HeaderText = "Gross DW";
            this.grossDWDataGridViewTextBoxColumn.Name = "grossDWDataGridViewTextBoxColumn";
            this.grossDWDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossDWDataGridViewTextBoxColumn.Width = 81;
            // 
            // netDWDataGridViewTextBoxColumn
            // 
            this.netDWDataGridViewTextBoxColumn.DataPropertyName = "Net DW";
            this.netDWDataGridViewTextBoxColumn.HeaderText = "Net DW";
            this.netDWDataGridViewTextBoxColumn.Name = "netDWDataGridViewTextBoxColumn";
            this.netDWDataGridViewTextBoxColumn.ReadOnly = true;
            this.netDWDataGridViewTextBoxColumn.Width = 71;
            // 
            // dWDataGridViewTextBoxColumn
            // 
            this.dWDataGridViewTextBoxColumn.DataPropertyName = "DW%";
            this.dWDataGridViewTextBoxColumn.HeaderText = "DW%";
            this.dWDataGridViewTextBoxColumn.Name = "dWDataGridViewTextBoxColumn";
            this.dWDataGridViewTextBoxColumn.ReadOnly = true;
            this.dWDataGridViewTextBoxColumn.Width = 59;
            // 
            // tLWWDataGridViewTextBoxColumn
            // 
            this.tLWWDataGridViewTextBoxColumn.DataPropertyName = "TL%WW";
            this.tLWWDataGridViewTextBoxColumn.HeaderText = "TL%WW";
            this.tLWWDataGridViewTextBoxColumn.Name = "tLWWDataGridViewTextBoxColumn";
            this.tLWWDataGridViewTextBoxColumn.ReadOnly = true;
            this.tLWWDataGridViewTextBoxColumn.Width = 75;
            // 
            // calculatedTL2015DataGridViewTextBoxColumn
            // 
            this.calculatedTL2015DataGridViewTextBoxColumn.DataPropertyName = "Calculated TL% 2015";
            this.calculatedTL2015DataGridViewTextBoxColumn.HeaderText = "Calculated TL% 2015";
            this.calculatedTL2015DataGridViewTextBoxColumn.Name = "calculatedTL2015DataGridViewTextBoxColumn";
            this.calculatedTL2015DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Width = 81;
            // 
            // ErrAnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.уловыDataGridView);
            this.Controls.Add(this.бАDataGridView);
            this.Controls.Add(this.пробыDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrAnal";
            this.Text = "Анализатор ошибок импорта ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrAnal_FormClosing);
            this.Load += new System.EventHandler(this.ErrAnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пробыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уловыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уловыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пробыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бАDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тестовая_бд_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бАBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog OpFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Тестовая_бд_DataSetTableAdapters.БАTableAdapter бАTableAdapter;
        private Тестовая_бд_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Тестовая_бд_DataSetTableAdapters.ПробыTableAdapter пробыTableAdapter;
        private System.Windows.Forms.BindingSource пробыBindingSource;
        private Тестовая_бд_DataSetTableAdapters.УловыTableAdapter уловыTableAdapter;
        private System.Windows.Forms.DataGridView пробыDataGridView;
        private System.Windows.Forms.BindingSource уловыBindingSource;
        private System.Windows.Forms.DataGridView уловыDataGridView;
        public System.Windows.Forms.DataGridView бАDataGridView;
        public Тестовая_бд_DataSet тестовая_бд_DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn midSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn size1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn size2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fishNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wetWeighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanWWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxWeightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossDWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLWWDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedTL2017DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cathIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samplIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yYYYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfIndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wetWeightGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanWWGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanDWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeClassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWSamplesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLSamplesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWIndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLIndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bioAnalysesIndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn size1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn size2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wetWeightgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossDWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLWWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedTL2015DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource бАBindingSource;
    }
}