namespace WinFormsUI
{
    partial class Transactions
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F);
            label1.Location = new Point(54, 31);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 0;
            label1.Text = "Credit Card Machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label2.Location = new Point(80, 112);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label3.Location = new Point(80, 168);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 112);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 3;
            label4.Text = "TimCorey";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 168);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(222, 166);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 30);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(95, 229);
            button1.Name = "button1";
            button1.Size = new Size(268, 70);
            button1.TabIndex = 6;
            button1.Text = "Make Purchase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(127, 317);
            label6.Name = "label6";
            label6.Size = new Size(187, 24);
            label6.TabIndex = 7;
            label6.Text = "You are overdrafting";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 368);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transactions";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label6;
    }
}