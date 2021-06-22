
namespace 期中
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button加入預覽 = new System.Windows.Forms.Button();
            this.button移除所選 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBox預覽 = new System.Windows.Forms.CheckedListBox();
            this.加入數量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox班級 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox店家 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn確認訂購 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet1 = new 期中.mydbDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsTableAdapter = new 期中.mydbDataSet1TableAdapters.productsTableAdapter();
            this.tableAdapterManager = new 期中.mydbDataSet1TableAdapters.TableAdapterManager();
            this.pnameTextBox = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn收藏 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checklist餐點 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.加入數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::期中.Properties.Resources.fast_food;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::期中.Properties.Resources.turkey;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::期中.Properties.Resources.healthy_food;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.LightSalmon;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Name = "label6";
            // 
            // button加入預覽
            // 
            this.button加入預覽.BackColor = System.Drawing.Color.White;
            this.button加入預覽.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button加入預覽, "button加入預覽");
            this.button加入預覽.ForeColor = System.Drawing.Color.Crimson;
            this.button加入預覽.Name = "button加入預覽";
            this.button加入預覽.UseVisualStyleBackColor = false;
            this.button加入預覽.Click += new System.EventHandler(this.button加入預覽_Click);
            // 
            // button移除所選
            // 
            this.button移除所選.BackColor = System.Drawing.Color.White;
            this.button移除所選.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button移除所選, "button移除所選");
            this.button移除所選.ForeColor = System.Drawing.Color.Crimson;
            this.button移除所選.Name = "button移除所選";
            this.button移除所選.UseVisualStyleBackColor = false;
            this.button移除所選.Click += new System.EventHandler(this.button移除所選_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBox預覽
            // 
            this.checkedListBox預覽.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox預覽.CheckOnClick = true;
            this.checkedListBox預覽.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.checkedListBox預覽, "checkedListBox預覽");
            this.checkedListBox預覽.FormattingEnabled = true;
            this.checkedListBox預覽.Name = "checkedListBox預覽";
            this.checkedListBox預覽.SelectedIndexChanged += new System.EventHandler(this.checkedListBox預覽_SelectedIndexChanged);
            // 
            // 加入數量
            // 
            this.加入數量.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.加入數量, "加入數量");
            this.加入數量.ForeColor = System.Drawing.Color.Crimson;
            this.加入數量.Name = "加入數量";
            this.加入數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.加入數量.ValueChanged += new System.EventHandler(this.加入數量_ValueChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Name = "label9";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // comboBox班級
            // 
            this.comboBox班級.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.comboBox班級, "comboBox班級");
            this.comboBox班級.FormattingEnabled = true;
            this.comboBox班級.Name = "comboBox班級";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // comboBox店家
            // 
            resources.ApplyResources(this.comboBox店家, "comboBox店家");
            this.comboBox店家.FormattingEnabled = true;
            this.comboBox店家.Name = "comboBox店家";
            this.comboBox店家.SelectedIndexChanged += new System.EventHandler(this.comboBox店家_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // btn確認訂購
            // 
            resources.ApplyResources(this.btn確認訂購, "btn確認訂購");
            this.btn確認訂購.BackColor = System.Drawing.Color.White;
            this.btn確認訂購.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn確認訂購.ForeColor = System.Drawing.Color.Crimson;
            this.btn確認訂購.Name = "btn確認訂購";
            this.btn確認訂購.UseVisualStyleBackColor = false;
            this.btn確認訂購.Click += new System.EventHandler(this.button加入訂單_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::期中.Properties.Resources.eating;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.mydbDataSet1;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.pimageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            resources.ApplyResources(this.pnameDataGridViewTextBoxColumn, "pnameDataGridViewTextBoxColumn");
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            resources.ApplyResources(this.priceDataGridViewTextBoxColumn, "priceDataGridViewTextBoxColumn");
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // pimageDataGridViewTextBoxColumn
            // 
            this.pimageDataGridViewTextBoxColumn.DataPropertyName = "pimage";
            resources.ApplyResources(this.pimageDataGridViewTextBoxColumn, "pimageDataGridViewTextBoxColumn");
            this.pimageDataGridViewTextBoxColumn.Name = "pimageDataGridViewTextBoxColumn";
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
            // pnameTextBox
            // 
            this.pnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "pname", true));
            resources.ApplyResources(this.pnameTextBox, "pnameTextBox");
            this.pnameTextBox.Name = "pnameTextBox";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.productsBindingSource;
            this.listBox2.DisplayMember = "pname";
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Name = "listBox2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // btn收藏
            // 
            this.btn收藏.BackColor = System.Drawing.Color.White;
            this.btn收藏.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn收藏.FlatAppearance.BorderSize = 0;
            this.btn收藏.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn收藏, "btn收藏");
            this.btn收藏.ForeColor = System.Drawing.Color.Crimson;
            this.btn收藏.Name = "btn收藏";
            this.btn收藏.UseVisualStyleBackColor = false;
            this.btn收藏.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox10, "pictureBox10");
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::期中.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox12, "pictureBox12");
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabStop = false;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checklist餐點
            // 
            this.checklist餐點.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checklist餐點.CheckOnClick = true;
            this.checklist餐點.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.checklist餐點, "checklist餐點");
            this.checklist餐點.FormattingEnabled = true;
            this.checklist餐點.Name = "checklist餐點";
            this.checklist餐點.SelectedIndexChanged += new System.EventHandler(this.checklist餐點_SelectedIndexChanged);
            this.checklist餐點.DoubleClick += new System.EventHandler(this.checklist餐點_DoubleClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pnameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox店家);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox班級);
            this.Controls.Add(this.加入數量);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button移除所選);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn收藏);
            this.Controls.Add(this.btn確認訂購);
            this.Controls.Add(this.button加入預覽);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox預覽);
            this.Controls.Add(this.checklist餐點);
            this.HelpButton = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.加入數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button加入預覽;
        private System.Windows.Forms.Button button移除所選;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox checkedListBox預覽;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown 加入數量;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox班級;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox店家;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn確認訂購;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private mydbDataSet1TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pimageDataGridViewTextBoxColumn;
        private mydbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pnameTextBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn收藏;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checklist餐點;
    }
}

