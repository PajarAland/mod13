using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod13_1302223146
{
    public sealed class PusatDataSingleton
    {
        List<String> dataTersimpan;
        static PusatDataSingleton _instance;

        private PusatDataSingleton() 
        {
            dataTersimpan = new List<String>();
        }

        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null) 
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        public List<String> GetSemuaData()
        {
            return dataTersimpan;
        }

        public void printSemuaData()
        {
            foreach (String s in dataTersimpan)
            {
                System.Console.WriteLine(s);
            }
        }

        public void AddSebuahData(String input)
        {
            this.dataTersimpan.Add(input);
        }
        public void HapusSuatuData(int index)
        {
            this.dataTersimpan.RemoveAt(index);
        }
    }
}
