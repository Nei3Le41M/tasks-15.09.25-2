using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tasks_15._09._25__2
{
    public partial class Form1 : Form
    {
        private const double USD_TO_KZT = 542.75;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("USD => KZT");
            comboBox1.Items.Add("KZT => USD");
            comboBox1.SelectedIndex = 0;

            button1.Click += button1_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = "Введите сумму и выберите конвертацию";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                labelResult.Text = "Введите число!";
                return;
            }

            string selected = comboBox1.SelectedItem.ToString();

            if (selected == "USD => KZT")
            {
                double kzt = value * USD_TO_KZT;
                labelResult.Text = $"{value} $ = {kzt:F2} ₸";
            }
            else if (selected == "KZT => USD")
            {
                double usd = value / USD_TO_KZT;
                labelResult.Text = $"{value} ₸ = {usd:F2} $";
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

    }
}

