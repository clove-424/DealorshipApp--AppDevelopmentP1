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

        /// <summary>
        /// The car lot read-only property.
        /// </summary>
        /// <value>
        /// The car lot.
        /// </value>
        public CarLot CarLot { get; }

        /// <summary>
        /// Initializes a new instance of the CarLotForm class.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            CarLot = new CarLot();
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
            if (carToRemove != null)
            {
                _shopper.PurchaseCar(carToRemove, totalCost);

                var message = $"{carToRemove.Make} {carToRemove.Model} \n{carToRemove.Mpg}mpg \n{carToRemove.Price:C}" +
                              $"\nwas purchased successfully! \n\nTotal Cost After Tax (7.8%): \n{totalCost:C}";
                MessageBox.Show(message, "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shopperTotalLabel.Text = $"Money Available: {_shopper.MoneyAvailable:C}";

                UpdateCarLot();
            }
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
            var shopperForm = new AddShopperForm();
            shopperForm.ShowDialog();

            _shopper = shopperForm.Shopper;
            if (_shopper != null)
            {
                shopperNameLabel.Text = $"Shopper: {_shopper.Name}";
                shopperTotalLabel.Text = $"Money Available: {_shopper.MoneyAvailable:C}";
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

        private void SearchByMakeClick(object sender, EventArgs e)
        {
            var searchMakeForm = new SearchMakeForm(this);
            searchMakeForm.ShowDialog();

            if (searchMakeForm.CarsByMake?.Count > 0)
            {
                carLotListBox.DataSource = null;
                carLotListBox.Items.Clear();
                carLotListBox.DataSource = searchMakeForm.CarsByMake;
            }
        }

        private void ClearSearchButtonClick(object sender, EventArgs e)
        {
            UpdateCarLot();
        }

        private void ViewPurchasesButtonClick(object sender, EventArgs e)
        {
            if (_shopper == null)
            {
                MessageBox.Show("Please add a shopper before viewing purchases.", "No Shopper",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var purchasesForm = new ShopperPurchasesForm(_shopper);
                purchasesForm.ShowDialog();
            }
        }
    }
}
