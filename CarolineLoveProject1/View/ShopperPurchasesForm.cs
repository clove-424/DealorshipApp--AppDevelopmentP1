using CarolineLoveProject1.Model;

namespace CarolineLoveProject1.View
{
    /// <summary>
    /// The ShopperPurchasesForm class represents a form that displays the purchases made by a shopper.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ShopperPurchasesForm : Form
    {
        public ShopperPurchasesForm(Shopper? shopper)
        {
            InitializeComponent();

            if (shopper != null)
            {
                shopperPurchasesLabel.Text = $"{shopper.Name}'s Purchases: {shopper.Cars.Count} cars";
                shopperPurchasesListBox.DataSource = null;
                shopperPurchasesListBox.Items.Clear();
                shopperPurchasesListBox.DataSource = shopper.Cars;
            }
        }
    }
}
