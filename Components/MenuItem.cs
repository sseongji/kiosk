using System;
using System.Drawing;
using System.Windows.Forms;

namespace KioskApp.ucPanel
{
    public enum Categories { Season, Coffee, NonCoffee, Milkshake , SmoothyFraffe, AdeJuice, Tea, Side }
    public partial class MenuItem : UserControl
    {
        private Categories category;
        private int price;

        //delegate, 대리자
        public event EventHandler OnSelect = null;
        public MenuItem()
        {
            InitializeComponent();
        }

        //메뉴 아이템 클릭 이벤트
        private void imgMenu_Click(object sender, EventArgs e)
        {
            //delegate 호출되면 호출
            OnSelect?.Invoke(this, e); //?. : not null이면 참조, null이면 null
        }

        //카테고리
        public Categories Category { get => category; set => category = value; }
        //메뉴명
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        //가격
        public int Price { get => price; set { price = value; lblPrice.Text = price.ToString("C"); } }
        //public Image Icon { get =>imgMenu.Image; set => imgMenu.Image = value; }
        //이미지
        public Image Icon { get => imgMenu.Image; set => imgMenu.Image = value; }
    }
}