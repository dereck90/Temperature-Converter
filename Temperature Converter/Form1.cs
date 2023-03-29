using System.CodeDom.Compiler;

namespace Temperature_Converter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbFarenheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCelcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKelvin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double farenheit = 0;
            double celsius = 0;
            double kelvin = 0;

            if (!string.IsNullOrEmpty(tbFarenheit.Text))
            {
                farenheit = double.Parse(tbFarenheit.Text);

                celsius = ((farenheit - 32) * 5) / 9;
                tbCelsius.Text = celsius.ToString();

                kelvin = (((farenheit - 32) * 5) / 9) + 273.15;
                tbKelvin.Text = kelvin.ToString();
            }
            else if (!string.IsNullOrEmpty(tbCelsius.Text))
            {
                celsius = double.Parse(tbCelsius.Text);

                farenheit = celsius * 1.8 + 32;
                tbFarenheit.Text = farenheit.ToString();

                kelvin = celsius + 273.15;
                tbKelvin.Text = kelvin.ToString();
            }
            else if (!string.IsNullOrEmpty(tbKelvin.Text))
            {
                kelvin = double.Parse(tbKelvin.Text);

                farenheit = (kelvin - 273.15) * 1.8 + 32;
                tbFarenheit.Text = farenheit.ToString();

                celsius = kelvin - 273.15;
                tbCelsius.Text = celsius.ToString();
            }
            else
            {
                MessageBox.Show("Please try again");
                if (!string.IsNullOrEmpty(tbCelsius.Text) && !string.IsNullOrEmpty(tbKelvin.Text))
                {
                    tbFarenheit.Text = "";
                    tbCelsius.Text = "";
                    tbKelvin.Text = "";
                    MessageBox.Show("Please write a number in one field at a time");
                }
                else
                {
                    if (double.TryParse(tbFarenheit.Text, out _))
                    {

                    }
                    else
                    {
                        tbFarenheit.Text = "";
                        MessageBox.Show("Only numbers accepted. Try Again");
                    }
                }
            }
        }

        private void lblCelcius_Click(object sender, EventArgs e)
        {

        }
    }
}