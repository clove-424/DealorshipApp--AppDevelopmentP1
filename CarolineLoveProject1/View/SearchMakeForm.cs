using CarolineLoveProject1.Model;

namespace CarolineLoveProject1.View
{
    /// <summary>
    /// The SearchMakeForm class represents a form that allows users to search for cars by their make in the car lot.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchMakeForm : Form
    {
        private readonly CarLotForm _carLotForm;

        /// <summary>
        /// The car by make property.
        /// </summary>
        /// <value>
        /// The cars by make.
        /// </value>
        public List<Car>? CarsByMake { get; private set; }

        /// <summary>
        /// Initializes a new instance of a SearchMakeForm.
        /// </summary>
        /// <param name="carLotForm">The car lot form.</param>
        public SearchMakeForm(CarLotForm carLotForm)
        {
            InitializeComponent();
            _carLotForm = carLotForm;
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(makeTextBox.Text))
            {
                MessageBox.Show("Please enter a make to search for.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CarsByMake = _carLotForm.CarLot.FindCarsByMake(makeTextBox.Text);

                Close();
            }
        }
    }
}
