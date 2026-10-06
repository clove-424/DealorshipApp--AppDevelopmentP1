namespace CarolineLoveProject1.Model
{
    public class Car
    {
        public string? Make { get; set; }

        public string? Model { get; set; }

        public decimal? Mpg { get; set; }

        public decimal? Price { get; set; }

        public Car(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException(nameof(make));
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException(nameof(model));
            }
            if (mpg < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mpg));
            }
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }
            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }
    }
}
