namespace Bai1_Server
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lsB1 = new System.Windows.Forms.ListBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(34, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(43, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "ClientIP";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(83, 10);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(345, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lsB1
            // 
            this.lsB1.FormattingEnabled = true;
            this.lsB1.Location = new System.Drawing.Point(37, 61);
            this.lsB1.Name = "lsB1";
            this.lsB1.Size = new System.Drawing.Size(579, 355);
            this.lsB1.TabIndex = 2;
            this.lsB1.SelectedIndexChanged += new System.EventHandler(this.lsB1_SelectedIndexChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(37, 458);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(476, 83);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(532, 458);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 83);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Send";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(532, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(121, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "CheckIP";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 553);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lsB1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ListBox lsB1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}



