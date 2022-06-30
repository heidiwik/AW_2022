namespace HealthApp
{
    public class Fruit
    {
        public string genus { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string family { get; set; }
        public string order { get; set; }
        public Nutritions nutritions { get; set; }
    }

    public class Nutritions
    {
        public float carbohydrates { get; set; }
        public float protein { get; set; }
        public float fat { get; set; }
        public int calories { get; set; }
        public float sugar { get; set; }
    }
}