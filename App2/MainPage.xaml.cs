using System;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kgEntry.Text))
            {
                double kgValue = Convert.ToDouble(kgEntry.Text);
                double poundsValue = ConversionUtils.KilogramosALibras(kgValue);
                poundsLabel.Text = $"Libras: {poundsValue:F2}";
            }

            if (!string.IsNullOrEmpty(litrosEntry.Text))
            {
                double litrosValue = Convert.ToDouble(litrosEntry.Text);
                double galonesValue = ConversionUtils.LitrosAGalones(litrosValue);
                galonesLabel.Text = $"Galones: {galonesValue:F2}";
            }

            if (!string.IsNullOrEmpty(celsiusEntry.Text))
            {
                double celsiusValue = Convert.ToDouble(celsiusEntry.Text);
                double fahrenheitValue = ConversionUtils.CelsiusAFahrenheit(celsiusValue);
                fahrenheitLabel.Text = $"Fahrenheit: {fahrenheitValue:F2}";
            }
        }
    }

    public static class ConversionUtils
    {
        public static double KilogramosALibras(double kilogramos)
        {
            return kilogramos * 2.20462;
        }

        public static double LitrosAGalones(double litros)
        {
            return litros * 0.264172;
        }

        public static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
