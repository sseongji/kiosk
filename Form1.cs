using KioskApp.DataSource;
using KioskApp.Properties;
using KioskApp.ucPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KioskApp
{

    public partial class MainForm : Form
    {

       
        public MainForm()
        {
            InitializeComponent();
        }

        //메인 로드
        private void MainForm_Load(object sender, EventArgs e)
        {
            //첫 로드 화면: category2(coffee)
            btnCategory2.Select();
            btnCategory2.PerformClick();

            //테스트
            //AddMenuItem(categories.Coffee, "아메리카노", 1500, "아메리카노.jpg");

        }

        //메뉴 아이템 동적 정보 생성 함수, + 메뉴 아이템 선택 이벤트
        public void AddMenuItem(Categories category, string name, int price, Image icon)
        {
            //메뉴 아이템 동적 생성
            var menuItem = new ucPanel.MenuItem()
            {
                Category = category,
                Title = name,
                Price = price,
                Icon = icon
            };
            menuViewPanel.Controls.Add(menuItem);

            //메뉴아이템 클릭했을 때 이벤트, 항목별 수량과 항목별 가격
            menuItem.OnSelect += (object s, EventArgs e) =>
            {
                var item = (ucPanel.MenuItem)s;
                foreach (ListViewItem i in lstSelMenu.Items)
                {
                    //주문 내역에 존재하고 있다면
                    if (i.SubItems[0].Text == item.lblTitle.Text) //보호수준때문에 접근할 수 없음. lblTitle 접근 지정자 public으로 바꿈
                    {
                        string newPrice = null; //특수문자 제거
                        //int menuPrice = 0; //음료 1개의 값

                        //항목별 수량
                        i.SubItems[1].Text = (int.Parse(i.SubItems[1].Text) + 1).ToString();

                        //항목별 가격
                        newPrice = item.lblPrice.Text.Remove(0, 1); //음료 1개의 값, 특수문자 제거
                        i.SubItems[2].Text = (int.Parse(i.SubItems[1].Text) * int.Parse(newPrice.Replace(",", ""))).ToString("C");

                        CalTotal();
                        return;
                    }
                }
                //주문 내역에 없다면
                string[] row = { item.lblTitle.Text, 1.ToString(), item.lblPrice.Text }; //listview row를 string[]형식으로 전달
                lstSelMenu.Items.Add(new ListViewItem(row));
                CalTotal();
            };
        }
        //주문 내역 항목 삭제 이벤트(더블클릭)
        private void lstSelMenu_DoubleClick(object sender, EventArgs e)
        {
            //선택 항목이 있으면,
            foreach (ListViewItem item in lstSelMenu.SelectedItems)
            {
                if (MessageBox.Show("선택하신 메뉴를 삭제합니다.", "선택 항목 취소", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lstSelMenu.Items.Remove(item);
                    CalTotal();
                }
            }
        }

        //총 개수, 총 금액 계산 함수
        void CalTotal()
        {
            int totalPrice = 0;
            int totalCnt = 0;
            string newPrice= null;
            foreach (ListViewItem i in lstSelMenu.Items)
            {
                //총 수량
                totalCnt += int.Parse(i.SubItems[1].Text);
                //총 금액
                newPrice = i.SubItems[2].Text.Remove(0, 1); //특수문자 제거
                totalPrice += int.Parse(newPrice.Replace(",",""));
            }
            lblTotalCnt.Text = totalCnt.ToString();
            lblTotalPrice.Text = totalPrice.ToString("C");
        }

        //카드 결제 준비 중... 누르면 초기화
        private void btnPayCard_Click(object sender, EventArgs e)
        {
            //주문 내역이 비어있지 않으면,
            foreach (ListViewItem i in lstSelMenu.Items)
            {
                MessageBox.Show("카드 결제 완료되었습니다.", "카드 결제");

                //lstSelMenu.Clear();
                //CalTotal();
                this.Controls.Clear(); //삭제
                this.InitializeComponent(); //초기화
                MainForm_Load(this, e); //ui 초기화
                return;
            }
            //주문 내역이 비어있으면,
            MessageBox.Show("주문하실 메뉴를 선택하세요.", "결제 안내");
        }

        //기타 결제 준비 중... 준비 중 알림
        private void btnPayOther_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비 중입니다!!");
        }



        //카테고리 버튼 클릭했을 때,
        //카테고리1: Season
        private void btnCategory1_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.Season);
        }

        //카테고리2: Coffee
        private void btnCategory2_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.Coffee);

            //테스트
            //AddMenuItem(Categories.Coffee, "아메리카노", 1500, Properties.Resources.카페라떼);
        }

        //카테고리3: Noncoffee
        private void btnCategory3_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.NonCoffee);
        }

        //카테고리4: Milkshake
        private void btnCategory4_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.Milkshake);
        }

        //카테고리5: SmoothyFraffe
        private void btnCategory5_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.SmoothyFraffe);
        }

        //카테고리6: AdeJuice
        private void btnCategory6_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.AdeJuice);
        }

        //카테고리7: Tea
        private void btnCategory7_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.Tea);
        }

        //카테고리8: Side
        private void btnCategory8_Click(object sender, EventArgs e)
        {
            menuViewPanel.Controls.Clear();
            showCategoryItems(Categories.Side);
        }

        //메뉴 데이터
        public void showCategoryItems(Categories category)
        {
            //카테고리별
            switch (category)
            {
                //시즌메뉴
                case Categories.Season:
                    //준비중
                    MessageBox.Show("준비 중입니다!!");
                    break;
                //커피
                case Categories.Coffee:
                    AddMenuItem(Categories.Coffee, "에스프레소", 1500, Properties.Resources.에스프레소); //문제: 이미지 resource .resx에 포함 설정
                    AddMenuItem(Categories.Coffee, "아메리카노", 1500, Properties.Resources.아메리카노);
                    AddMenuItem(Categories.Coffee, "카푸치노", 2700, Properties.Resources.카푸치노);
                    AddMenuItem(Categories.Coffee, "카페라떼", 2700, Properties.Resources.카페라떼);
                    AddMenuItem(Categories.Coffee, "바닐라라떼", 3000, Properties.Resources.바닐라라떼);
                    AddMenuItem(Categories.Coffee, "헤이즐넛라떼", 3000, Properties.Resources.헤이즐넛라떼);
                    AddMenuItem(Categories.Coffee, "카라멜마끼아또", 3300, Properties.Resources.카라멜마끼아또);
                    AddMenuItem(Categories.Coffee, "카페모카", 3300, Properties.Resources.카페모카);
                    AddMenuItem(Categories.Coffee, "돌체라떼", 3500, Properties.Resources.돌체라떼);
                    AddMenuItem(Categories.Coffee, "흑당라떼", 3800, Properties.Resources.흑당카페라떼);
                    AddMenuItem(Categories.Coffee, "더치커피", 3000, Properties.Resources.더치커피);
                    AddMenuItem(Categories.Coffee, "더치라떼", 3500, Properties.Resources.더치라떼);
                    AddMenuItem(Categories.Coffee, "아인슈페너라떼", 3900, Properties.Resources.아인슈페너라떼);
                    AddMenuItem(Categories.Coffee, "아인슈페너", 3800, Properties.Resources.아인슈페너);
                    AddMenuItem(Categories.Coffee, "디-더치커피", 3000, Properties.Resources.디카페인더치커피);
                    AddMenuItem(Categories.Coffee, "디-더치라떼", 3500, Properties.Resources.디카페인더치라떼);
                    AddMenuItem(Categories.Coffee, "달고나라떼", 3900, Properties.Resources.달고나라떼);
                    break;
                //논커피
                case Categories.NonCoffee:
                    AddMenuItem(Categories.NonCoffee, "더블초코라떼", 3500, Properties.Resources.더블초코라떼);
                    AddMenuItem(Categories.NonCoffee, "쿠키초코라떼", 3500, Properties.Resources.쿠키초코라떼);
                    AddMenuItem(Categories.NonCoffee, "민트오레오라떼", 3500, Properties.Resources.민트초코오레오라떼);
                    AddMenuItem(Categories.NonCoffee, "그린티라떼", 3500, Properties.Resources.그린티라떼);
                    AddMenuItem(Categories.NonCoffee, "곡물라떼", 3000, Properties.Resources.곡물라떼);
                    AddMenuItem(Categories.NonCoffee, "고구마라떼", 3300, Properties.Resources.고구마라떼);
                    AddMenuItem(Categories.NonCoffee, "밀크티", 3800, Properties.Resources.밀크티);
                    AddMenuItem(Categories.NonCoffee, "흑당밀크", 3500, Properties.Resources.흑당밀크);
                    AddMenuItem(Categories.NonCoffee, "딸기라떼", 3500, Properties.Resources.딸기라떼);
                    break;
                //밀크쉐이크
                case Categories.Milkshake:
                    AddMenuItem(Categories.Milkshake, "밀크쉐이크", 3900, Properties.Resources.플레인밀크쉐이크);
                    AddMenuItem(Categories.Milkshake, "팥절미쉐이크", 4200, Properties.Resources.팥절미밀크쉐이크);
                    AddMenuItem(Categories.Milkshake, "쿠키쉐이크", 4200, Properties.Resources.쿠키밀크쉐이크);
                    AddMenuItem(Categories.Milkshake, "베리베리쉐이크", 3900, Properties.Resources.베리베리밀크쉐이크);
                    AddMenuItem(Categories.Milkshake, "바나나쉐이크", 3900, Properties.Resources.바나나밀크쉐이크);
                    AddMenuItem(Categories.Milkshake, "커피쉐이크", 4200, Properties.Resources.커피밀크쉐이크);
                    break;
                //스무디프라페
                case Categories.SmoothyFraffe:
                    AddMenuItem(Categories.SmoothyFraffe, "자바칩프라페", 3900, Properties.Resources.리얼초코자바칩프라페);
                    AddMenuItem(Categories.SmoothyFraffe, "민트오레오프라페", 3900, Properties.Resources.민트초코오레오프라페);
                    AddMenuItem(Categories.SmoothyFraffe, "쿠키초코프라페", 3900, Properties.Resources.쿠키초코프라페);
                    AddMenuItem(Categories.SmoothyFraffe, "그린티프라페", 3900, Properties.Resources.그린티프라페);
                    AddMenuItem(Categories.SmoothyFraffe, "딸기스무디", 3500, Properties.Resources.딸기스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "망고스무디", 3500, Properties.Resources.망고스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "블루베리스무디", 3500, Properties.Resources.블루베리스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "딸기요거트스무디", 3800, Properties.Resources.딸기요거트스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "망고요거트스무디", 3800, Properties.Resources.망고요거트스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "블루베리요거트스무디", 3800, Properties.Resources.블루베리요거트스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "유자스무디", 3500, Properties.Resources.유자스무디);
                    AddMenuItem(Categories.SmoothyFraffe, "모카자바칩프라페", 3900, Properties.Resources.모카자바칩프라페);
                    break;
                //에이드주스
                case Categories.AdeJuice:
                    AddMenuItem(Categories.AdeJuice, "레몬에이드", 3500, Properties.Resources.레몬에이드);
                    AddMenuItem(Categories.AdeJuice, "자몽에이드", 3500, Properties.Resources.자몽에이드);
                    AddMenuItem(Categories.AdeJuice, "망고에이드", 3500, Properties.Resources.망고에이드);
                    AddMenuItem(Categories.AdeJuice, "유자에이드", 3500, Properties.Resources.유자에이드);
                    AddMenuItem(Categories.AdeJuice, "청포도에이드", 3500, Properties.Resources.청포도에이드);
                    AddMenuItem(Categories.AdeJuice, "레몬에이드", 3500, Properties.Resources.레몬에이드);
                    AddMenuItem(Categories.AdeJuice, "블루레몬에이드", 3500, Properties.Resources.블루레몬에이드);
                    AddMenuItem(Categories.AdeJuice, "패션후르츠에이드", 3500, Properties.Resources.패션후르츠에이드);
                    AddMenuItem(Categories.AdeJuice, "타트체리에이드", 3500, Properties.Resources.타트체리에이드);
                    AddMenuItem(Categories.AdeJuice, "키위주스", 3800, Properties.Resources.키위주스);
                    AddMenuItem(Categories.AdeJuice, "복숭아주스", 3800, Properties.Resources.복숭아주스);
                    AddMenuItem(Categories.AdeJuice, "샤인케일주스", 3800, Properties.Resources.샤인파인케일주스);
                    AddMenuItem(Categories.AdeJuice, "오당주스", 3800, Properties.Resources.오렌지당근주스);
                    break;
                //티
                case Categories.Tea:
                    AddMenuItem(Categories.Tea, "페퍼민트", 2500, Properties.Resources.페퍼민트);
                    AddMenuItem(Categories.Tea, "캐모마일", 2500, Properties.Resources.캐모마일);
                    AddMenuItem(Categories.Tea, "로즈마리", 2500, Properties.Resources.로즈마리);
                    AddMenuItem(Categories.Tea, "얼그레이", 2500, Properties.Resources.얼그레이);
                    AddMenuItem(Categories.Tea, "블랙퍼스트", 2500, Properties.Resources.자몽허니블랙티);
                    AddMenuItem(Categories.Tea, "허니자몽티", 3500, Properties.Resources.허니자몽티);
                    AddMenuItem(Categories.Tea, "허니유자티", 3500, Properties.Resources.허니유자티);
                    AddMenuItem(Categories.Tea, "허니레몬티", 3500, Properties.Resources.허니레몬티);
                    AddMenuItem(Categories.Tea, "복숭아티", 3000, Properties.Resources.복숭아티);
                    AddMenuItem(Categories.Tea, "자몽허니블랙티", 3800, Properties.Resources.자몽허니블랙티);
                    break;
                //사이드
                case Categories.Side:
                    AddMenuItem(Categories.Tea, "초코마카롱", 1500, Properties.Resources.초코마카롱);
                    AddMenuItem(Categories.Tea, "산딸기마카롱", 1500, Properties.Resources.산딸기마카롱);
                    AddMenuItem(Categories.Tea, "카라멜마카롱", 1500, Properties.Resources.카라멜마카롱);
                    AddMenuItem(Categories.Tea, "모카마카롱", 1500, Properties.Resources.모카마카롱);
                    AddMenuItem(Categories.Tea, "바닐라마카롱", 1500, Properties.Resources.바닐라마카롱);
                    break;
                default:
                    break;

            }
        }

    }
}