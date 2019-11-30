namespace WindowsFormsApp22
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolzhnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gostinicaDataSet = new WindowsFormsApp22.GostinicaDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sotrudnikiTableAdapter = new WindowsFormsApp22.GostinicaDataSetTableAdapters.sotrudnikiTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gostinicaDataSet1 = new WindowsFormsApp22.GostinicaDataSet1();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.nomeraTableAdapter = new WindowsFormsApp22.GostinicaDataSet1TableAdapters.nomeraTableAdapter();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gostinicaDataSet2 = new WindowsFormsApp22.GostinicaDataSet2();
            this.button15 = new System.Windows.Forms.Button();
            this.klientiTableAdapter = new WindowsFormsApp22.GostinicaDataSet2TableAdapters.klientiTableAdapter();
            this.gostinicaDataSet3 = new WindowsFormsApp22.GostinicaDataSet3();
            this.gostinicaDataSet4 = new WindowsFormsApp22.GostinicaDataSet4();
            this.gostinicaDataSet5 = new WindowsFormsApp22.GostinicaDataSet5();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.im = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zacelen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.famDataGridViewTextBoxColumn,
            this.imDataGridViewTextBoxColumn,
            this.otchDataGridViewTextBoxColumn,
            this.datebornDataGridViewTextBoxColumn,
            this.dolzhnostDataGridViewTextBoxColumn,
            this.zarplataDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sotrudnikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "fam";
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            this.famDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imDataGridViewTextBoxColumn
            // 
            this.imDataGridViewTextBoxColumn.DataPropertyName = "im";
            this.imDataGridViewTextBoxColumn.HeaderText = "im";
            this.imDataGridViewTextBoxColumn.Name = "imDataGridViewTextBoxColumn";
            this.imDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otchDataGridViewTextBoxColumn
            // 
            this.otchDataGridViewTextBoxColumn.DataPropertyName = "otch";
            this.otchDataGridViewTextBoxColumn.HeaderText = "otch";
            this.otchDataGridViewTextBoxColumn.Name = "otchDataGridViewTextBoxColumn";
            this.otchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebornDataGridViewTextBoxColumn
            // 
            this.datebornDataGridViewTextBoxColumn.DataPropertyName = "date_born";
            this.datebornDataGridViewTextBoxColumn.HeaderText = "date_born";
            this.datebornDataGridViewTextBoxColumn.Name = "datebornDataGridViewTextBoxColumn";
            this.datebornDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dolzhnostDataGridViewTextBoxColumn
            // 
            this.dolzhnostDataGridViewTextBoxColumn.DataPropertyName = "dolzhnost";
            this.dolzhnostDataGridViewTextBoxColumn.HeaderText = "dolzhnost";
            this.dolzhnostDataGridViewTextBoxColumn.Name = "dolzhnostDataGridViewTextBoxColumn";
            this.dolzhnostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zarplataDataGridViewTextBoxColumn
            // 
            this.zarplataDataGridViewTextBoxColumn.DataPropertyName = "zarplata";
            this.zarplataDataGridViewTextBoxColumn.HeaderText = "zarplata";
            this.zarplataDataGridViewTextBoxColumn.Name = "zarplataDataGridViewTextBoxColumn";
            this.zarplataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "type";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.gostinicaDataSet;
            // 
            // gostinicaDataSet
            // 
            this.gostinicaDataSet.DataSetName = "GostinicaDataSet";
            this.gostinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Анкета сотрудника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Новый сотрудник";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 42);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удалить сотрудника";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(850, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 42);
            this.button6.TabIndex = 10;
            this.button6.Text = "Добавить номер";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.categoriaDataGridViewTextBoxColumn,
            this.colmestDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nomeraBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(739, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(674, 284);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colmestDataGridViewTextBoxColumn
            // 
            this.colmestDataGridViewTextBoxColumn.DataPropertyName = "col_mest";
            this.colmestDataGridViewTextBoxColumn.HeaderText = "col_mest";
            this.colmestDataGridViewTextBoxColumn.Name = "colmestDataGridViewTextBoxColumn";
            this.colmestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            this.opisanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            this.stoimostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeraBindingSource
            // 
            this.nomeraBindingSource.DataMember = "nomera";
            this.nomeraBindingSource.DataSource = this.gostinicaDataSet1;
            // 
            // gostinicaDataSet1
            // 
            this.gostinicaDataSet1.DataSetName = "GostinicaDataSet1";
            this.gostinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1010, 294);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 42);
            this.button7.TabIndex = 12;
            this.button7.Text = "Информация о номере";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1174, 294);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 42);
            this.button8.TabIndex = 13;
            this.button8.Text = "Удалить номер";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // nomeraTableAdapter
            // 
            this.nomeraTableAdapter.ClearBeforeFill = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(772, 648);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(135, 42);
            this.button13.TabIndex = 19;
            this.button13.Text = "Удалить клиента";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(608, 648);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 42);
            this.button14.TabIndex = 18;
            this.button14.Text = "Информация о клиенте";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.fam,
            this.im,
            this.otch,
            this.date_born,
            this.pol,
            this.zacelen});
            this.dataGridView3.DataSource = this.klientiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(109, 358);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1064, 284);
            this.dataGridView3.TabIndex = 17;
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "klienti";
            this.klientiBindingSource.DataSource = this.gostinicaDataSet2;
            // 
            // gostinicaDataSet2
            // 
            this.gostinicaDataSet2.DataSetName = "GostinicaDataSet2";
            this.gostinicaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(448, 648);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(135, 42);
            this.button15.TabIndex = 16;
            this.button15.Text = "Добавить клиента";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // gostinicaDataSet3
            // 
            this.gostinicaDataSet3.DataSetName = "GostinicaDataSet3";
            this.gostinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gostinicaDataSet4
            // 
            this.gostinicaDataSet4.DataSetName = "GostinicaDataSet4";
            this.gostinicaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gostinicaDataSet5
            // 
            this.gostinicaDataSet5.DataSetName = "GostinicaDataSet5";
            this.gostinicaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fam
            // 
            this.fam.DataPropertyName = "fam";
            this.fam.HeaderText = "fam";
            this.fam.Name = "fam";
            this.fam.ReadOnly = true;
            // 
            // im
            // 
            this.im.DataPropertyName = "im";
            this.im.HeaderText = "im";
            this.im.Name = "im";
            this.im.ReadOnly = true;
            // 
            // otch
            // 
            this.otch.DataPropertyName = "otch";
            this.otch.HeaderText = "otch";
            this.otch.Name = "otch";
            this.otch.ReadOnly = true;
            // 
            // date_born
            // 
            this.date_born.DataPropertyName = "date_born";
            this.date_born.HeaderText = "date_born";
            this.date_born.Name = "date_born";
            this.date_born.ReadOnly = true;
            // 
            // pol
            // 
            this.pol.DataPropertyName = "pol";
            this.pol.HeaderText = "pol";
            this.pol.Name = "pol";
            this.pol.ReadOnly = true;
            // 
            // zacelen
            // 
            this.zacelen.DataPropertyName = "zacelen";
            this.zacelen.HeaderText = "zacelen";
            this.zacelen.Name = "zacelen";
            this.zacelen.ReadOnly = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 746);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostinicaDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private GostinicaDataSet gostinicaDataSet;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private GostinicaDataSetTableAdapters.sotrudnikiTableAdapter sotrudnikiTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private GostinicaDataSet1 gostinicaDataSet1;
        private System.Windows.Forms.BindingSource nomeraBindingSource;
        private GostinicaDataSet1TableAdapters.nomeraTableAdapter nomeraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button15;
        private GostinicaDataSet2 gostinicaDataSet2;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private GostinicaDataSet2TableAdapters.klientiTableAdapter klientiTableAdapter;
        private GostinicaDataSet3 gostinicaDataSet3;
        private GostinicaDataSet4 gostinicaDataSet4;
        private GostinicaDataSet5 gostinicaDataSet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolzhnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn im;
        private System.Windows.Forms.DataGridViewTextBoxColumn otch;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_born;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn zacelen;
    }
}