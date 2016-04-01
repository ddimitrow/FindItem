namespace FindItems
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPicture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstimateProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSellOnEbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckEbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panSearchNiche = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.domainUpDownPages = new System.Windows.Forms.DomainUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSearchItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEbay = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabAmazon = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabControl.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panSearchNiche.SuspendLayout();
            this.tabEbay.SuspendLayout();
            this.tabAmazon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Controls.Add(this.tabEbay);
            this.tabControl.Controls.Add(this.tabAmazon);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1139, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.listView1);
            this.tabSearch.Controls.Add(this.label3);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.panel2);
            this.tabSearch.Controls.Add(this.panel3);
            this.tabSearch.Controls.Add(this.panSearchNiche);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1131, 574);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search Amazon & Compare Ebay";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colPicture,
            this.colTitle,
            this.colLink,
            this.colPrice,
            this.colEstimateProfit,
            this.colType,
            this.colSellOnEbay,
            this.colCheckEbay});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(11, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1112, 364);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 33;
            // 
            // colPicture
            // 
            this.colPicture.Text = "Item Picture";
            this.colPicture.Width = 120;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 178;
            // 
            // colLink
            // 
            this.colLink.Text = "Link";
            this.colLink.Width = 284;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 86;
            // 
            // colEstimateProfit
            // 
            this.colEstimateProfit.Text = "Estimate Profit";
            this.colEstimateProfit.Width = 83;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 118;
            // 
            // colSellOnEbay
            // 
            this.colSellOnEbay.Text = "Sell one like this";
            this.colSellOnEbay.Width = 96;
            // 
            // colCheckEbay
            // 
            this.colCheckEbay.Text = "Check Ebay Price";
            this.colCheckEbay.Width = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Analytics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clear/Save Options";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(354, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 144);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(569, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 144);
            this.panel3.TabIndex = 1;
            // 
            // panSearchNiche
            // 
            this.panSearchNiche.Controls.Add(this.btnSearch);
            this.panSearchNiche.Controls.Add(this.domainUpDownPages);
            this.panSearchNiche.Controls.Add(this.comboBox2);
            this.panSearchNiche.Controls.Add(this.comboBox1);
            this.panSearchNiche.Controls.Add(this.label6);
            this.panSearchNiche.Controls.Add(this.label5);
            this.panSearchNiche.Controls.Add(this.label4);
            this.panSearchNiche.Controls.Add(this.txtBoxSearchItem);
            this.panSearchNiche.Controls.Add(this.label1);
            this.panSearchNiche.Location = new System.Drawing.Point(11, 41);
            this.panSearchNiche.Name = "panSearchNiche";
            this.panSearchNiche.Size = new System.Drawing.Size(337, 144);
            this.panSearchNiche.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(173, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // domainUpDownPages
            // 
            this.domainUpDownPages.Location = new System.Drawing.Point(105, 118);
            this.domainUpDownPages.Name = "domainUpDownPages";
            this.domainUpDownPages.Size = new System.Drawing.Size(57, 20);
            this.domainUpDownPages.TabIndex = 8;
            this.domainUpDownPages.Text = "5";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.GotFocus += new System.EventHandler(this.comboBox2_GotFocus);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.GotFocus += new System.EventHandler(this.comboBox1_GotFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "How many Pages?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amazon Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ebay Categories";
            // 
            // txtBoxSearchItem
            // 
            this.txtBoxSearchItem.Location = new System.Drawing.Point(6, 22);
            this.txtBoxSearchItem.Name = "txtBoxSearchItem";
            this.txtBoxSearchItem.Size = new System.Drawing.Size(325, 20);
            this.txtBoxSearchItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Niche";
            // 
            // tabEbay
            // 
            this.tabEbay.Controls.Add(this.webBrowser1);
            this.tabEbay.Location = new System.Drawing.Point(4, 22);
            this.tabEbay.Name = "tabEbay";
            this.tabEbay.Padding = new System.Windows.Forms.Padding(3);
            this.tabEbay.Size = new System.Drawing.Size(1131, 574);
            this.tabEbay.TabIndex = 1;
            this.tabEbay.Text = "Browser - Ebay";
            this.tabEbay.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1125, 568);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.ebay.com", System.UriKind.Absolute);
            // 
            // tabAmazon
            // 
            this.tabAmazon.Controls.Add(this.webBrowser2);
            this.tabAmazon.Location = new System.Drawing.Point(4, 22);
            this.tabAmazon.Name = "tabAmazon";
            this.tabAmazon.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmazon.Size = new System.Drawing.Size(1131, 574);
            this.tabAmazon.TabIndex = 2;
            this.tabAmazon.Text = "Browser - Amazon";
            this.tabAmazon.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1125, 568);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("http://www.amazon.com", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.panSearchNiche.ResumeLayout(false);
            this.panSearchNiche.PerformLayout();
            this.tabEbay.ResumeLayout(false);
            this.tabAmazon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabEbay;
        private System.Windows.Forms.TabPage tabAmazon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colPicture;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colLink;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colEstimateProfit;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSellOnEbay;
        private System.Windows.Forms.ColumnHeader colCheckEbay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panSearchNiche;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DomainUpDown domainUpDownPages;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSearchItem;
    }
}

