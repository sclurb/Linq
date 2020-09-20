using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("************");
            ShowLargeFilesWithLInq(path);

            Console.ReadKey();
        }

        private static void ShowLargeFilesWithLInq(string path)
        {
            var query =  new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInforComparer());

            for(int i = 0;i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, 20} : {file.Length, 10:N0}");
            }
        }

        public class FileInforComparer : IComparer<FileInfo>
        {
            public int Compare([AllowNull] FileInfo x, [AllowNull] FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
