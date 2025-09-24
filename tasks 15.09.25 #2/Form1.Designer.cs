namespace tasks_15._09._25__2
{
    partial class Form1
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
            textBox1 = new TextBox();
            labelResult = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.ForestGreen;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Historic", 15F);
            textBox1.Location = new Point(27, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 41);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Historic", 15F);
            labelResult.ForeColor = SystemColors.ButtonFace;
            labelResult.Location = new Point(144, 25);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(81, 35);
            labelResult.TabIndex = 3;
            labelResult.Text = "label1";
            labelResult.TextAlign = ContentAlignment.TopCenter;
            labelResult.Click += labelResult_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.ForestGreen;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(35, 278);
            button1.Name = "button1";
            button1.Size = new Size(229, 115);
            button1.TabIndex = 5;
            button1.Text = "Конвертировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(823, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(labelResult);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label labelResult;
        private ComboBox comboBox1;
        private Button button1;
    }
}
