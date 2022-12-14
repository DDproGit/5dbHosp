
namespace _5dbHosp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameDoc = new System.Windows.Forms.TextBox();
            this.passDoc = new System.Windows.Forms.TextBox();
            this.namePatient = new System.Windows.Forms.TextBox();
            this.passPatient = new System.Windows.Forms.TextBox();
            this.loginDoc = new System.Windows.Forms.Button();
            this.loginPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация для врачей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Авторизация для пациентов";
            // 
            // nameDoc
            // 
            this.nameDoc.Location = new System.Drawing.Point(136, 75);
            this.nameDoc.Name = "nameDoc";
            this.nameDoc.Size = new System.Drawing.Size(100, 20);
            this.nameDoc.TabIndex = 6;
            // 
            // passDoc
            // 
            this.passDoc.Location = new System.Drawing.Point(136, 125);
            this.passDoc.Name = "passDoc";
            this.passDoc.Size = new System.Drawing.Size(100, 20);
            this.passDoc.TabIndex = 7;
            // 
            // namePatient
            // 
            this.namePatient.Location = new System.Drawing.Point(553, 78);
            this.namePatient.Name = "namePatient";
            this.namePatient.Size = new System.Drawing.Size(100, 20);
            this.namePatient.TabIndex = 8;
            // 
            // passPatient
            // 
            this.passPatient.Location = new System.Drawing.Point(553, 125);
            this.passPatient.Name = "passPatient";
            this.passPatient.Size = new System.Drawing.Size(100, 20);
            this.passPatient.TabIndex = 9;
            // 
            // loginDoc
            // 
            this.loginDoc.Location = new System.Drawing.Point(76, 214);
            this.loginDoc.Name = "loginDoc";
            this.loginDoc.Size = new System.Drawing.Size(75, 23);
            this.loginDoc.TabIndex = 10;
            this.loginDoc.Text = "Login";
            this.loginDoc.UseVisualStyleBackColor = true;
            // 
            // loginPatient
            // 
            this.loginPatient.Location = new System.Drawing.Point(493, 213);
            this.loginPatient.Name = "loginPatient";
            this.loginPatient.Size = new System.Drawing.Size(75, 23);
            this.loginPatient.TabIndex = 11;
            this.loginPatient.Text = "Login";
            this.loginPatient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPatient);
            this.Controls.Add(this.loginDoc);
            this.Controls.Add(this.passPatient);
            this.Controls.Add(this.namePatient);
            this.Controls.Add(this.passDoc);
            this.Controls.Add(this.nameDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameDoc;
        private System.Windows.Forms.TextBox passDoc;
        private System.Windows.Forms.TextBox namePatient;
        private System.Windows.Forms.TextBox passPatient;
        private System.Windows.Forms.Button loginDoc;
        private System.Windows.Forms.Button loginPatient;
    }
}

