
namespace lab5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new lab5.DataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerLNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playeyAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.coachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachLNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.parentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentLNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.enrollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new lab5.DataSet1();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.enrollIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new lab5.DataSet1TableAdapters.TeamTableAdapter();
            this.playerTableAdapter = new lab5.DataSet1TableAdapters.PlayerTableAdapter();
            this.coachTableAdapter = new lab5.DataSet1TableAdapters.CoachTableAdapter();
            this.parentTableAdapter = new lab5.DataSet1TableAdapters.ParentTableAdapter();
            this.dataSet11 = new lab5.DataSet1();
            this.enrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollTableAdapter = new lab5.DataSet1TableAdapters.EnrollTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1141, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1133, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 314);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamBindingSource;
            this.comboBox1.DisplayMember = "Team_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 220);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Team_ID";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 220);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 220);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIDDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamColorsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "Team_Name";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Team_Name";
            this.teamNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            this.teamNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamColorsDataGridViewTextBoxColumn
            // 
            this.teamColorsDataGridViewTextBoxColumn.DataPropertyName = "Team_Colors";
            this.teamColorsDataGridViewTextBoxColumn.HeaderText = "Team_Colors";
            this.teamColorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamColorsDataGridViewTextBoxColumn.Name = "teamColorsDataGridViewTextBoxColumn";
            this.teamColorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox8);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1133, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.teamBindingSource;
            this.comboBox8.DisplayMember = "Team_ID";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(764, 250);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 24);
            this.comboBox8.TabIndex = 9;
            this.comboBox8.ValueMember = "Team_ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(461, 353);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 353);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 353);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.playerBindingSource;
            this.comboBox2.DisplayMember = "Player_FN";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 250);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Player_ID";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.dataSet1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(611, 249);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(435, 249);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 249);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.playerFNDataGridViewTextBoxColumn,
            this.playerLNDataGridViewTextBoxColumn,
            this.playeyAgeDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(941, 244);
            this.dataGridView2.TabIndex = 0;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "Player_ID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "Player_ID";
            this.playerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            this.playerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // playerFNDataGridViewTextBoxColumn
            // 
            this.playerFNDataGridViewTextBoxColumn.DataPropertyName = "Player_FN";
            this.playerFNDataGridViewTextBoxColumn.HeaderText = "Player_FN";
            this.playerFNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerFNDataGridViewTextBoxColumn.Name = "playerFNDataGridViewTextBoxColumn";
            this.playerFNDataGridViewTextBoxColumn.Width = 125;
            // 
            // playerLNDataGridViewTextBoxColumn
            // 
            this.playerLNDataGridViewTextBoxColumn.DataPropertyName = "Player_LN";
            this.playerLNDataGridViewTextBoxColumn.HeaderText = "Player_LN";
            this.playerLNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerLNDataGridViewTextBoxColumn.Name = "playerLNDataGridViewTextBoxColumn";
            this.playerLNDataGridViewTextBoxColumn.Width = 125;
            // 
            // playeyAgeDataGridViewTextBoxColumn
            // 
            this.playeyAgeDataGridViewTextBoxColumn.DataPropertyName = "Playey_Age";
            this.playeyAgeDataGridViewTextBoxColumn.HeaderText = "Playey_Age";
            this.playeyAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playeyAgeDataGridViewTextBoxColumn.Name = "playeyAgeDataGridViewTextBoxColumn";
            this.playeyAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamIDDataGridViewTextBoxColumn1
            // 
            this.teamIDDataGridViewTextBoxColumn1.DataPropertyName = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn1.HeaderText = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.teamIDDataGridViewTextBoxColumn1.Name = "teamIDDataGridViewTextBoxColumn1";
            this.teamIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox9);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.Insert);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1133, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = this.teamBindingSource;
            this.comboBox9.DisplayMember = "Team_ID";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(776, 203);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 24);
            this.comboBox9.TabIndex = 9;
            this.comboBox9.ValueMember = "Team_ID";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(468, 327);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(344, 327);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(217, 327);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.coachBindingSource;
            this.comboBox3.DisplayMember = "Coach_FN";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 206);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Coach_ID";
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.dataSet1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(613, 204);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(441, 204);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(279, 204);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coachIDDataGridViewTextBoxColumn,
            this.coachFNDataGridViewTextBoxColumn,
            this.coachLNDataGridViewTextBoxColumn,
            this.coachPHDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.coachBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(915, 199);
            this.dataGridView3.TabIndex = 0;
           
            // 
            // coachIDDataGridViewTextBoxColumn
            // 
            this.coachIDDataGridViewTextBoxColumn.DataPropertyName = "Coach_ID";
            this.coachIDDataGridViewTextBoxColumn.HeaderText = "Coach_ID";
            this.coachIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachIDDataGridViewTextBoxColumn.Name = "coachIDDataGridViewTextBoxColumn";
            this.coachIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.coachIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // coachFNDataGridViewTextBoxColumn
            // 
            this.coachFNDataGridViewTextBoxColumn.DataPropertyName = "Coach_FN";
            this.coachFNDataGridViewTextBoxColumn.HeaderText = "Coach_FN";
            this.coachFNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachFNDataGridViewTextBoxColumn.Name = "coachFNDataGridViewTextBoxColumn";
            this.coachFNDataGridViewTextBoxColumn.Width = 125;
            // 
            // coachLNDataGridViewTextBoxColumn
            // 
            this.coachLNDataGridViewTextBoxColumn.DataPropertyName = "Coach_LN";
            this.coachLNDataGridViewTextBoxColumn.HeaderText = "Coach_LN";
            this.coachLNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachLNDataGridViewTextBoxColumn.Name = "coachLNDataGridViewTextBoxColumn";
            this.coachLNDataGridViewTextBoxColumn.Width = 125;
            // 
            // coachPHDataGridViewTextBoxColumn
            // 
            this.coachPHDataGridViewTextBoxColumn.DataPropertyName = "Coach_PH";
            this.coachPHDataGridViewTextBoxColumn.HeaderText = "Coach_PH";
            this.coachPHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachPHDataGridViewTextBoxColumn.Name = "coachPHDataGridViewTextBoxColumn";
            this.coachPHDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamIDDataGridViewTextBoxColumn2
            // 
            this.teamIDDataGridViewTextBoxColumn2.DataPropertyName = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn2.HeaderText = "Team_ID";
            this.teamIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.teamIDDataGridViewTextBoxColumn2.Name = "teamIDDataGridViewTextBoxColumn2";
            this.teamIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.textBox14);
            this.tabPage4.Controls.Add(this.textBox13);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1133, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(476, 246);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(351, 246);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Update";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(223, 246);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Insert";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.parentBindingSource;
            this.comboBox4.DisplayMember = "Parent_FN";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(56, 180);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "Parent_ID";
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataMember = "Parent";
            this.parentBindingSource.DataSource = this.dataSet1;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(568, 180);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 4;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(451, 180);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(325, 180);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(197, 180);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentIDDataGridViewTextBoxColumn,
            this.parentFNDataGridViewTextBoxColumn,
            this.parentLNDataGridViewTextBoxColumn,
            this.parentPNDataGridViewTextBoxColumn,
            this.parentAdressDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.parentBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(951, 174);
            this.dataGridView4.TabIndex = 0;
            // 
            // parentIDDataGridViewTextBoxColumn
            // 
            this.parentIDDataGridViewTextBoxColumn.DataPropertyName = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn.HeaderText = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentIDDataGridViewTextBoxColumn.Name = "parentIDDataGridViewTextBoxColumn";
            this.parentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentFNDataGridViewTextBoxColumn
            // 
            this.parentFNDataGridViewTextBoxColumn.DataPropertyName = "Parent_FN";
            this.parentFNDataGridViewTextBoxColumn.HeaderText = "Parent_FN";
            this.parentFNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentFNDataGridViewTextBoxColumn.Name = "parentFNDataGridViewTextBoxColumn";
            this.parentFNDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentLNDataGridViewTextBoxColumn
            // 
            this.parentLNDataGridViewTextBoxColumn.DataPropertyName = "Parent_LN";
            this.parentLNDataGridViewTextBoxColumn.HeaderText = "Parent_LN";
            this.parentLNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentLNDataGridViewTextBoxColumn.Name = "parentLNDataGridViewTextBoxColumn";
            this.parentLNDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentPNDataGridViewTextBoxColumn
            // 
            this.parentPNDataGridViewTextBoxColumn.DataPropertyName = "Parent_PN";
            this.parentPNDataGridViewTextBoxColumn.HeaderText = "Parent_PN";
            this.parentPNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentPNDataGridViewTextBoxColumn.Name = "parentPNDataGridViewTextBoxColumn";
            this.parentPNDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentAdressDataGridViewTextBoxColumn
            // 
            this.parentAdressDataGridViewTextBoxColumn.DataPropertyName = "Parent_Adress";
            this.parentAdressDataGridViewTextBoxColumn.HeaderText = "Parent_Adress";
            this.parentAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentAdressDataGridViewTextBoxColumn.Name = "parentAdressDataGridViewTextBoxColumn";
            this.parentAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBox7);
            this.tabPage5.Controls.Add(this.comboBox6);
            this.tabPage5.Controls.Add(this.comboBox5);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.button13);
            this.tabPage5.Controls.Add(this.button12);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(1133, 500);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.playerBindingSource;
            this.comboBox7.DisplayMember = "Player_ID";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(371, 180);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 24);
            this.comboBox7.TabIndex = 8;
            this.comboBox7.ValueMember = "Player_ID";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.parentBindingSource;
            this.comboBox6.DisplayMember = "Parent_ID";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(215, 180);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.ValueMember = "Parent_ID";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.enrollBindingSource1;
            this.comboBox5.DisplayMember = "Enroll_ID";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(49, 180);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.ValueMember = "Enroll_ID";
            // 
            // enrollBindingSource1
            // 
            this.enrollBindingSource1.DataMember = "Enroll";
            this.enrollBindingSource1.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(357, 236);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(227, 236);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "Update";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(97, 236);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Insert";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollIDDataGridViewTextBoxColumn,
            this.playerIDDataGridViewTextBoxColumn1,
            this.parentIDDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.enrollBindingSource2;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(593, 175);
            this.dataGridView5.TabIndex = 0;
            // 
            // enrollIDDataGridViewTextBoxColumn
            // 
            this.enrollIDDataGridViewTextBoxColumn.DataPropertyName = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn.HeaderText = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enrollIDDataGridViewTextBoxColumn.Name = "enrollIDDataGridViewTextBoxColumn";
            this.enrollIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.enrollIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // playerIDDataGridViewTextBoxColumn1
            // 
            this.playerIDDataGridViewTextBoxColumn1.DataPropertyName = "Player_ID";
            this.playerIDDataGridViewTextBoxColumn1.HeaderText = "Player_ID";
            this.playerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.playerIDDataGridViewTextBoxColumn1.Name = "playerIDDataGridViewTextBoxColumn1";
            this.playerIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // parentIDDataGridViewTextBoxColumn1
            // 
            this.parentIDDataGridViewTextBoxColumn1.DataPropertyName = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn1.HeaderText = "Parent_ID";
            this.parentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.parentIDDataGridViewTextBoxColumn1.Name = "parentIDDataGridViewTextBoxColumn1";
            this.parentIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // enrollBindingSource2
            // 
            this.enrollBindingSource2.DataMember = "Enroll";
            this.enrollBindingSource2.DataSource = this.dataSet1;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // parentTableAdapter
            // 
            this.parentTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollBindingSource
            // 
            this.enrollBindingSource.DataMember = "Enroll";
            this.enrollBindingSource.DataSource = this.dataSet11;
            // 
            // enrollTableAdapter
            // 
            this.enrollTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 578);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private DataSet1TableAdapters.TeamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private DataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerLNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeyAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private DataSet1TableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachLNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private DataSet1TableAdapters.ParentTableAdapter parentTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentLNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView5;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource enrollBindingSource;
        private DataSet1TableAdapters.EnrollTableAdapter enrollTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn1;
        private DataSet1 dataSet12;
        private System.Windows.Forms.BindingSource enrollBindingSource1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.BindingSource enrollBindingSource2;
    }
}

