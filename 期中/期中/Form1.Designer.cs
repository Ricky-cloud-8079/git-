
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checklist餐點 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button加入預覽 = new System.Windows.Forms.Button();
            this.button移除所選 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBox預覽 = new System.Windows.Forms.CheckedListBox();
            this.加入數量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox班級 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox店家 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.加入訂單 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.加入數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // checklist餐點
            // 
            this.checklist餐點.CheckOnClick = true;
            this.checklist餐點.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.checklist餐點, "checklist餐點");
            this.checklist餐點.FormattingEnabled = true;
            this.checklist餐點.Name = "checklist餐點";
            this.checklist餐點.SelectedIndexChanged += new System.EventHandler(this.checklist餐點_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 12, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
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
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBox預覽
            // 
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
            resources.ApplyResources(this.comboBox班級, "comboBox班級");
            this.comboBox班級.FormattingEnabled = true;
            this.comboBox班級.Name = "comboBox班級";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::期中.Properties.Resources.eating;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // 加入訂單
            // 
            this.加入訂單.BackColor = System.Drawing.Color.White;
            this.加入訂單.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.加入訂單, "加入訂單");
            this.加入訂單.ForeColor = System.Drawing.Color.Crimson;
            this.加入訂單.Name = "加入訂單";
            this.加入訂單.UseVisualStyleBackColor = false;
            this.加入訂單.Click += new System.EventHandler(this.button加入訂單_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.comboBox店家);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox班級);
            this.Controls.Add(this.加入數量);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button移除所選);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.加入訂單);
            this.Controls.Add(this.button加入預覽);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox預覽);
            this.Controls.Add(this.checklist餐點);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.加入數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklist餐點;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox店家;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button 加入訂單;
    }
}

