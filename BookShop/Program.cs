namespace BookShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Billing());

            Connect conn = new Connect();

            if (conn.TestConnection())
            {
                Console.WriteLine("Connect Successful!");
            }
            else
            {
                Console.WriteLine("Can't Connect to the DB!");
            }

            Console.ReadLine();
        }
    }
}