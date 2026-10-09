namespace CarolineLoveProject1.Model
{
    /// <summary>
    /// The Shopper class represents a shopper with properties for name and money available.
    /// </summary>
    public class Shopper
    {
        private readonly List<Car> _cars;

        /// <summary>
        /// The shopper's name property.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// The shopper's money available property.
        /// </summary>
        /// <value>
        /// The money available.
        /// </value>
        public decimal MoneyAvailable { get; set; }

        /// <summary>
        /// Initializes a new instance of a Shopper.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="moneyAvailable">The money available.</param>
        /// <exception cref="System.ArgumentException">name</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">moneyAvailable</exception>
        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (moneyAvailable < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(moneyAvailable), "Money available cannot be negative.");
            }
            Name = name;
            MoneyAvailable = Math.Round(moneyAvailable, 2);
            _cars = new();
        }

        /// <summary>
        /// Determines whether a shopper can pay the total cost of a car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <param name="totalCost">The total cost.</param>
        /// <returns>
        ///   true if the shopper can pay the total cost; otherwise, false.
        /// </returns>
        public bool CanPurchase(Car car, decimal totalCost)
        {
            if (MoneyAvailable >= totalCost && !_cars.Contains(car))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a car to the shopper's list of purchased cars and returns the remaining money available after the purchase.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <param name="totalCost">The total cost.</param>
        public void PurchaseCar(Car car, decimal totalCost)
        {
            if (CanPurchase(car, totalCost))
            {
                _cars.Add(car);
                MoneyAvailable -= totalCost;
            }
        }
    }
}
