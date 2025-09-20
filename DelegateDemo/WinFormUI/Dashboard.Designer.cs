namespace WinFormUI
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(73, 289);
            button1.Name = "button1";
            button1.Size = new Size(253, 93);
            button1.TabIndex = 0;
            button1.Text = "MessageBox Demo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(441, 289);
            button2.Name = "button2";
            button2.Size = new Size(253, 93);
            button2.TabIndex = 1;
            button2.Text = "TextBox Demo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 30);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 55);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 4;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 163);
            label2.Name = "label2";
            label2.Size = new Size(53, 24);
            label2.TabIndex = 6;
            label2.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 30);
            textBox1.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}
