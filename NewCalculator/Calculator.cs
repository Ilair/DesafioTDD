using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculator
    {
        private List<string> historyList;
        private string data;

        public Calculator(string data)
        {
            historyList = new List<string>();
            this.data = data;
        }

        public int Somar(int valOne, int valTwo)
        {
            int res = valOne + valTwo;

            historyList.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }
        public int Diminuir(int valOne, int valTwo)
        {
            int res = valOne - valTwo;

            historyList.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }
        public int Dividir(int valOne, int valTwo)
        {
            int res = valOne / valTwo;

            historyList.Insert(0, "Res: " + res + " - data: " + data); ;

            return res;
        }
        public int Multiplicar(int valOne, int valTwo)
        {
            int res = valOne * valTwo;

            historyList.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public List<string> History()
        {
            historyList.RemoveRange(3, historyList.Count - 3);
            return historyList;
        }
    }
}
