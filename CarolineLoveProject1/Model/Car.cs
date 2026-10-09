namespace CarolineLoveProject1.Model
{
    /// <summary>
    /// The Car class represents a car with properties for make, model, miles per gallon (mpg), and price.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The make property.
        /// </summary>
        /// <value>
        /// The make of a car.
        /// </value>
        public string Make { get; set; }

        /// <summary>
        /// The model property.
        /// </summary>
        /// <value>
        /// The model of a car.
        /// </value>
        public string Model { get; set; }
        
        /// <summary>
        /// The miles per gallon property.
        /// </summary>
        /// <value>
        /// The miles per gallon of a car.
        /// </value>
        public decimal Mpg { get; set; }

        /// <summary>
        /// The price property.
        /// </summary>
        /// <value>
        /// The price of a car.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the Car class.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// make
        /// or
        /// model
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// mpg
        /// or
        /// price
        /// </exception>
        public Car(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or whitespace.", nameof(make));
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or whitespace.", nameof(model));
            }
            if (mpg <= 0.0m)
            {
                throw new ArgumentOutOfRangeException(nameof(mpg), "Mpg must be a positive value.");
            }
            if (price <= 0.00m)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be a positive value.");
            }
            Make = make;
            Model = model;
            Mpg = Math.Round(mpg, 1);
            Price = Math.Round(price, 2);
        }

        public override string ToString()
        {
            var formattedPrice = Price.ToString("C");
            return $"{Make} {Model} {formattedPrice} {Mpg}mpg";
        }
    }
}
