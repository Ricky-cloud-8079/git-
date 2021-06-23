
using System.Windows.Forms;

namespace 期中
{
    partial class Form7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mydbDataSet1 = new 期中.mydbDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new 期中.mydbDataSet1TableAdapters.productsTableAdapter();
            this.tableAdapterManager = new 期中.mydbDataSet1TableAdapters.TableAdapterManager();
            this.mydbDataSet = new 期中.mydbDataSet();
            this.學生BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.學生TableAdapter = new 期中.mydbDataSetTableAdapters.學生TableAdapter();
            this.tableAdapterManager1 = new 期中.mydbDataSetTableAdapters.TableAdapterManager();
            this.lbox搜尋結果 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.cbox班級選擇 = new System.Windows.Forms.ComboBox();
            this.txt搜尋字串 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn資料筆數 = new System.Windows.Forms.Button();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label17 = new System.Windows.Forms.Label();
            this.cbox班級選擇2 = new System.Windows.Forms.ComboBox();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn進階 = new System.Windows.Forms.Button();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.值日materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.管理materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2學員 = new System.Windows.Forms.ListBox();
            this.學生BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet2 = new 期中.mydbDataSet2();
            this.btn重載 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn更新 = new System.Windows.Forms.Button();
            this.btn筆數 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label23 = new System.Windows.Forms.Label();
            this.mydbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.學生BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.學生TableAdapter1 = new 期中.mydbDataSet2TableAdapters.學生TableAdapter();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.商品DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet3 = new 期中.mydbDataSet3();
            this.店家DataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店家BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn儲存商品資料 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btn上傳照片 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.店家BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.店家TableAdapter = new 期中.mydbDataSet3TableAdapters.店家TableAdapter();
            this.tableAdapterManager2 = new 期中.mydbDataSet3TableAdapters.TableAdapterManager();
            this.商品TableAdapter = new 期中.mydbDataSet3TableAdapters.商品TableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource1)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.商品DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.mydbDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = 期中.mydbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 學生BindingSource
            // 
            this.學生BindingSource.DataMember = "學生";
            this.學生BindingSource.DataSource = this.mydbDataSet;
            // 
            // 學生TableAdapter
            // 
            this.學生TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = 期中.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.學生TableAdapter = this.學生TableAdapter;
            // 
            // lbox搜尋結果
            // 
            this.lbox搜尋結果.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox搜尋結果.FormattingEnabled = true;
            this.lbox搜尋結果.ItemHeight = 23;
            this.lbox搜尋結果.Location = new System.Drawing.Point(13, 60);
            this.lbox搜尋結果.Name = "lbox搜尋結果";
            this.lbox搜尋結果.Size = new System.Drawing.Size(475, 184);
            this.lbox搜尋結果.TabIndex = 9;
            this.lbox搜尋結果.SelectedIndexChanged += new System.EventHandler(this.lbox搜尋結果_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "到";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "從";
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.CustomFormat = "yyyy年MM月dd日";
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp結束時間.Location = new System.Drawing.Point(262, 258);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(208, 27);
            this.dtp結束時間.TabIndex = 5;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.CustomFormat = "yyyy年MM月dd日";
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp開始時間.Location = new System.Drawing.Point(39, 259);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(164, 27);
            this.dtp開始時間.TabIndex = 4;
            this.dtp開始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // cbox班級選擇
            // 
            this.cbox班級選擇.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox班級選擇.FormattingEnabled = true;
            this.cbox班級選擇.Items.AddRange(new object[] {
            "JAVA",
            "全端工程",
            "全方位IT"});
            this.cbox班級選擇.Location = new System.Drawing.Point(319, 73);
            this.cbox班級選擇.Name = "cbox班級選擇";
            this.cbox班級選擇.Size = new System.Drawing.Size(92, 27);
            this.cbox班級選擇.TabIndex = 3;
            // 
            // txt搜尋字串
            // 
            this.txt搜尋字串.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋字串.Location = new System.Drawing.Point(39, 179);
            this.txt搜尋字串.Name = "txt搜尋字串";
            this.txt搜尋字串.Size = new System.Drawing.Size(145, 27);
            this.txt搜尋字串.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(17, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "區間";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "搜尋關鍵字";
            // 
            // dtp生日
            // 
            this.dtp生日.CustomFormat = "yyyy年MM月dd日";
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp生日.Location = new System.Drawing.Point(99, 324);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(312, 27);
            this.dtp生日.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(99, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(99, 237);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(312, 27);
            this.txt地址.TabIndex = 11;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(118, 194);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(312, 27);
            this.txt電話.TabIndex = 10;
            // 
            // txt姓名
            // 
            this.txt姓名.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(118, 156);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(312, 27);
            this.txt姓名.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(118, 117);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(312, 27);
            this.txtID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 24.23762F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(15, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "權限設定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(29, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(29, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "序號";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn新增資料);
            this.groupBox1.Controls.Add(this.btn修改資料);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Controls.Add(this.btn資料筆數);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(-170, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 433);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能選單";
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Location = new System.Drawing.Point(4, 287);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(141, 40);
            this.btn刪除資料.TabIndex = 4;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            // 
            // btn新增資料
            // 
            this.btn新增資料.Location = new System.Drawing.Point(4, 224);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(141, 40);
            this.btn新增資料.TabIndex = 3;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            // 
            // btn修改資料
            // 
            this.btn修改資料.Location = new System.Drawing.Point(4, 164);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(141, 40);
            this.btn修改資料.TabIndex = 2;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.BackColor = System.Drawing.Color.Orange;
            this.btn資料搜尋.Location = new System.Drawing.Point(4, 106);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(141, 40);
            this.btn資料搜尋.TabIndex = 1;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = false;
            // 
            // btn資料筆數
            // 
            this.btn資料筆數.Location = new System.Drawing.Point(4, 51);
            this.btn資料筆數.Name = "btn資料筆數";
            this.btn資料筆數.Size = new System.Drawing.Size(141, 40);
            this.btn資料筆數.TabIndex = 0;
            this.btn資料筆數.Text = "資料筆數";
            this.btn資料筆數.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label17);
            this.materialCard1.Controls.Add(this.cbox班級選擇2);
            this.materialCard1.Controls.Add(this.cbox搜尋欄位);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.dtp結束時間);
            this.materialCard1.Controls.Add(this.label12);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Controls.Add(this.label11);
            this.materialCard1.Controls.Add(this.dtp開始時間);
            this.materialCard1.Controls.Add(this.txt搜尋字串);
            this.materialCard1.Controls.Add(this.label18);
            this.materialCard1.Controls.Add(this.label10);
            this.materialCard1.Controls.Add(this.btn進階);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(775, 6);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard1.Size = new System.Drawing.Size(488, 312);
            this.materialCard1.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(17, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 24);
            this.label17.TabIndex = 64;
            this.label17.Text = "班級";
            // 
            // cbox班級選擇2
            // 
            this.cbox班級選擇2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox班級選擇2.FormattingEnabled = true;
            this.cbox班級選擇2.Items.AddRange(new object[] {
            "JAVA",
            "全端工程",
            "全方位IT"});
            this.cbox班級選擇2.Location = new System.Drawing.Point(39, 101);
            this.cbox班級選擇2.Name = "cbox班級選擇2";
            this.cbox班級選擇2.Size = new System.Drawing.Size(92, 27);
            this.cbox班級選擇2.TabIndex = 63;
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Items.AddRange(new object[] {
            "姓名",
            "電話",
            "生日",
            "email",
            "地址"});
            this.cbox搜尋欄位.Location = new System.Drawing.Point(262, 182);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(91, 24);
            this.cbox搜尋欄位.TabIndex = 40;
            this.cbox搜尋欄位.SelectedIndexChanged += new System.EventHandler(this.cbox搜尋欄位_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(15, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 45);
            this.label13.TabIndex = 6;
            this.label13.Text = "學員進階搜尋";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(258, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "搜索條件";
            // 
            // btn進階
            // 
            this.btn進階.BackColor = System.Drawing.Color.Crimson;
            this.btn進階.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn進階.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn進階.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn進階.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn進階.ForeColor = System.Drawing.Color.White;
            this.btn進階.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn進階.Location = new System.Drawing.Point(388, 157);
            this.btn進階.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn進階.Name = "btn進階";
            this.btn進階.Size = new System.Drawing.Size(85, 57);
            this.btn進階.TabIndex = 39;
            this.btn進階.Text = "搜尋";
            this.btn進階.UseVisualStyleBackColor = false;
            this.btn進階.Click += new System.EventHandler(this.btn進階_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.值日materialCheckbox2);
            this.materialCard2.Controls.Add(this.管理materialCheckbox1);
            this.materialCard2.Controls.Add(this.label27);
            this.materialCard2.Controls.Add(this.label8);
            this.materialCard2.Controls.Add(this.dtp生日);
            this.materialCard2.Controls.Add(this.listBox2學員);
            this.materialCard2.Controls.Add(this.txt地址);
            this.materialCard2.Controls.Add(this.btn重載);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.btn新增);
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.cbox班級選擇);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.label14);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.btn更新);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.label7);
            this.materialCard2.Controls.Add(this.txtEmail);
            this.materialCard2.Controls.Add(this.btn筆數);
            this.materialCard2.Controls.Add(this.btn搜尋);
            this.materialCard2.Controls.Add(this.btn刪除);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(19, 6);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard2.Size = new System.Drawing.Size(747, 618);
            this.materialCard2.TabIndex = 61;
            // 
            // 值日materialCheckbox2
            // 
            this.值日materialCheckbox2.AutoSize = true;
            this.值日materialCheckbox2.Depth = 0;
            this.值日materialCheckbox2.Location = new System.Drawing.Point(245, 478);
            this.值日materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.值日materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.值日materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.值日materialCheckbox2.Name = "值日materialCheckbox2";
            this.值日materialCheckbox2.Ripple = true;
            this.值日materialCheckbox2.Size = new System.Drawing.Size(83, 37);
            this.值日materialCheckbox2.TabIndex = 62;
            this.值日materialCheckbox2.Text = "值日生";
            this.值日materialCheckbox2.UseVisualStyleBackColor = true;
            this.值日materialCheckbox2.CheckedChanged += new System.EventHandler(this.值日materialCheckbox2_CheckedChanged);
            // 
            // 管理materialCheckbox1
            // 
            this.管理materialCheckbox1.AutoSize = true;
            this.管理materialCheckbox1.Depth = 0;
            this.管理materialCheckbox1.Location = new System.Drawing.Point(61, 478);
            this.管理materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.管理materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.管理materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.管理materialCheckbox1.Name = "管理materialCheckbox1";
            this.管理materialCheckbox1.Ripple = true;
            this.管理materialCheckbox1.Size = new System.Drawing.Size(83, 37);
            this.管理materialCheckbox1.TabIndex = 62;
            this.管理materialCheckbox1.Text = "管理員";
            this.管理materialCheckbox1.UseVisualStyleBackColor = true;
            this.管理materialCheckbox1.CheckedChanged += new System.EventHandler(this.管理materialCheckbox1_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label27.Location = new System.Drawing.Point(429, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 45);
            this.label27.TabIndex = 6;
            this.label27.Text = "總覽";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "學員資料";
            // 
            // listBox2學員
            // 
            this.listBox2學員.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.學生BindingSource, "stName", true));
            this.listBox2學員.DataSource = this.學生BindingSource2;
            this.listBox2學員.DisplayMember = "stName";
            this.listBox2學員.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.listBox2學員.FormattingEnabled = true;
            this.listBox2學員.ItemHeight = 27;
            this.listBox2學員.Location = new System.Drawing.Point(436, 69);
            this.listBox2學員.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2學員.MultiColumn = true;
            this.listBox2學員.Name = "listBox2學員";
            this.listBox2學員.Size = new System.Drawing.Size(296, 274);
            this.listBox2學員.TabIndex = 59;
            this.listBox2學員.ValueMember = "id";
            this.listBox2學員.Click += new System.EventHandler(this.listBox2學員_Click);
            this.listBox2學員.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // 學生BindingSource2
            // 
            this.學生BindingSource2.DataMember = "學生";
            this.學生BindingSource2.DataSource = this.mydbDataSet2BindingSource1;
            // 
            // mydbDataSet2BindingSource1
            // 
            this.mydbDataSet2BindingSource1.DataSource = this.mydbDataSet2;
            this.mydbDataSet2BindingSource1.Position = 0;
            // 
            // mydbDataSet2
            // 
            this.mydbDataSet2.DataSetName = "mydbDataSet2";
            this.mydbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn重載
            // 
            this.btn重載.BackColor = System.Drawing.Color.White;
            this.btn重載.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn重載.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn重載.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn重載.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn重載.ForeColor = System.Drawing.Color.Crimson;
            this.btn重載.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn重載.Location = new System.Drawing.Point(599, 546);
            this.btn重載.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn重載.Name = "btn重載";
            this.btn重載.Size = new System.Drawing.Size(107, 32);
            this.btn重載.TabIndex = 39;
            this.btn重載.Text = "重新載入";
            this.btn重載.UseVisualStyleBackColor = false;
            this.btn重載.Click += new System.EventHandler(this.btn重載_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackColor = System.Drawing.Color.White;
            this.btn新增.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn新增.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn新增.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn新增.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn新增.ForeColor = System.Drawing.Color.Crimson;
            this.btn新增.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn新增.Location = new System.Drawing.Point(40, 546);
            this.btn新增.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(107, 32);
            this.btn新增.TabIndex = 39;
            this.btn新增.Text = "新增資料";
            this.btn新增.UseVisualStyleBackColor = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(262, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "班級";
            // 
            // btn更新
            // 
            this.btn更新.BackColor = System.Drawing.Color.White;
            this.btn更新.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn更新.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn更新.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn更新.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn更新.ForeColor = System.Drawing.Color.Crimson;
            this.btn更新.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn更新.Location = new System.Drawing.Point(463, 546);
            this.btn更新.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(107, 32);
            this.btn更新.TabIndex = 39;
            this.btn更新.Text = "更改資料";
            this.btn更新.UseVisualStyleBackColor = false;
            this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
            // 
            // btn筆數
            // 
            this.btn筆數.BackColor = System.Drawing.Color.White;
            this.btn筆數.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn筆數.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn筆數.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn筆數.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn筆數.ForeColor = System.Drawing.Color.Crimson;
            this.btn筆數.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn筆數.Location = new System.Drawing.Point(319, 546);
            this.btn筆數.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn筆數.Name = "btn筆數";
            this.btn筆數.Size = new System.Drawing.Size(107, 32);
            this.btn筆數.TabIndex = 39;
            this.btn筆數.Text = "資料筆數";
            this.btn筆數.UseVisualStyleBackColor = false;
            this.btn筆數.Click += new System.EventHandler(this.btn筆數_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Crimson;
            this.btn搜尋.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn搜尋.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn搜尋.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn搜尋.Location = new System.Drawing.Point(599, 494);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(107, 32);
            this.btn搜尋.TabIndex = 39;
            this.btn搜尋.Text = "資料搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.BackColor = System.Drawing.Color.White;
            this.btn刪除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn刪除.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn刪除.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn刪除.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn刪除.ForeColor = System.Drawing.Color.Crimson;
            this.btn刪除.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn刪除.Location = new System.Drawing.Point(171, 546);
            this.btn刪除.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(107, 32);
            this.btn刪除.TabIndex = 39;
            this.btn刪除.Text = "刪除資料";
            this.btn刪除.UseVisualStyleBackColor = false;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label23);
            this.materialCard3.Controls.Add(this.lbox搜尋結果);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(775, 343);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard3.Size = new System.Drawing.Size(495, 281);
            this.materialCard3.TabIndex = 62;
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 24.23762F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(6, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 42);
            this.label23.TabIndex = 63;
            this.label23.Text = "搜尋結果";
            // 
            // mydbDataSet2BindingSource
            // 
            this.mydbDataSet2BindingSource.DataSource = this.mydbDataSet2;
            this.mydbDataSet2BindingSource.Position = 0;
            // 
            // 學生BindingSource1
            // 
            this.學生BindingSource1.DataMember = "學生";
            this.學生BindingSource1.DataSource = this.mydbDataSet2BindingSource;
            // 
            // 學生TableAdapter1
            // 
            this.學生TableAdapter1.ClearBeforeFill = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.textBox6);
            this.materialCard4.Controls.Add(this.label30);
            this.materialCard4.Controls.Add(this.textBox4);
            this.materialCard4.Controls.Add(this.label29);
            this.materialCard4.Controls.Add(this.商品DataGridView);
            this.materialCard4.Controls.Add(this.店家DataGridView);
            this.materialCard4.Controls.Add(this.textBox3);
            this.materialCard4.Controls.Add(this.label25);
            this.materialCard4.Controls.Add(this.textBox1);
            this.materialCard4.Controls.Add(this.button1);
            this.materialCard4.Controls.Add(this.btn儲存商品資料);
            this.materialCard4.Controls.Add(this.label22);
            this.materialCard4.Controls.Add(this.btn上傳照片);
            this.materialCard4.Controls.Add(this.btn新增商品);
            this.materialCard4.Controls.Add(this.pictureBox1);
            this.materialCard4.Controls.Add(this.txt商品價格);
            this.materialCard4.Controls.Add(this.txt商品名稱);
            this.materialCard4.Controls.Add(this.textBox2);
            this.materialCard4.Controls.Add(this.textBox5);
            this.materialCard4.Controls.Add(this.label19);
            this.materialCard4.Controls.Add(this.label24);
            this.materialCard4.Controls.Add(this.label28);
            this.materialCard4.Controls.Add(this.label20);
            this.materialCard4.Controls.Add(this.label21);
            this.materialCard4.Controls.Add(this.label26);
            this.materialCard4.Controls.Add(this.label16);
            this.materialCard4.Controls.Add(this.label15);
            this.materialCard4.Controls.Add(this.pictureBox2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(19, 650);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.materialCard4.Size = new System.Drawing.Size(1248, 820);
            this.materialCard4.TabIndex = 63;
            // 
            // 商品DataGridView
            // 
            this.商品DataGridView.AutoGenerateColumns = false;
            this.商品DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.商品DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.商品DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.商品DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.商品DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.商品DataGridView.DataSource = this.商品BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.商品DataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.商品DataGridView.Location = new System.Drawing.Point(540, 534);
            this.商品DataGridView.Name = "商品DataGridView";
            this.商品DataGridView.RowHeadersWidth = 43;
            this.商品DataGridView.RowTemplate.Height = 25;
            this.商品DataGridView.Size = new System.Drawing.Size(685, 270);
            this.商品DataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pid";
            this.dataGridViewTextBoxColumn5.HeaderText = "pid";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sid";
            this.dataGridViewTextBoxColumn6.HeaderText = "sid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pname";
            this.dataGridViewTextBoxColumn7.HeaderText = "pname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn8.HeaderText = "price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "detail";
            this.dataGridViewTextBoxColumn9.HeaderText = "detail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "pic";
            this.dataGridViewTextBoxColumn10.HeaderText = "pic";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ptype";
            this.dataGridViewTextBoxColumn11.HeaderText = "ptype";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.mydbDataSet3;
            // 
            // mydbDataSet3
            // 
            this.mydbDataSet3.DataSetName = "mydbDataSet3";
            this.mydbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 店家DataGridView
            // 
            this.店家DataGridView.AutoGenerateColumns = false;
            this.店家DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.店家DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.店家DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.店家DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.店家DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.店家DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.店家DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.店家DataGridView.DataSource = this.店家BindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.店家DataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.店家DataGridView.Location = new System.Drawing.Point(51, 534);
            this.店家DataGridView.Name = "店家DataGridView";
            this.店家DataGridView.RowHeadersWidth = 43;
            this.店家DataGridView.RowTemplate.Height = 25;
            this.店家DataGridView.Size = new System.Drawing.Size(475, 270);
            this.店家DataGridView.TabIndex = 77;
            this.店家DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.店家DataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // 店家BindingSource1
            // 
            this.店家BindingSource1.DataMember = "店家";
            this.店家BindingSource1.DataSource = this.mydbDataSet3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(778, 330);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 29);
            this.textBox3.TabIndex = 77;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label25.Location = new System.Drawing.Point(563, 334);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 25);
            this.label25.TabIndex = 76;
            this.label25.Text = "餐點分類";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(778, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1112, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "重新載入";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn重載_Click);
            // 
            // btn儲存商品資料
            // 
            this.btn儲存商品資料.BackColor = System.Drawing.Color.Crimson;
            this.btn儲存商品資料.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn儲存商品資料.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存商品資料.ForeColor = System.Drawing.Color.White;
            this.btn儲存商品資料.Location = new System.Drawing.Point(1113, 344);
            this.btn儲存商品資料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn儲存商品資料.Name = "btn儲存商品資料";
            this.btn儲存商品資料.Size = new System.Drawing.Size(113, 33);
            this.btn儲存商品資料.TabIndex = 73;
            this.btn儲存商品資料.Text = "儲存資料";
            this.btn儲存商品資料.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(564, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 24);
            this.label22.TabIndex = 64;
            this.label22.Text = "詳細內容";
            // 
            // btn上傳照片
            // 
            this.btn上傳照片.BackColor = System.Drawing.Color.White;
            this.btn上傳照片.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn上傳照片.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上傳照片.ForeColor = System.Drawing.Color.Crimson;
            this.btn上傳照片.Location = new System.Drawing.Point(1112, 252);
            this.btn上傳照片.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn上傳照片.Name = "btn上傳照片";
            this.btn上傳照片.Size = new System.Drawing.Size(113, 33);
            this.btn上傳照片.TabIndex = 72;
            this.btn上傳照片.Text = "上傳照片";
            this.btn上傳照片.UseVisualStyleBackColor = false;
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.White;
            this.btn新增商品.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.ForeColor = System.Drawing.Color.Crimson;
            this.btn新增商品.Location = new System.Drawing.Point(1112, 381);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(113, 33);
            this.btn新增商品.TabIndex = 71;
            this.btn新增商品.Text = "新增餐點";
            this.btn新增商品.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1065, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(778, 239);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(222, 29);
            this.txt商品價格.TabIndex = 69;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品BindingSource, "pname", true));
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(778, 191);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(223, 29);
            this.txt商品名稱.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.店家BindingSource, "sname", true));
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(777, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(225, 29);
            this.textBox2.TabIndex = 67;
            // 
            // 店家BindingSource
            // 
            this.店家BindingSource.DataMember = "店家";
            this.店家BindingSource.DataSource = this.mydbDataSet3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品BindingSource, "pid", true));
            this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(777, 101);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(227, 29);
            this.textBox5.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(562, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 25);
            this.label19.TabIndex = 66;
            this.label19.Text = "商品價格";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(561, 143);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 25);
            this.label24.TabIndex = 64;
            this.label24.Text = "店家名稱";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(166, 322);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 25);
            this.label28.TabIndex = 65;
            this.label28.Text = "餐點名稱";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(561, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 25);
            this.label20.TabIndex = 65;
            this.label20.Text = "餐點名稱";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(563, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 25);
            this.label21.TabIndex = 64;
            this.label21.Text = "ID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.Location = new System.Drawing.Point(15, 454);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 45);
            this.label26.TabIndex = 6;
            this.label26.Text = "總覽";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(533, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 45);
            this.label16.TabIndex = 6;
            this.label16.Text = "編輯資料";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 25.66337F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(9, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 45);
            this.label15.TabIndex = 6;
            this.label15.Text = "店家資料";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::期中.Properties.Resources.turkey;
            this.pictureBox2.Location = new System.Drawing.Point(99, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // 店家TableAdapter
            // 
            this.店家TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = 期中.mydbDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.商品TableAdapter = null;
            this.tableAdapterManager2.店家TableAdapter = this.店家TableAdapter;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripLabel1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 492);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1308, 23);
            this.fillByToolStrip.TabIndex = 64;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 20);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 20);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 492);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1308, 23);
            this.fillBy1ToolStrip.TabIndex = 65;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 20);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(779, 381);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 29);
            this.textBox4.TabIndex = 80;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.Location = new System.Drawing.Point(564, 385);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 25);
            this.label29.TabIndex = 79;
            this.label29.Text = "地址";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(779, 424);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 29);
            this.textBox6.TabIndex = 82;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.Location = new System.Drawing.Point(564, 428);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 25);
            this.label30.TabIndex = 81;
            this.label30.Text = "電話";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1323, 978);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.materialCard2);
            this.MaximumSize = new System.Drawing.Size(1339, 2957);
            this.Name = "Form7";
            this.Text = "Form7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學生BindingSource1)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.商品DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.店家BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private mydbDataSet1TableAdapters.productsTableAdapter productsTableAdapter;
        private mydbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource 學生BindingSource;
        private mydbDataSetTableAdapters.學生TableAdapter 學生TableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ListBox lbox搜尋結果;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.ComboBox cbox班級選擇;
        private System.Windows.Forms.TextBox txt搜尋字串;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Button btn刪除資料;
        private Button btn新增資料;
        private Button btn修改資料;
        private Button btn資料搜尋;
        private Button btn資料筆數;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn進階;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialCheckbox 值日materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox 管理materialCheckbox1;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn更新;
        private System.Windows.Forms.Button btn筆數;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Button btn刪除;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private ListBox listBox2學員;
        private BindingSource mydbDataSet2BindingSource;
        private mydbDataSet2 mydbDataSet2;
        private BindingSource 學生BindingSource1;
        private mydbDataSet2TableAdapters.學生TableAdapter 學生TableAdapter1;
        private BindingSource 學生BindingSource2;
        private BindingSource mydbDataSet2BindingSource1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label15;
        private Button btn重載;
        private ComboBox cbox搜尋欄位;
        private Label label17;
        private ComboBox cbox班級選擇2;
        private Label label18;
        private Button btn儲存商品資料;
        private Button btn上傳照片;
        private Button btn新增商品;
        private PictureBox pictureBox1;
        private TextBox txt商品價格;
        private TextBox txt商品名稱;
        private TextBox textBox5;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox1;
        private Label label22;
        private mydbDataSet3 mydbDataSet3;
        private BindingSource 店家BindingSource;
        private mydbDataSet3TableAdapters.店家TableAdapter 店家TableAdapter;
        private mydbDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private Label label23;
        private TextBox textBox3;
        private Label label25;
        private Button button1;
        private DataGridView 店家DataGridView;
        private BindingSource 商品BindingSource;
        private mydbDataSet3TableAdapters.商品TableAdapter 商品TableAdapter;
        private DataGridView 商品DataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Label label26;
        private Label label16;
        private Label label27;
        private TextBox textBox2;
        private Label label24;
        private PictureBox pictureBox2;
        private Label label28;
        private ToolStrip fillByToolStrip;
        private ToolStripButton fillByToolStripButton;
        private ToolStrip fillBy1ToolStrip;
        private ToolStripButton fillBy1ToolStripButton;
        private ToolStripLabel toolStripLabel1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource 店家BindingSource1;
        private TextBox textBox6;
        private Label label30;
        private TextBox textBox4;
        private Label label29;
    }
}