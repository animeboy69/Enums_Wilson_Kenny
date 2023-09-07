namespace Enums_Wilson_Kenny
{
    using System;
    using System.ComponentModel.Design;
    using System.IO;


    internal class Program
    {
        /// <summary>
        ///  Creats a global enum called Months and starts from Jan to Dec. Set Jan = 1.
        /// </summary>
        enum Months
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec,
        }
        /// <summary>
        ///  Creats a Main method and a string called myBirthDate set equal to "My Birthday is on <myBirthMonth>/<myBirthDay>/<myBirthDay</myBirthDay>"
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Mar;
            int myBirthDay = 30;
            int myBirthYear = 2005;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            
            /// Copy the myFile.txt and new file called newFile.txt
            
            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.text");

            }
            else
            {
                File.Replace("myFile.txt", "newFile.txt",  "backupFile.txt");
            }


            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}