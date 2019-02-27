namespace _7ThTaskAssignmentDatabase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadRecord = new System.Windows.Forms.Button();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDispRecord = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPreviousRec = new System.Windows.Forms.Button();
            this.btnNextRec = new System.Windows.Forms.Button();
            this.lblPagination = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispRecord)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnLoadRecord);
            this.groupBox1.Controls.Add(this.txtRec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnLoadRecord
            // 
            this.btnLoadRecord.Location = new System.Drawing.Point(435, 19);
            this.btnLoadRecord.Name = "btnLoadRecord";
            this.btnLoadRecord.Size = new System.Drawing.Size(79, 23);
            this.btnLoadRecord.TabIndex = 3;
            this.btnLoadRecord.Text = "Load Record";
            this.btnLoadRecord.UseVisualStyleBackColor = true;
            this.btnLoadRecord.Click += new System.EventHandler(this.btnLoadRecord_Click);
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(274, 21);
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(100, 20);
            this.txtRec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Of Record To Show";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDispRecord);
            this.groupBox2.Location = new System.Drawing.Point(42, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Record";
            // 
            // dgvDispRecord
            // 
            this.dgvDispRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDispRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDispRecord.Location = new System.Drawing.Point(6, 19);
            this.dgvDispRecord.Name = "dgvDispRecord";
            this.dgvDispRecord.Size = new System.Drawing.Size(655, 270);
            this.dgvDispRecord.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPreviousRec);
            this.groupBox3.Controls.Add(this.btnNextRec);
            this.groupBox3.Controls.Add(this.lblPagination);
            this.groupBox3.Location = new System.Drawing.Point(42, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 58);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagination";
            // 
            // btnPreviousRec
            // 
            this.btnPreviousRec.Location = new System.Drawing.Point(116, 19);
            this.btnPreviousRec.Name = "btnPreviousRec";
            this.btnPreviousRec.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousRec.TabIndex = 3;
            this.btnPreviousRec.Text = "<<";
            this.btnPreviousRec.UseVisualStyleBackColor = true;
            this.btnPreviousRec.Click += new System.EventHandler(this.btnPreviousRec_Click);
            // 
            // btnNextRec
            // 
            this.btnNextRec.Location = new System.Drawing.Point(439, 19);
            this.btnNextRec.Name = "btnNextRec";
            this.btnNextRec.Size = new System.Drawing.Size(75, 23);
            this.btnNextRec.TabIndex = 3;
            this.btnNextRec.Text = ">>";
            this.btnNextRec.UseVisualStyleBackColor = true;
            this.btnNextRec.Click += new System.EventHandler(this.btnNextRec_Click);
            // 
            // lblPagination
            // 
            this.lblPagination.AutoSize = true;
            this.lblPagination.Location = new System.Drawing.Point(248, 24);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(140, 13);
            this.lblPagination.TabIndex = 1;
            this.lblPagination.Text = "List of Record Show in B/W";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Arid_No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full_Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "City";
            this.Column3.Name = "Column3";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(547, 18);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(89, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear Gridview";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispRecord)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoadRecord;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousRec;
        private System.Windows.Forms.Button btnNextRec;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.DataGridView dgvDispRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnclear;
    }
}

