using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KioskApp.DataSource
{
    internal class FoodsData
    {
        //public List<Food> Foods { get { return listFood; } }
        public List<Food> listFood = new List<Food>()
        {
            //coffee
            new Food(){Category="coffee",  Name="에스프레소", Price= 1500},
            new Food(){Category="coffee",  Name="아메리카노", Price= 1500},
            new Food(){Category="coffee",  Name="카푸치노", Price= 2700},
            new Food(){Category="coffee",  Name="카페라떼", Price= 2700},
            new Food(){Category="coffee",  Name="바닐라라떼", Price= 3000},
            new Food(){Category="coffee",  Name="헤이즐넛라떼", Price= 3000},
            new Food(){Category="coffee",  Name="카라멜마끼아또", Price= 3300},
            new Food(){Category="coffee",  Name="카페모카", Price= 3300},
            new Food(){Category="coffee",  Name="돌체라떼", Price= 3500},
            new Food(){Category="coffee",  Name="흑당카페라떼", Price= 3800},
            new Food(){Category="coffee",  Name="더치커피", Price= 3000},
            new Food(){Category="coffee",  Name="더치라떼", Price= 3500},
            new Food(){Category="coffee",  Name="아인슈페너라떼", Price= 3900},
            new Food(){Category="coffee",  Name="아인슈페너", Price= 3800},
            new Food(){Category="coffee",  Name="디카페인더치커피", Price= 3000},
            new Food(){Category="coffee",  Name="디카페인더치커피", Price= 3500},
            new Food(){Category="coffee",  Name="달고나라떼", Price= 3900}
        };
    }
}
