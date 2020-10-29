using static System.Console;
using System.IO;


namespace DirectoryInformation
{
    class Directory
    {
        static void Main()
        {
            WriteLine("Press enter once to begin testing your directory's");
            string directoryName = ReadLine();


            while (directoryName != "end")
            {
                Write("\nEnter a Directory name: ");
                string directory = ReadLine();
                string fulldir = Path.Combine(directoryName.TrimEnd('/') + "/", directory);

                if (directory.ToLower() == "end")
                    break;

                else if (System.IO.Directory.Exists(fulldir))
                {
                    foreach (string file in System.IO.Directory.GetFiles(fulldir))
                        WriteLine(file);
                }

                else
                    WriteLine("Directory {0} does not exist", directory);
            }
        }

    }
}
