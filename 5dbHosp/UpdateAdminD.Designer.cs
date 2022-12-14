
namespace _5dbHosp
{
    partial class UpdateAdminD
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
            this.idDoc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateSpec = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // idDoc
            // 
            this.idDoc.Location = new System.Drawing.Point(317, 80);
            this.idDoc.Name = "idDoc";
            this.idDoc.Size = new System.Drawing.Size(120, 20);
            this.idDoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id доктора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поменять специальность на";
            // 
            // updateSpec
            // 
            this.updateSpec.Location = new System.Drawing.Point(377, 146);
            this.updateSpec.Name = "updateSpec";
            this.updateSpec.Size = new System.Drawing.Size(100, 20);
            this.updateSpec.TabIndex = 5;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(285, 236);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "Update";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // UpdateAdminD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.updateSpec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idDoc);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAdminD";
            this.Text = "UpdateAdminD";
            ((System.ComponentModel.ISupportInitialize)(this.idDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown idDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox updateSpec;
        private System.Windows.Forms.Button OK;
    }
}