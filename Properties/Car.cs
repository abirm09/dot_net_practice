using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Properties
{
    internal class Car
    {
        public class ModelDetails
        {
            public string ModelName { get; set; }
            public string ModelYear { get; set; }
            public string ModelColor { get; set; }
        }
       public class CarItem
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public ModelDetails Model { get; set; }
            public int BuyingYear { get; set; }
        }

        public static CarItem MyCar()
        {
            var NewCar = new CarItem()
            {
                Name = "Toyota",
                Model = new ModelDetails()
                {
                    ModelColor = "Black",
                    ModelName = "Corolla",
                    ModelYear = "2019"
                },
                Color = null,
                BuyingYear = 2019
            };
            return NewCar;
        }
    }

}
