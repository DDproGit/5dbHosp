
namespace _5dbHosp
{
    partial class InsertDoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.idDoc = new System.Windows.Forms.NumericUpDown();
            this.idRoom = new System.Windows.Forms.NumericUpDown();
            this.insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "diagnosis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "idRoom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "idDoctor";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(303, 13);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(303, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 8;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(303, 68);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(100, 20);
            this.patronymic.TabIndex = 9;
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(303, 99);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(100, 20);
            this.diagnosis.TabIndex = 10;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(303, 194);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 11;
            // 
            // idDoc
            // 
            this.idDoc.Location = new System.Drawing.Point(303, 127);
            this.idDoc.Name = "idDoc";
            this.idDoc.Size = new System.Drawing.Size(120, 20);
            this.idDoc.TabIndex = 12;
            // 
            // idRoom
            // 
            this.idRoom.Location = new System.Drawing.Point(303, 159);
            this.idRoom.Name = "idRoom";
            this.idRoom.Size = new System.Drawing.Size(120, 20);
            this.idRoom.TabIndex = 13;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(248, 286);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 14;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // InsertDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.idRoom);
            this.Controls.Add(this.idDoc);
            this.Controls.Add(this.login);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertDoc";
            this.Text = "InsertDoc";
            ((System.ComponentModel.ISupportInitialize)(this.idDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox surname;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox patronymic;
        public System.Windows.Forms.TextBox diagnosis;
        public System.Windows.Forms.TextBox login;
        public System.Windows.Forms.NumericUpDown idDoc;
        public System.Windows.Forms.NumericUpDown idRoom;
        private System.Windows.Forms.Button insert;
    }
}