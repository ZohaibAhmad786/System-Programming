namespace ClientTcpMachineLabTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSocre = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnRange = new System.Windows.Forms.Button();
            this.txtrang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given Number Between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Guess";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // btnSocre
            // 
            this.btnSocre.Location = new System.Drawing.Point(199, 178);
            this.btnSocre.Name = "btnSocre";
            this.btnSocre.Size = new System.Drawing.Size(75, 23);
            this.btnSocre.TabIndex = 6;
            this.btnSocre.Text = "Score";
            this.btnSocre.UseVisualStyleBackColor = true;
            this.btnSocre.Click += new System.EventHandler(this.btnSocre_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(63, 180);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 5;
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(199, 234);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(75, 23);
            this.btnRange.TabIndex = 9;
            this.btnRange.Text = "RAng";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // txtrang
            // 
            this.txtrang.Location = new System.Drawing.Point(63, 236);
            this.txtrang.Name = "txtrang";
            this.txtrang.Size = new System.Drawing.Size(100, 20);
            this.txtrang.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Quite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuite
            // 
            this.txtQuite.Location = new System.Drawing.Point(63, 280);
            this.txtQuite.Name = "txtQuite";
            this.txtQuite.Size = new System.Drawing.Size(100, 20);
            this.txtQuite.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Disconnect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuite);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.txtrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSocre);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSocre;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox txtrang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQuite;
        private System.Windows.Forms.Label label5;
    }
}

