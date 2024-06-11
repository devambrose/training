namespace HrApplication.Entities
{
    public class Dependant
    {
        public int Id { get; set; } //30 1 4  5

        public string Name { get; set; }

        public string Description { get; set; } = "";

        public int EmployeeId { get; set; } 

        public Employee Employee { get; set; }
    }
}
