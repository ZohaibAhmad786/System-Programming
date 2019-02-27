namespace _7ThTaskAssignmentDatabase
{
    partial class Grouping_Assignment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgviewStudentRec = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLStudata = new System.Windows.Forms.Button();
            this.btnDispStuData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewStudentRec)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgviewStudentRec);
            this.groupBox1.Location = new System.Drawing.Point(32, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // dgviewStudentRec
            // 
            this.dgviewStudentRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewStudentRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewStudentRec.Location = new System.Drawing.Point(6, 19);
            this.dgviewStudentRec.Name = "dgviewStudentRec";
            this.dgviewStudentRec.Size = new System.Drawing.Size(438, 243);
            this.dgviewStudentRec.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDispStuData);
            this.groupBox2.Controls.Add(this.btnLStudata);
            this.groupBox2.Location = new System.Drawing.Point(32, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnLStudata
            // 
            this.btnLStudata.Location = new System.Drawing.Point(74, 32);
            this.btnLStudata.Name = "btnLStudata";
            this.btnLStudata.Size = new System.Drawing.Size(141, 23);
            this.btnLStudata.TabIndex = 0;
            this.btnLStudata.Text = "Load Student Data";
            this.btnLStudata.UseVisualStyleBackColor = true;
            this.btnLStudata.Click += new System.EventHandler(this.btnLStudata_Click);
            // 
            // btnDispStuData
            // 
            this.btnDispStuData.Location = new System.Drawing.Point(264, 32);
            this.btnDispStuData.Name = "btnDispStuData";
            this.btnDispStuData.Size = new System.Drawing.Size(141, 23);
            this.btnDispStuData.TabIndex = 1;
            this.btnDispStuData.Text = "Display highest GPA";
            this.btnDispStuData.UseVisualStyleBackColor = true;
            this.btnDispStuData.Click += new System.EventHandler(this.btnDispStuData_Click);
            // 
            // Grouping_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Grouping_Assignment";
            this.Text = "Grouping_Assignment";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewStudentRec)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgviewStudentRec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDispStuData;
        private System.Windows.Forms.Button btnLStudata;
    }
}