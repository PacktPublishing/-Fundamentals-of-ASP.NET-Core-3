
using System;
using System.Windows;


namespace ItalyPizza1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string customerName = "", pizzaName =" Cheese Pizza ";

            double totalPrice = 9.99;

            Pizza myPizza = new Pizza(pizzaName, totalPrice);

            int controlNum = GetRadioButton();

            totalPrice = myPizza.GetPrice(controlNum);

            customerName = textBox.Text;

            // Print

            labelOrder.Content = customerName;

            label1PizzaDescriptiop.Content = myPizza.GetName();

            labelPrice.Content = totalPrice;

        }

        private int GetRadioButton()
        {
            int control = 0;

            if (rbPepperoni.IsChecked == true)
            {
                control = 1;
            }

            if (rbSausage.IsChecked == true)
            {
                control = 2;
            }

            return control;

        }
    }
}
