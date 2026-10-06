using CarolineLoveProject1.Model;

namespace CarolineLoveProject1.View
{
    /// <summary>
    /// The AddCarForm class represents a form that allows users to add a new car to the inventory.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddCarForm : Form
    {
        /// <summary>
        /// The car property.
        /// </summary>
        /// <value>
        /// The car.
        /// </value>
        public Car? Car { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AddCarForm class.
        /// </summary>
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddCarButtonClick(object sender, EventArgs e)
        {
            bool addSuccessful;
            try
            {
                var make = makeTextBox.Text;
                var model = modelTextBox.Text;
                var mpg = decimal.Parse(mpgTextBox.Text);
                var price = decimal.Parse(priceTextBox.Text);

                if (!string.IsNullOrWhiteSpace(make) && !string.IsNullOrWhiteSpace(model) && mpg > 0.00m && price > 0.00m)
                {
                    Car = new Car(make, model, mpg, price);
                    addSuccessful = true;
                }
                else
                {
                    DisplayMessage("Please enter valid values for all fields.", "Error", MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                DisplayMessage("Please enter valid values for all fields.", "Error", MessageBoxIcon.Error);
                return;
            }

            if (addSuccessful)
            {
                DisplayMessage("Car added successfully!", "Success", MessageBoxIcon.Information);
                Close();
            }
        }

        private static void DisplayMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }
    }
}
