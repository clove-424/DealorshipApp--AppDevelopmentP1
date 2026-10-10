using CarolineLoveProject1.Model;

namespace CarolineLoveProject1.View
{
    /// <summary>
    /// The AddShopperForm class represents a form for adding a new shopper with properties for name and money available.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddShopperForm : Form
    {
        /// <summary>
        /// The Shopper property.
        /// </summary>
        /// <value>
        /// The shopper.
        /// </value>
        public Shopper? Shopper { get; private set; }

        /// <summary>
        /// Initializes a new instance of a AddShopperForm.
        /// </summary>
        public AddShopperForm()
        {
            InitializeComponent();
        }

        private void AddShopperButtonClick(object sender, EventArgs e)
        {
            var addSuccessful = false;
            try
            {
                var name = shopperNameTextBox.Text;
                var moneyAvailable = decimal.Parse(moneyAvailableTextBox.Text);
                if (!string.IsNullOrEmpty(name) && moneyAvailable >= 0)
                {
                    Shopper = new Shopper(name, moneyAvailable);
                    addSuccessful = true;
                }
                else
                {
                    MessageBox.Show("Please enter valid information for both fields.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid information for both fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (addSuccessful)
            {
                MessageBox.Show("Shopper added successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
