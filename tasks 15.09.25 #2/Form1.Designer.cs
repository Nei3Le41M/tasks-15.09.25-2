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
            buttonUsdToKzt = new Button();
            buttonKztToUsd = new Button();
            textBox1 = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // buttonUsdToKzt
            // 
            buttonUsdToKzt.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point, 10);
            buttonUsdToKzt.Location = new Point(162, 205);
            buttonUsdToKzt.Name = "buttonUsdToKzt";
            buttonUsdToKzt.Size = new Size(192, 52);
            buttonUsdToKzt.TabIndex = 0;
            buttonUsdToKzt.Text = "Доллары в тенге";
            buttonUsdToKzt.UseVisualStyleBackColor = true;
            buttonUsdToKzt.Click += buttonUsdToKzt_Click;
            // 
            // buttonKztToUsd
            // 
            buttonKztToUsd.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point, 10);
            buttonKztToUsd.Location = new Point(454, 205);
            buttonKztToUsd.Name = "buttonKztToUsd";
            buttonKztToUsd.Size = new Size(189, 53);
            buttonKztToUsd.TabIndex = 1;
            buttonKztToUsd.Text = "Тенге в Доллары";
            buttonKztToUsd.UseVisualStyleBackColor = true;
            buttonKztToUsd.Click += buttonKztToUsd_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 15F);
            textBox1.Location = new Point(291, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 41);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Historic", 15F);
            labelResult.Location = new Point(151, 25);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(81, 35);
            labelResult.TabIndex = 3;
            labelResult.Text = "label1";
            labelResult.TextAlign = ContentAlignment.TopCenter;
            labelResult.Click += labelResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(labelResult);
            Controls.Add(textBox1);
            Controls.Add(buttonKztToUsd);
            Controls.Add(buttonUsdToKzt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUsdToKzt;
        private Button buttonKztToUsd;
        private TextBox textBox1;
        private Label labelResult;
    }
}
