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

            var shopperToAdd = shopperForm.Shopper;
            if (shopperToAdd != null)
            {
                shopperNameLabel.Text = $"Shopper: {shopperToAdd.Name}";
                shopperTotalLabel.Text = $"Money Available: {shopperToAdd.MoneyAvailable.ToString("C")}";
            }
        }
    }
}
