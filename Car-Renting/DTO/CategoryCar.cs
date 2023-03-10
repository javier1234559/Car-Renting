using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class CategoryCar
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public  CategoryCar() { }

        public CategoryCar(int categoryId, string categoryName)
        {
            CategoryId=categoryId;
            CategoryName=categoryName;
        }
    }
}
