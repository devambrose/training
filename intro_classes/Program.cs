namespace intro_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car hyundai = new Car();

            hyundai.setName("Test");

            Console.WriteLine(hyundai.getName());

            Car honda= new Honda();

            honda.setName("Honda Stream");
        }
    }
}
