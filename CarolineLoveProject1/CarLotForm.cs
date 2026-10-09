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
        private Shopper? _shopper;

        public CarLot CarLot { get; }

        /// <summary>
        /// Initializes a new instance of the CarLotForm class.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            CarLot = new();
            UpdateCarLot();
        }

        private void PurchaseCarClick(object sender, EventArgs e)
        {
            var car = (Car?) carLotListBox.SelectedItem;
            if (car != null && _shopper != null)
            {
                var totalCost = CarLot.GetTotalCostOfPurchase(car);
                if (_shopper.CanPurchase(car, totalCost))
                {
                    MakePurchase(car, totalCost);
                }
                else
                {
                    MessageBox.Show("You do not have enough money to purchase this car.", "Purchase Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (_shopper == null)
            {
                MessageBox.Show("Please add a shopper before making a purchase.", "Purchase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MakePurchase(Car car, decimal totalCost)
        {
            var carToRemove = CarLot.PurchaseCar(car.Make, car.Model);
            _shopper.PurchaseCar(carToRemove, totalCost);

            var message = $"{carToRemove.Make} {carToRemove.Model} \npurchased successfully! \nTotal Cost After Tax: {totalCost:C}";
            MessageBox.Show(message, "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            shopperTotalLabel.Text = $"Money Available: {_shopper.MoneyAvailable:C}";

            UpdateCarLot();
        }

        private void AddCarMenuItemClick(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new();
            addCarForm.ShowDialog();

            var carToAdd = addCarForm.Car;
            if (carToAdd != null)
            {
                CarLot.AddCar(carToAdd.Make, carToAdd.Model, carToAdd.Mpg, carToAdd.Price);
            }

            UpdateCarLot();
        }

        private void UpdateCarLot()
        {
            carLotListBox.DataSource = null;
            carLotListBox.Items.Clear();
            carLotListBox.DataSource = CarLot.Inventory;
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

        private void InventoryDetailsClick(object sender, EventArgs e)
        {
            var inventoryDetailsForm = new InventoryDetailsForm(this);
            inventoryDetailsForm.ShowDialog();
        }
    }
}
