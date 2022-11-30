namespace inheritance_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(Console.ReadLine(),Console.ReadLine(),true,"Ugurludur");

            Console.WriteLine(admin);
            admin.AllData();
        }
    }
}