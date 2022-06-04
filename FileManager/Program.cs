namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }
        public static void Welcome()
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Type the number for the desired option:");
            Console.WriteLine("1: View list of drives.");
            Console.WriteLine("2: View list of root directories inside a drive.");
            Console.WriteLine("3: View list of files inside a root directory.");
            Console.WriteLine("0: EXIT.");
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Convert.ToInt32(input);
                RunOperation(number);
            } catch(Exception ex) { Console.WriteLine("Your input was not in the correct format. Please type a number." + " \n " + ex.Message); }
            if (number != 0)
                Welcome();
        }
        public static void RunOperation(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Quitting...!");
            }
            else if(number == 1)
            {
                ListDrives();
            }
            else if (number == 2)
            {
                ListRootDirectoriesOfDrive();
            }
            else if (number == 3)
            {
                ListFilesOfRootDirectory();
            }
        }
        public static void ListDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string d in drives)
            {
                Console.WriteLine(d);
            }
        }
        public static void ListRootDirectoriesOfDrive()
        {
            Console.WriteLine("Type the letter of the drive:");
            string input = Console.ReadLine();
            string root = "";
            if (!string.IsNullOrWhiteSpace(input))
            {
                input = input.ToUpper();
                root = @""+input+":\\";
            }
            else
            {
                Console.WriteLine("Your input was not in the correct format. Please type a number." + " \n ");
            }
            string[] directories = Directory.GetDirectories(root);
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
        }
        public static void ListFilesOfRootDirectory()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string d in drives)
            {
                Console.WriteLine(d);
            }
        }
        public static void ReadingTest()
        {
            string rootC = @"C:\";
            string rootD = @"D:\";
            string path = @"C:\Users\saleh\Desktop";
            string[] files = Directory.GetFiles(rootC);
            string[] directories = Directory.GetDirectories(rootD);
            Console.WriteLine("There are ( " + files.Length + " ) files in this folder.");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
        }



    }
}