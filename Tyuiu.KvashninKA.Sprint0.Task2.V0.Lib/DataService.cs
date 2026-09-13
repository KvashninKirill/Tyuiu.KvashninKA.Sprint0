using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tyuiu.KvashninKA.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет, {name}";
        }
    }

}