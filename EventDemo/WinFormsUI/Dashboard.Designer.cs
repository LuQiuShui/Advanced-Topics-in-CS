namespace WinFormsUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(224, 39);
            label1.TabIndex = 0;
            label1.Text = "Banking demo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 129);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 2;
            label3.Text = "TimCorey";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 197);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 3;
            label4.Text = "Checking Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 197);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 4;
            label5.Text = "$155.43";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label6.Location = new Point(24, 269);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 5;
            label6.Text = "Saving Balance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 270);
            label7.Name = "label7";
            label7.Size = new Size(69, 24);
            label7.TabIndex = 6;
            label7.Text = "$98.45";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(350, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 292);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(605, 129);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(234, 292);
            listBox2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 85);
            label8.Name = "label8";
            label8.Size = new Size(0, 24);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label9.Location = new Point(350, 84);
            label9.Name = "label9";
            label9.Size = new Size(214, 25);
            label9.TabIndex = 10;
            label9.Text = "Checking Transactions";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label10.Location = new Point(605, 85);
            label10.Name = "label10";
            label10.Size = new Size(191, 25);
            label10.TabIndex = 11;
            label10.Text = "Saving Transactions";
            // 
            // button1
            // 
            button1.Location = new Point(59, 361);
            button1.Name = "button1";
            button1.Size = new Size(202, 77);
            button1.TabIndex = 12;
            button1.Text = "Record Transactions";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Brown;
            label11.Location = new Point(350, 46);
            label11.Name = "label11";
            label11.Size = new Size(74, 24);
            label11.TabIndex = 13;
            label11.Text = "label11";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(116, 314);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 28);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Stop";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private CheckBox checkBox1;
    }
}
