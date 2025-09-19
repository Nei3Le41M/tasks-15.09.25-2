using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tasks_15._09._25__2
{
    public partial class Form1 : Form
    {
        // константа курса
        private const double USD_TO_KZT = 540.5;

        public Form1()
        {
            InitializeComponent();

            // подписка на события
            buttonUsdToKzt.Click += buttonUsdToKzt_Click;
            buttonKztToUsd.Click += buttonKztToUsd_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Можно настроить начальное состояние формы
            labelResult.Text = "Введите сумму и выберите конвертацию";
        }

        private void buttonUsdToKzt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double usd))
            {
                double kzt = usd * USD_TO_KZT;
                labelResult.Text = $"{usd} $ = {kzt:F2} ₸";
            }
            else
            {
                labelResult.Text = "Введите число!";
            }
        }

        private void buttonKztToUsd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double kzt))
            {
                double usd = kzt / USD_TO_KZT;
                labelResult.Text = $"{kzt} ₸ = {usd:F2} $";
            }
            else
            {
                labelResult.Text = "Введите число!";
            }
        }
        private void labelResult_Click(object sender, EventArgs e)
        {

        }
        
    }
}

