namespace HrApplication.Entities
{
    public class Allowance
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } = "";

        public double Amount { get; set; }
    }
}
