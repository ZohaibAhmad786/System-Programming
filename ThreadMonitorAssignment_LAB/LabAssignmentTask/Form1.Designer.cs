namespace LabAssignmentTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtintervalValue = new System.Windows.Forms.TextBox();
            this.txtstartValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.txtendValue = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtintervalValue);
            this.groupBox1.Controls.Add(this.txtstartValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnMonitor);
            this.groupBox1.Controls.Add(this.txtendValue);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(106, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 344);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Value";
            // 
            // txtintervalValue
            // 
            this.txtintervalValue.Location = new System.Drawing.Point(144, 161);
            this.txtintervalValue.Name = "txtintervalValue";
            this.txtintervalValue.Size = new System.Drawing.Size(100, 20);
            this.txtintervalValue.TabIndex = 7;
            // 
            // txtstartValue
            // 
            this.txtstartValue.Location = new System.Drawing.Point(144, 56);
            this.txtstartValue.Name = "txtstartValue";
            this.txtstartValue.Size = new System.Drawing.Size(100, 20);
            this.txtstartValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval Value";
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(108, 232);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(96, 29);
            this.btnMonitor.TabIndex = 2;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // txtendValue
            // 
            this.txtendValue.Location = new System.Drawing.Point(144, 109);
            this.txtendValue.Name = "txtendValue";
            this.txtendValue.Size = new System.Drawing.Size(100, 20);
            this.txtendValue.TabIndex = 5;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(108, 267);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(96, 30);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtintervalValue;
        private System.Windows.Forms.TextBox txtstartValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.TextBox txtendValue;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label2;
    }
}

