namespace CarolineLoveProject1.Model
{
    /// <summary>
    /// The CarLot class represents a car lot that contains an inventory of cars and a tax rate.
    /// </summary>
    public class CarLot
    {
        private readonly List<Car> _inventory;

        /// <summary>
        /// The tax rate for the car lot.
        /// </summary>
        public const decimal TaxRate = 0.078m;

        /// <summary>
        /// The property for the inventory count of the car lot.
        /// </summary>
        /// <value>
        /// The inventory count.
        /// </value>
        public int Count => _inventory.Count;

        /// <summary>
        /// The Inventory property.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public List<Car> Inventory => _inventory;

        /// <summary>
        /// Initializes a new instance of a car lot and adds a default inventory.
        /// </summary>
        public CarLot()
        {
            _inventory = [];
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            _inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26_298.98m));
            _inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19.0m, 65_401.23m));
            _inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26_780.00m));
            _inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42_101.10m));
        }

        /// <summary>
        /// Finds the cars by make.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <returns>A list of cars that match the specified make.</returns>
        public List<Car>? FindCarsByMake(string make)
        {
            var carsByMakeList = new List<Car>();
            foreach (var item in _inventory)
            {
                if (item.Make.ToLower().Contains(make.ToLower()))
                {
                    carsByMakeList.Add(item);
                }
            }

            if (carsByMakeList.Count == 0)
            {
                return null;
            }

            return carsByMakeList;
        }

        /// <summary>
        /// Finds the car by model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns>The car that matches the specified make and model, or null if not found.</returns>
        public Car? FindCarByModel(string make, string model)
        {
            foreach (var car in _inventory)
            {
                if (car.Make.ToLower().Equals(make.ToLower()) && car.Model.ToLower().Equals(model.ToLower()))
                {
                    return car;
                }
            }

            return null;
        }

        /// <summary>
        /// Removes the car from inventory and returns the removed car.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns>The purchased car, or null if not found.</returns>
        public Car? PurchaseCar(string make, string model)
        {
            var car = FindCarByModel(make, model);
            if (car != null)
            {
                _inventory.Remove(car);
                return car;
            }

            return null;
        }

        /// <summary>
        /// Adds a car to the lot.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            _inventory.Add(new Car(make, model, mpg, price));
        }

        /// <summary>
        /// Gets the total cost of purchase.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>The total cost of the purchase, or $0.00 if the car is not found.</returns>
        public static decimal GetTotalCostOfPurchase(Car? car)
        {
            if (car != null)
            {
                var total = car.Price * (1 + TaxRate);
                return total;
            }

            return 0.00m;
        }

        /// <summary>
        /// Finds the least expensive car.
        /// </summary>
        /// <returns>The least expensive car, or null if no cars are available.</returns>
        public Car? FindLeastExpensiveCar()
        {
            var lowestPrice = decimal.MaxValue;
            Car? cheapestCar = null;
            foreach (var car in _inventory)
            {
                if (car.Price < lowestPrice)
                {
                    lowestPrice = car.Price;
                    cheapestCar = car;
                }
            }
            return cheapestCar;
        }

        /// <summary>
        /// Finds the most expensive car.
        /// </summary>
        /// <returns>The most expensive car, or null if no cars are available.</returns>
        public Car? FindMostExpensiveCar()
        {
            var highestPrice = decimal.MinValue;
            Car? mostExpensiveCar = null;
            foreach (var car in _inventory)
            {
                if (car.Price > highestPrice)
                {
                    highestPrice = car.Price;
                    mostExpensiveCar = car;
                }
            }
            return mostExpensiveCar;
        }

        /// <summary>
        /// Finds the car with the best MPG.
        /// </summary>
        /// <returns>The car with the best MPG, or null if no cars are available.</returns>
        public Car? FindBestMpgCar()
        {
            var bestMpg = decimal.MinValue;
            Car? carToSearch = null;
            foreach (var car in _inventory)
            {
                if (car.Mpg > bestMpg)
                {
                    bestMpg = car.Mpg;
                    carToSearch = car;
                }
            }

            return carToSearch;
        }

        /// <summary>
        /// Finds the car with the worst MPG.
        /// </summary>
        /// <returns>The car with the worst MPG, or null if no cars are available.</returns>
        public Car? FindWorstMpgCar()
        {
            var worstMpg = decimal.MaxValue;
            Car? carToSearch = null;
            foreach (var car in _inventory)
            {
                if (car.Mpg < worstMpg)
                {
                    worstMpg = car.Mpg;
                    carToSearch = car;
                }
            }

            return carToSearch;
        }
    }
}
