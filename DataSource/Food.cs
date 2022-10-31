using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskApp.DataSource
{
    internal class Food
    {
        //카테고리
        public string Category { get; set; }
        //메뉴명
        public string Name { get; set; }
        //가격
        public int Price { get; set; }
        ////이미지 경로
        //public string ImgSrc { get; set; }
    }
}
