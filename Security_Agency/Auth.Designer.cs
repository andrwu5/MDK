namespace Security_Agency
{
    partial class Auth
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
            this.btRegistration = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbUser_Password = new System.Windows.Forms.TextBox();
            this.tbUser_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(174, 306);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(123, 44);
            this.btRegistration.TabIndex = 13;
            this.btRegistration.Text = "Регистрация";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(184, 259);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 41);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(184, 213);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(101, 40);
            this.btEnter.TabIndex = 11;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbUser_Password
            // 
            this.tbUser_Password.Location = new System.Drawing.Point(139, 155);
            this.tbUser_Password.Name = "tbUser_Password";
            this.tbUser_Password.PasswordChar = '*';
            this.tbUser_Password.Size = new System.Drawing.Size(199, 22);
            this.tbUser_Password.TabIndex = 10;
            // 
            // tbUser_Login
            // 
            this.tbUser_Login.Location = new System.Drawing.Point(139, 75);
            this.tbUser_Login.Name = "tbUser_Login";
            this.tbUser_Login.Size = new System.Drawing.Size(199, 22);
            this.tbUser_Login.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите логин";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 390);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUser_Password);
            this.Controls.Add(this.tbUser_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbUser_Password;
        private System.Windows.Forms.TextBox tbUser_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

