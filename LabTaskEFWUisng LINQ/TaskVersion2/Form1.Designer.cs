namespace TaskVersion2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFirstTask = new System.Windows.Forms.Button();
            this.btnSecondTask = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnFirstTask
            // 
            this.btnFirstTask.Location = new System.Drawing.Point(56, 189);
            this.btnFirstTask.Name = "btnFirstTask";
            this.btnFirstTask.Size = new System.Drawing.Size(75, 23);
            this.btnFirstTask.TabIndex = 1;
            this.btnFirstTask.Text = "FirstTask";
            this.btnFirstTask.UseVisualStyleBackColor = true;
            this.btnFirstTask.Click += new System.EventHandler(this.btnFirstTask_Click);
            // 
            // btnSecondTask
            // 
            this.btnSecondTask.Location = new System.Drawing.Point(203, 189);
            this.btnSecondTask.Name = "btnSecondTask";
            this.btnSecondTask.Size = new System.Drawing.Size(75, 23);
            this.btnSecondTask.TabIndex = 2;
            this.btnSecondTask.Text = "SecondTask";
            this.btnSecondTask.UseVisualStyleBackColor = true;
            this.btnSecondTask.Click += new System.EventHandler(this.btnSecondTask_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.btnSecondTask);
            this.Controls.Add(this.btnFirstTask);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFirstTask;
        private System.Windows.Forms.Button btnSecondTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

