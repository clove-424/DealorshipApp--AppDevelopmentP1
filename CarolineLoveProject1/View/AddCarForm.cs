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

        private void BackToMainMenuClick(object sender, EventArgs e)
        {
            Car = null;

            Close();
        }

        private void AddCarButtonClick(object sender, EventArgs e)
        {
            var make = makeTextBox.Text;
            var model = modelTextBox.Text;
            var mpg = decimal.Parse(mpgTextBox.Text);
            var price = decimal.Parse(priceTextBox.Text);

            ValidationCheck(make, model, mpg, price);
        }

        private void ValidationCheck(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                MessageBox.Show("Make is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Model is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mpg <= 0)
            {
                MessageBox.Show("MPG must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Car = new Car(make, model, mpg, price);
                MessageBox.Show("Car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
