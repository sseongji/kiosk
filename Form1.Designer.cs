namespace KioskApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPayOther = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstSelMenu = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPayCard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCnt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCategory8 = new System.Windows.Forms.Button();
            this.btnCategory7 = new System.Windows.Forms.Button();
            this.btnCategory6 = new System.Windows.Forms.Button();
            this.btnCategory5 = new System.Windows.Forms.Button();
            this.btnCategory4 = new System.Windows.Forms.Button();
            this.btnCategory3 = new System.Windows.Forms.Button();
            this.btnCategory2 = new System.Windows.Forms.Button();
            this.btnCategory1 = new System.Windows.Forms.Button();
            this.menuViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.menuViewPanel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.label6, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.939147F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.63488F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.42596F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(494, 842);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.btnPayOther, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPayCard, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 597);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 242);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPayOther
            // 
            this.btnPayOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayOther.BackColor = System.Drawing.Color.Gold;
            this.btnPayOther.FlatAppearance.BorderSize = 0;
            this.btnPayOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOther.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPayOther.Location = new System.Drawing.Point(393, 149);
            this.btnPayOther.Name = "btnPayOther";
            this.btnPayOther.Size = new System.Drawing.Size(92, 90);
            this.btnPayOther.TabIndex = 4;
            this.btnPayOther.Text = "기타결제";
            this.btnPayOther.UseVisualStyleBackColor = false;
            this.btnPayOther.Click += new System.EventHandler(this.btnPayOther_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문 내역";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lstSelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(263, 182);
            this.panel1.TabIndex = 1;
            // 
            // lstSelMenu
            // 
            this.lstSelMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colCnt,
            this.colPrice});
            this.lstSelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelMenu.FullRowSelect = true;
            this.lstSelMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSelMenu.HideSelection = false;
            this.lstSelMenu.HoverSelection = true;
            this.lstSelMenu.Location = new System.Drawing.Point(0, 0);
            this.lstSelMenu.MultiSelect = false;
            this.lstSelMenu.Name = "lstSelMenu";
            this.lstSelMenu.Size = new System.Drawing.Size(263, 182);
            this.lstSelMenu.TabIndex = 0;
            this.lstSelMenu.UseCompatibleStateImageBehavior = false;
            this.lstSelMenu.View = System.Windows.Forms.View.Details;
            this.lstSelMenu.DoubleClick += new System.EventHandler(this.lstSelMenu_DoubleClick);
            // 
            // colTitle
            // 
            this.colTitle.Text = "메뉴";
            this.colTitle.Width = 120;
            // 
            // colCnt
            // 
            this.colCnt.Text = "수량";
            this.colCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCnt.Width = 44;
            // 
            // colPrice
            // 
            this.colPrice.Text = "금액";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 95;
            // 
            // btnPayCard
            // 
            this.btnPayCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayCard.BackColor = System.Drawing.Color.Gold;
            this.btnPayCard.FlatAppearance.BorderSize = 0;
            this.btnPayCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCard.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPayCard.Location = new System.Drawing.Point(393, 53);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(92, 90);
            this.btnPayCard.TabIndex = 3;
            this.btnPayCard.Text = "카드결제";
            this.btnPayCard.UseVisualStyleBackColor = false;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayCard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.lblTotalCnt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 86);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "전체 수량";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCnt
            // 
            this.lblTotalCnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCnt.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalCnt.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTotalCnt.Location = new System.Drawing.Point(0, 32);
            this.lblTotalCnt.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCnt.Name = "lblTotalCnt";
            this.lblTotalCnt.Size = new System.Drawing.Size(114, 33);
            this.lblTotalCnt.TabIndex = 12;
            this.lblTotalCnt.Text = "0";
            this.lblTotalCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Location = new System.Drawing.Point(276, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 92);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "총 결제 금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 34);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(111, 33);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.Text = "\\";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnCategory8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCategory1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 8, 30, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCategory8
            // 
            this.btnCategory8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory8.BackColor = System.Drawing.Color.Gold;
            this.btnCategory8.FlatAppearance.BorderSize = 0;
            this.btnCategory8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory8.Location = new System.Drawing.Point(325, 33);
            this.btnCategory8.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory8.Name = "btnCategory8";
            this.btnCategory8.Size = new System.Drawing.Size(108, 30);
            this.btnCategory8.TabIndex = 7;
            this.btnCategory8.Text = "사이드";
            this.btnCategory8.UseVisualStyleBackColor = false;
            this.btnCategory8.Click += new System.EventHandler(this.btnCategory8_Click);
            // 
            // btnCategory7
            // 
            this.btnCategory7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory7.BackColor = System.Drawing.Color.Gold;
            this.btnCategory7.FlatAppearance.BorderSize = 0;
            this.btnCategory7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory7.Location = new System.Drawing.Point(217, 33);
            this.btnCategory7.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory7.Name = "btnCategory7";
            this.btnCategory7.Size = new System.Drawing.Size(106, 30);
            this.btnCategory7.TabIndex = 6;
            this.btnCategory7.Text = "티";
            this.btnCategory7.UseVisualStyleBackColor = false;
            this.btnCategory7.Click += new System.EventHandler(this.btnCategory7_Click);
            // 
            // btnCategory6
            // 
            this.btnCategory6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory6.BackColor = System.Drawing.Color.Gold;
            this.btnCategory6.FlatAppearance.BorderSize = 0;
            this.btnCategory6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory6.Location = new System.Drawing.Point(109, 33);
            this.btnCategory6.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory6.Name = "btnCategory6";
            this.btnCategory6.Size = new System.Drawing.Size(106, 30);
            this.btnCategory6.TabIndex = 5;
            this.btnCategory6.Text = "에이드/주스";
            this.btnCategory6.UseVisualStyleBackColor = false;
            this.btnCategory6.Click += new System.EventHandler(this.btnCategory6_Click);
            // 
            // btnCategory5
            // 
            this.btnCategory5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory5.BackColor = System.Drawing.Color.Gold;
            this.btnCategory5.FlatAppearance.BorderSize = 0;
            this.btnCategory5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory5.Location = new System.Drawing.Point(1, 33);
            this.btnCategory5.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory5.Name = "btnCategory5";
            this.btnCategory5.Size = new System.Drawing.Size(106, 30);
            this.btnCategory5.TabIndex = 4;
            this.btnCategory5.Text = "스무디/프라페";
            this.btnCategory5.UseVisualStyleBackColor = false;
            this.btnCategory5.Click += new System.EventHandler(this.btnCategory5_Click);
            // 
            // btnCategory4
            // 
            this.btnCategory4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory4.BackColor = System.Drawing.Color.Gold;
            this.btnCategory4.FlatAppearance.BorderSize = 0;
            this.btnCategory4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory4.Location = new System.Drawing.Point(325, 1);
            this.btnCategory4.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory4.Name = "btnCategory4";
            this.btnCategory4.Size = new System.Drawing.Size(108, 30);
            this.btnCategory4.TabIndex = 3;
            this.btnCategory4.Text = "밀크쉐이크";
            this.btnCategory4.UseVisualStyleBackColor = false;
            this.btnCategory4.Click += new System.EventHandler(this.btnCategory4_Click);
            // 
            // btnCategory3
            // 
            this.btnCategory3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory3.BackColor = System.Drawing.Color.Gold;
            this.btnCategory3.FlatAppearance.BorderSize = 0;
            this.btnCategory3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory3.Location = new System.Drawing.Point(217, 1);
            this.btnCategory3.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory3.Name = "btnCategory3";
            this.btnCategory3.Size = new System.Drawing.Size(106, 30);
            this.btnCategory3.TabIndex = 2;
            this.btnCategory3.Text = "논커피";
            this.btnCategory3.UseVisualStyleBackColor = false;
            this.btnCategory3.Click += new System.EventHandler(this.btnCategory3_Click);
            // 
            // btnCategory2
            // 
            this.btnCategory2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory2.BackColor = System.Drawing.Color.Gold;
            this.btnCategory2.FlatAppearance.BorderSize = 0;
            this.btnCategory2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory2.Location = new System.Drawing.Point(109, 1);
            this.btnCategory2.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory2.Name = "btnCategory2";
            this.btnCategory2.Size = new System.Drawing.Size(106, 30);
            this.btnCategory2.TabIndex = 1;
            this.btnCategory2.Text = "커피";
            this.btnCategory2.UseVisualStyleBackColor = false;
            this.btnCategory2.Click += new System.EventHandler(this.btnCategory2_Click);
            // 
            // btnCategory1
            // 
            this.btnCategory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory1.BackColor = System.Drawing.Color.Gold;
            this.btnCategory1.FlatAppearance.BorderSize = 0;
            this.btnCategory1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategory1.Location = new System.Drawing.Point(1, 1);
            this.btnCategory1.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategory1.Name = "btnCategory1";
            this.btnCategory1.Size = new System.Drawing.Size(106, 30);
            this.btnCategory1.TabIndex = 0;
            this.btnCategory1.Text = "시즌메뉴";
            this.btnCategory1.UseVisualStyleBackColor = false;
            this.btnCategory1.Click += new System.EventHandler(this.btnCategory1_Click);
            // 
            // menuViewPanel
            // 
            this.menuViewPanel.AutoScroll = true;
            this.menuViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuViewPanel.Location = new System.Drawing.Point(39, 118);
            this.menuViewPanel.Margin = new System.Windows.Forms.Padding(39, 8, 19, 8);
            this.menuViewPanel.Name = "menuViewPanel";
            this.menuViewPanel.Size = new System.Drawing.Size(436, 468);
            this.menuViewPanel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "COMPOSE COFFEE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 842);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCategory8;
        private System.Windows.Forms.Button btnCategory7;
        private System.Windows.Forms.Button btnCategory6;
        private System.Windows.Forms.Button btnCategory5;
        private System.Windows.Forms.Button btnCategory4;
        private System.Windows.Forms.Button btnCategory3;
        private System.Windows.Forms.Button btnCategory2;
        private System.Windows.Forms.Button btnCategory1;
        private System.Windows.Forms.FlowLayoutPanel menuViewPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPayOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPayCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCnt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstSelMenu;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colCnt;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}

