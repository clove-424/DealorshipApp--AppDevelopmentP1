namespace CarolineLoveProject1.View
{
    public partial class InventoryDetailsForm : Form
    {
        private readonly CarLotForm _carLotForm;

        public InventoryDetailsForm(CarLotForm carLotForm)
        {
            InitializeComponent();

            _carLotForm = carLotForm;
            inventoryCountLabel.Text = $"Inventory of {_carLotForm.CarLot.Inventory.Count} cars:";

            PopulateInventoryTextBox();
            DisplayInventoryStats();
        }

        private void PopulateInventoryTextBox()
        {
            foreach (var car in _carLotForm.CarLot.Inventory)
            {
                var carInfo = $"{car.Make} {car.Model}\t{car.Price:C}  {car.Mpg}mpg";
                inventoryTextBox.Text += carInfo + Environment.NewLine;
            }
            
        }

        private void DisplayInventoryStats()
        {
            var leastExpensiveCar = _carLotForm?.CarLot.FindLeastExpensiveCar();
            var mostExpensiveCar = _carLotForm?.CarLot.FindMostExpensiveCar();
            var bestMpgCar = _carLotForm?.CarLot.FindBestMpgCar();
            var worstMpgCar = _carLotForm?.CarLot.FindWorstMpgCar();

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
