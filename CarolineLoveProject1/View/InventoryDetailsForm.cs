namespace CarolineLoveProject1.View
{
    /// <summary>
    /// The InventoryDetailsForm class represents a form that displays the details of the car inventory,
    /// including the list of cars and their statistics.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InventoryDetailsForm : Form
    {
        private readonly CarLotForm _carLotForm;

        /// <summary>
        /// Initializes a new instance of an InventoryDetailsForm.
        /// </summary>
        /// <param name="carLotForm">The car lot form.</param>
        public InventoryDetailsForm(CarLotForm carLotForm)
        {
            InitializeComponent();

            _carLotForm = carLotForm;
            inventoryCountLabel.Text = $"Inventory of {_carLotForm.CarLot.Inventory.Count} cars:";

            PopulateInventoryTextBox();
        }

        private void PopulateInventoryTextBox()
        {
            foreach (var car in _carLotForm.CarLot.Inventory)
            {
                var carInfo = $"{car.Make} {car.Model}\t{car.Price:C}  {car.Mpg}mpg";
                inventoryTextBox.Text += carInfo + Environment.NewLine;
            }

        }
        private void ShowStatsButtonClick(object sender, EventArgs e)
        {
            DisplayInventoryStats();
        }

        private void DisplayInventoryStats()
        {
            var leastExpensiveCar = _carLotForm.CarLot.FindLeastExpensiveCar();
            var mostExpensiveCar = _carLotForm.CarLot.FindMostExpensiveCar();
            var bestMpgCar = _carLotForm.CarLot.FindBestMpgCar();
            var worstMpgCar = _carLotForm.CarLot.FindWorstMpgCar();

            if (_carLotForm.CarLot.Inventory.Count > 0)
            {
                leastExpTextBox.Text =
                    $"{leastExpensiveCar.Make} {leastExpensiveCar.Model} {leastExpensiveCar.Price:C}";
                mostExpTextBox.Text =
                    $"{mostExpensiveCar.Make} {mostExpensiveCar.Model} {mostExpensiveCar.Price:C}";
                bestMpgTextBox.Text = $"{bestMpgCar.Make} {bestMpgCar.Model} {bestMpgCar.Mpg}mpg";
                worstMpgTextBox.Text = $"{worstMpgCar.Make} {worstMpgCar.Model} {worstMpgCar.Mpg}mpg";
            }
        }
    }
}
