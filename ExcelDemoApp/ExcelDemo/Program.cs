using System;

namespace ExcelDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            ReadDataFromExcel readData = new ReadDataFromExcel("ProductList.xlsx");
            Console.WriteLine(readData.ReadExcel());
        }

    }
}





