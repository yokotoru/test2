using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Da da = new Da();
            da.Vvod();
            da.Vivod();
            Console.ReadKey();
        }
       
    }
    public class Da
    {
        public  static int Dada()
        {
            Console.WriteLine(Bebra.Hyi());
            return Bebra.Hyi();
        }
        public string s;
        public void Vvod()
        {
            StreamReader f = new StreamReader("C:\\Users\\Леся Кузнецова\\Desktop\\Новая папка\\test.txt");
            while (!f.EndOfStream)
            {
                s = f.ReadLine();
                // что-нибудь делаем с прочитанной строкой s
                Console.WriteLine(s);
            }
            f.Close();
        }
        public void Vivod()
        {
            string[] lines = new string[] { s, s, s};
            File.WriteAllLines("C:\\Users\\Леся Кузнецова\\Desktop\\Новая папка\\test1.txt", lines);
        }
    }

}
