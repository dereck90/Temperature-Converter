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

            if (string.IsNullOrEmpty(tbFarenheit.Text) && string.IsNullOrEmpty(tbCelsius.Text) && string.IsNullOrEmpty(tbKelvin.Text))
            {
                tbFarenheit.Text = "";
                tbCelsius.Text = "";
                tbKelvin.Text = "";
                MessageBox.Show("Fields can't be empty. Please write only in one field.");
            }
            else if (!string.IsNullOrEmpty(tbFarenheit.Text) && !string.IsNullOrEmpty(tbCelsius.Text) && !string.IsNullOrEmpty(tbKelvin.Text))
            {
                tbFarenheit.Text = "";
                tbCelsius.Text = "";
                tbKelvin.Text = "";
                MessageBox.Show("All fields can't be full. Please write only in one field.");
            }
            else
            {
                if (!string.IsNullOrEmpty(tbFarenheit.Text) && double.TryParse(tbFarenheit.Text, out _))
                {
                    farenheit = double.Parse(tbFarenheit.Text);

                    celsius = (farenheit - 32) / 1.8;
                    tbCelsius.Text = celsius.ToString();

                    kelvin = (farenheit - 32) / 1.8 + 273.15;
                    tbKelvin.Text = kelvin.ToString();
                }
                else if (!string.IsNullOrEmpty(tbCelsius.Text) && double.TryParse(tbCelsius.Text, out _))
                {
                    celsius = double.Parse(tbCelsius.Text);

                    farenheit = celsius * 1.8 + 32;
                    tbFarenheit.Text = farenheit.ToString();

                    kelvin = celsius + 273.15;
                    tbKelvin.Text = kelvin.ToString();
                }
                else if (!string.IsNullOrEmpty(tbKelvin.Text) && double.TryParse(tbKelvin.Text, out _))
                {
                    kelvin = double.Parse(tbKelvin.Text);

                    farenheit = (kelvin - 273.15) * 1.8 + 32;
                    tbFarenheit.Text = farenheit.ToString();

                    celsius = kelvin - 273.15;
                    tbCelsius.Text = celsius.ToString();
                }
                else
                {
                    tbFarenheit.Text = "";
                    tbCelsius.Text = "";
                    tbKelvin.Text = "";
                    MessageBox.Show("Only numbers accepted. Try Again");
                }
            }
        }

        private void lblCelcius_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbFarenheit.Text = "";
            tbCelsius.Text = "";
            tbKelvin.Text = "";
        }
    }
}