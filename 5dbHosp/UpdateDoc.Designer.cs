
namespace _5dbHosp
{
    partial class UpdateDoc
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
            this.idPatient = new System.Windows.Forms.NumericUpDown();
            this.diagnosisPatient = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID пациента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сменить диагноз на";
            // 
            // idPatient
            // 
            this.idPatient.Location = new System.Drawing.Point(272, 47);
            this.idPatient.Name = "idPatient";
            this.idPatient.Size = new System.Drawing.Size(120, 20);
            this.idPatient.TabIndex = 2;
            // 
            // diagnosisPatient
            // 
            this.diagnosisPatient.Location = new System.Drawing.Point(272, 91);
            this.diagnosisPatient.Name = "diagnosisPatient";
            this.diagnosisPatient.Size = new System.Drawing.Size(100, 20);
            this.diagnosisPatient.TabIndex = 3;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(192, 149);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 4;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // UpdateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 191);
            this.Controls.Add(this.change);
            this.Controls.Add(this.diagnosisPatient);
            this.Controls.Add(this.idPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDoc";
            this.Text = "UpdateDoc";
            ((System.ComponentModel.ISupportInitialize)(this.idPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown idPatient;
        public System.Windows.Forms.TextBox diagnosisPatient;
        private System.Windows.Forms.Button change;
    }
}