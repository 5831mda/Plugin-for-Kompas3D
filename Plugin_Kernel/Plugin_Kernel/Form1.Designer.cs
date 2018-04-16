namespace Plugin_Kernel
{
    partial class Form
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.F2textBox = new System.Windows.Forms.TextBox();
            this.F1textBox = new System.Windows.Forms.TextBox();
            this.D2textBox = new System.Windows.Forms.TextBox();
            this.D1textBox = new System.Windows.Forms.TextBox();
            this.L2textBox = new System.Windows.Forms.TextBox();
            this.L1textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(13, 13);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(107, 12);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(75, 23);
            this.ClosedButton.TabIndex = 1;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.F2textBox);
            this.groupBox1.Controls.Add(this.F1textBox);
            this.groupBox1.Controls.Add(this.D2textBox);
            this.groupBox1.Controls.Add(this.D1textBox);
            this.groupBox1.Controls.Add(this.L2textBox);
            this.groupBox1.Controls.Add(this.L1textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры построения детали";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Максимальные параметры",
            "Рекомендованные параметры",
            "Минимальные параметры"});
            this.comboBox1.Location = new System.Drawing.Point(210, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 23);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Enabled = false;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(13, 214);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // F2textBox
            // 
            this.F2textBox.Location = new System.Drawing.Point(295, 183);
            this.F2textBox.MaxLength = 2;
            this.F2textBox.Name = "F2textBox";
            this.F2textBox.Size = new System.Drawing.Size(100, 25);
            this.F2textBox.TabIndex = 11;
            this.F2textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.F2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // F1textBox
            // 
            this.F1textBox.Location = new System.Drawing.Point(295, 152);
            this.F1textBox.MaxLength = 3;
            this.F1textBox.Name = "F1textBox";
            this.F1textBox.Size = new System.Drawing.Size(100, 25);
            this.F1textBox.TabIndex = 10;
            this.F1textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.F1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // D2textBox
            // 
            this.D2textBox.Location = new System.Drawing.Point(295, 121);
            this.D2textBox.MaxLength = 3;
            this.D2textBox.Name = "D2textBox";
            this.D2textBox.Size = new System.Drawing.Size(100, 25);
            this.D2textBox.TabIndex = 9;
            this.D2textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.D2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // D1textBox
            // 
            this.D1textBox.Location = new System.Drawing.Point(295, 90);
            this.D1textBox.MaxLength = 3;
            this.D1textBox.Name = "D1textBox";
            this.D1textBox.Size = new System.Drawing.Size(100, 25);
            this.D1textBox.TabIndex = 8;
            this.D1textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.D1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // L2textBox
            // 
            this.L2textBox.Location = new System.Drawing.Point(295, 59);
            this.L2textBox.MaxLength = 3;
            this.L2textBox.Name = "L2textBox";
            this.L2textBox.Size = new System.Drawing.Size(100, 25);
            this.L2textBox.TabIndex = 7;
            this.L2textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.L2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // L1textBox
            // 
            this.L1textBox.Location = new System.Drawing.Point(295, 28);
            this.L1textBox.MaxLength = 3;
            this.L1textBox.Name = "L1textBox";
            this.L1textBox.Size = new System.Drawing.Size(100, 25);
            this.L1textBox.TabIndex = 6;
            this.L1textBox.TextChanged += new System.EventHandler(this.AlltextBox_TextChanged);
            this.L1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Угол выдавливания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Длина фаски";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Радиус верхней части стержня";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радиус нижней части стержня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина верхней части стержня";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина нижней части стержня";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.OpenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form";
            this.Text = "Плагин для создания детали";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox F2textBox;
        private System.Windows.Forms.TextBox F1textBox;
        private System.Windows.Forms.TextBox D2textBox;
        private System.Windows.Forms.TextBox D1textBox;
        private System.Windows.Forms.TextBox L2textBox;
        private System.Windows.Forms.TextBox L1textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

