namespace enumpro
{
    internal class Program
    {
        //allow user to change console background and foreground colors using enum

        public enum Color
        {
            Red, Green, Blue, Yellow, brown,white,black
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello please choose (1) to change background color \t  and choose (2) to change the foreground color");
                string option = Console.ReadLine();

                foreach (var i in Enum.GetNames(typeof(Color)))
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("enter color name");
                string name = Console.ReadLine();
                ConsoleColor selectedcolor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), name, true);
                if (option == "1")
                {
                    Console.BackgroundColor = selectedcolor;
                }
                else if (option == "2")
                    Console.ForegroundColor = selectedcolor;

            }
        }
            
    }
}
