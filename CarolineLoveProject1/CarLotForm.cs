using CarolineLoveProject1.Model;
using CarolineLoveProject1.View;

namespace CarolineLoveProject1
{
    /// <summary>
    /// The main form for the car lot application, allowing users to view the car inventory and buy cars.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CarLotForm : Form
    {
        private readonly CarLot _lot;

        private Shopper? _shopper;

        /// <summary>
        /// Initializes a new instance of the CarLotForm class.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            _lot = new();
            UpdateCarLot();
        }

        private void PurchaseCarClick(object sender, EventArgs e)
        {
            var car = (Car?) carLotListBox.SelectedItem;
            if (car != null && _shopper != null) 
            {
                var carToRemove = _lot.PurchaseCar(car.Make, car.Model);
                var totalCost = _lot.GetTotalCostOfPurchase(carToRemove);
                var totalLeft = _shopper.PurchaseCar(carToRemove, totalCost);

                shopperTotalLabel.Text = $"Money Available: {totalLeft:C}";
                var message = $"Car: {carToRemove} \nwas purchased successfully! \nTotal Cost: {totalCost:C}";
                MessageBox.Show(message);
            }

            UpdateCarLot();
        }

        private void AddCarMenuItemClick(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new();
            addCarForm.ShowDialog();

            var carToAdd = addCarForm.Car;
            if (carToAdd != null)
            {
                _lot.AddCar(carToAdd.Make, carToAdd.Model, carToAdd.Mpg, carToAdd.Price);
            }

            UpdateCarLot();
        }

        private void UpdateCarLot()
        {
            carLotListBox.DataSource = null;
            carLotListBox.Items.Clear();
            carLotListBox.DataSource = _lot.Inventory;
        }

        private void AddShopperClick(object sender, EventArgs e)
        {
            var shopperForm = new ShopperForm();
            shopperForm.ShowDialog();

            _shopper = shopperForm.Shopper;
            if (_shopper != null)
            {
                shopperNameLabel.Text = $"Shopper: {_shopper.Name}";
                shopperTotalLabel.Text = $"Money Available: {_shopper.MoneyAvailable.ToString("C")}";
            }
        }

        private void ExitFormClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
