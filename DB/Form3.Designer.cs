namespace DB
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.repeatPasswordBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.Label();
            this.patronymicBox = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // repeatPasswordBox
            // 
            this.repeatPasswordBox.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c"});
            this.repeatPasswordBox.Location = new System.Drawing.Point(124, 172);
            this.repeatPasswordBox.Name = "repeatPasswordBox";
            this.repeatPasswordBox.PasswordChar = '*';
            this.repeatPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.repeatPasswordBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(12, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(29, 13);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Имя";
            // 
            // surnameBox
            // 
            this.surnameBox.AutoSize = true;
            this.surnameBox.Location = new System.Drawing.Point(12, 45);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(56, 13);
            this.surnameBox.TabIndex = 12;
            this.surnameBox.Text = "Фамилия";
            // 
            // patronymicBox
            // 
            this.patronymicBox.AutoSize = true;
            this.patronymicBox.Location = new System.Drawing.Point(12, 71);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(54, 13);
            this.patronymicBox.TabIndex = 13;
            this.patronymicBox.Text = "Отчество";
            // 
            // emailBox
            // 
            this.emailBox.AutoSize = true;
            this.emailBox.Location = new System.Drawing.Point(12, 97);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(32, 13);
            this.emailBox.TabIndex = 14;
            this.emailBox.Text = "Email";
            // 
            // usernameBox
            // 
            this.usernameBox.AutoSize = true;
            this.usernameBox.Location = new System.Drawing.Point(12, 123);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(38, 13);
            this.usernameBox.TabIndex = 15;
            this.usernameBox.Text = "Логин";
            // 
            // passwordBox
            // 
            this.passwordBox.AutoSize = true;
            this.passwordBox.Location = new System.Drawing.Point(12, 149);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(45, 13);
            this.passwordBox.TabIndex = 16;
            this.passwordBox.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Повторите пароль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Директор",
            "Менеджер",
            "Пользователь"});
            this.comboBox1.Location = new System.Drawing.Point(124, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 298);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.repeatPasswordBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox repeatPasswordBox;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Label surnameBox;
        private System.Windows.Forms.Label patronymicBox;
        private System.Windows.Forms.Label emailBox;
        private System.Windows.Forms.Label usernameBox;
        private System.Windows.Forms.Label passwordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}