
namespace 期中
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
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.White;
            this.pictureBox23.Image = global::期中.Properties.Resources.icons8_user_96__2_;
            this.pictureBox23.Location = new System.Drawing.Point(265, 13);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(163, 113);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox23.TabIndex = 1;
            this.pictureBox23.TabStop = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox2.Hint = "請輸入密碼";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(207, 221);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(327, 50);
            this.materialTextBox2.TabIndex = 5;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialSingleLineTextField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSingleLineTextField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField2.Hint = "請輸入學員編號";
            this.materialSingleLineTextField2.LeadingIcon = null;
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(207, 154);
            this.materialSingleLineTextField2.MaxLength = 50;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialSingleLineTextField2.Multiline = false;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(327, 50);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.Text = "";
            this.materialSingleLineTextField2.TrailingIcon = null;
            this.materialSingleLineTextField2.TextChanged += new System.EventHandler(this.materialSingleLineTextField2_TextChanged);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.White;
            this.btn登入.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn登入.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn登入.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn登入.ForeColor = System.Drawing.Color.Crimson;
            this.btn登入.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn登入.Location = new System.Drawing.Point(207, 309);
            this.btn登入.Margin = new System.Windows.Forms.Padding(4);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(327, 35);
            this.btn登入.TabIndex = 38;
            this.btn登入.Text = "登入系統";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn登入);
            this.panel1.Controls.Add(this.pictureBox23);
            this.panel1.Controls.Add(this.materialTextBox2);
            this.panel1.Controls.Add(this.materialSingleLineTextField2);
            this.panel1.Location = new System.Drawing.Point(39, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 392);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(144, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(144, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "編號:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(766, 492);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form6";
            this.Opacity = 0.8D;
            this.Text = "登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox23;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialSingleLineTextField2;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}