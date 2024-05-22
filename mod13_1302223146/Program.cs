using mod13_1302223146;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> smt;
            PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
            PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

            Console.WriteLine("Add dan Menampilkan:");
            data1.AddSebuahData("Fajar Ramadhan");
            data1.AddSebuahData("Aldino Rasendriya");
            data1.AddSebuahData("Harits Azfa");
            data1.AddSebuahData("Ghifari Permata");
            data1.AddSebuahData("Fransiskus Xaverius");
            data1.AddSebuahData("Denanda Permana");
            data1.AddSebuahData("FAL");
            data2.printSemuaData();
            Console.WriteLine();

            Console.WriteLine("Hapus Data:");
            data2.HapusSuatuData(6);
            data1.printSemuaData();
            smt = data1.GetSemuaData();
            Console.WriteLine();

            Console.WriteLine("Count Data:");
            smt = data1.GetSemuaData();
            Console.WriteLine("data1: " + smt.Count);
            smt = data1.GetSemuaData();
            Console.WriteLine("data2: " + smt.Count);


        }
    }
}
