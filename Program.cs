using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using practice.Properties;
using Newtonsoft.Json;


namespace practice
{
    internal class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {         
            await Data.Todo();

            string[] arr = {"Abir","Mahmud","Mahim"};
            string FullName= "";
            for (int i = 0; i < arr.Length; i++)
            {
                FullName += arr[i] + " ";
                //Console.WriteLine(arr[i]);
            }
            Console.WriteLine(FullName);
            //Console.WriteLine(arr[0]);

             Car.CarItem firstCar=Car.MyCar();

            var jsonCar = JsonConvert.SerializeObject(firstCar);
            Console.WriteLine(jsonCar);
            Console.WriteLine($"Name: {firstCar.Name}, Model: {firstCar.Model}, Color: {firstCar.Color}, Buying Year: {firstCar.BuyingYear}");
        }
    }
}
