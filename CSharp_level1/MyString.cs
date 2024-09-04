using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class MyString
    {

        public static void Strings()
        {
            string S1 = "Ahmed Eid Mady";

            Console.WriteLine(S1.Length);
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[1]);
            Console.WriteLine(S1.Substring(0, 5));
            Console.WriteLine(S1.Substring(6, 3));
            Console.WriteLine(S1.Insert(9, " Faried"));
            Console.WriteLine(S1.Replace("Eid", "***"));
            Console.WriteLine(S1.IndexOf("Eid"));
            Console.WriteLine(S1.Contains("Mady"));
            Console.WriteLine(S1.Contains("M"));
            Console.WriteLine(S1.ToLower().IndexOf('m'));
            Console.WriteLine("=======================================================");

            Console.WriteLine(S1.Length);
            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));
            Console.WriteLine("=======================================================");
            string S2 = "Ali,Ahmed,Mady,eid,faried";
            string[] NamesList = S2.Split(',');
            string[] NamesList2 = S2.Split(',');
            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);
            Console.WriteLine("=================");
            Console.WriteLine(NamesList2[0]);
            Console.WriteLine(NamesList2[1]);
            Console.WriteLine(NamesList2[2]);
            Console.WriteLine("=======================================================");

            string S3 = "  Ahmed Mady  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            Console.ReadKey();
        }
        public static void StringInterpolation()
        { //  String Interpolation

            string firstName = "AHMED";
            string lastName = "MADY";
            string code = "110";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

            Console.WriteLine("=======================================================");

            string S2 = "Ali,Ahmed,Mady,eid,faried";
            string[] NamesList = S2.Split(',');
            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);
            string S3 = "";
            for (int i = 0; i < NamesList.Length; i++)
            {
                S3 += NamesList[i] + " ";
            }
            Console.WriteLine(S3);
            Console.WriteLine("=======================================================");
            Console.ReadKey();
        }
    }
}
