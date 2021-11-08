
namespace Method_of_calculation_3
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.dtGdVw = new System.Windows.Forms.DataGridView();
            this.rd_Btn1 = new System.Windows.Forms.RadioButton();
            this.rd_Btn2 = new System.Windows.Forms.RadioButton();
            this.rd_Btn3 = new System.Windows.Forms.RadioButton();
            this.Result_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGdVw
            // 
            this.dtGdVw.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtGdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtGdVw.Location = new System.Drawing.Point(13, 13);
            this.dtGdVw.Name = "dtGdVw";
            this.dtGdVw.RowHeadersWidth = 51;
            this.dtGdVw.RowTemplate.Height = 24;
            this.dtGdVw.Size = new System.Drawing.Size(829, 466);
            this.dtGdVw.TabIndex = 0;
            // 
            // rd_Btn1
            // 
            this.rd_Btn1.AutoSize = true;
            this.rd_Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rd_Btn1.Location = new System.Drawing.Point(13, 485);
            this.rd_Btn1.Name = "rd_Btn1";
            this.rd_Btn1.Size = new System.Drawing.Size(216, 24);
            this.rd_Btn1.TabIndex = 1;
            this.rd_Btn1.TabStop = true;
            this.rd_Btn1.Text = "y=6x^5 на отрезке [0,1]";
            this.rd_Btn1.UseVisualStyleBackColor = true;
            // 
            // rd_Btn2
            // 
            this.rd_Btn2.AutoSize = true;
            this.rd_Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rd_Btn2.Location = new System.Drawing.Point(589, 515);
            this.rd_Btn2.Name = "rd_Btn2";
            this.rd_Btn2.Size = new System.Drawing.Size(80, 24);
            this.rd_Btn2.TabIndex = 2;
            this.rd_Btn2.TabStop = true;
            this.rd_Btn2.Text = "[0, 1.5]";
            this.rd_Btn2.UseVisualStyleBackColor = true;
            // 
            // rd_Btn3
            // 
            this.rd_Btn3.AutoSize = true;
            this.rd_Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rd_Btn3.Location = new System.Drawing.Point(589, 545);
            this.rd_Btn3.Name = "rd_Btn3";
            this.rd_Btn3.Size = new System.Drawing.Size(111, 24);
            this.rd_Btn3.TabIndex = 3;
            this.rd_Btn3.TabStop = true;
            this.rd_Btn3.Text = "[0.001, 1.5]";
            this.rd_Btn3.UseVisualStyleBackColor = true;
            // 
            // Result_btn
            // 
            this.Result_btn.BackColor = System.Drawing.Color.Coral;
            this.Result_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_btn.ForeColor = System.Drawing.Color.Black;
            this.Result_btn.Location = new System.Drawing.Point(351, 504);
            this.Result_btn.Name = "Result_btn";
            this.Result_btn.Size = new System.Drawing.Size(153, 48);
            this.Result_btn.TabIndex = 4;
            this.Result_btn.Text = "Результат";
            this.Result_btn.UseVisualStyleBackColor = false;
            this.Result_btn.Click += new System.EventHandler(this.Result_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(589, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "x^(1/30)*sqrt(1+x^2) на отрезке:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "n";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kd";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "d Точное";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "d Рунге";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "d Теоретическое";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(855, 592);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rd_Btn2);
            this.Controls.Add(this.Result_btn);
            this.Controls.Add(this.rd_Btn3);
            this.Controls.Add(this.rd_Btn1);
            this.Controls.Add(this.dtGdVw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3";
            ((System.ComponentModel.ISupportInitialize)(this.dtGdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGdVw;
        private System.Windows.Forms.RadioButton rd_Btn1;
        private System.Windows.Forms.RadioButton rd_Btn2;
        private System.Windows.Forms.RadioButton rd_Btn3;
        private System.Windows.Forms.Button Result_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

