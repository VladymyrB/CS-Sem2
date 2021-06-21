using System;
using System.IO;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FileManager.GetMaxHierarchyDirectories(@"C:\Users\38095\Desktop\dut\CS Rep\lab7"));
        }
    }

    public class FileManager
    {
        public static void CreateDirectories(string calalogPath)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory(Path.Combine(calalogPath, $"FOLDER_{i}"));
            }
        }

        public static void DeleteDirectories(string calalogPath)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(Path.Combine(calalogPath, $"FOLDER_{i}"));
            }
        }

        public static void CreateHierarchyDirectories(string calalogPath)
        {
            for (int i = 0; i < 100; i++)
            {
                var path = calalogPath;
                for (int j = 0; j <= i; j++)
                {
                    path = Path.Combine(path, $"FOLDER_{j}");
                }

                Directory.CreateDirectory(path);
            }
        }

        public static int GetMaxHierarchyDirectories(string calalogPath)
        {
            var path = calalogPath;
            var i = 0;
            while (true)
            {
                for (int j = 0; j < i; j++)
                {
                    path = Path.Combine(path, $"FOLDER_{j}");
                }

                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    return i - 1;
                }

                i++;
            }
        }

        public static string GetMaxHierarchyDirectory(string calalogPath)
        {
            var path = calalogPath;
            var i = 0;
            while (true)
            {
                for (int j = 0; j < i; j++)
                {
                    path = Path.Combine(path, $"FOLDER_{j}");
                }

                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    return $"FOLDER_{i - 1}";
                }

                i++;
            }
        }
    }
}
