using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //管理用データ
        List<ItemData> ItemDatas = new List<ItemData>();
        Dictionary<string, string> title = new Dictionary<string, string>{
                {"スポーツ","https://news.yahoo.co.jp/rss/categories/sports.xml"},
                {"経済","https://news.yahoo.co.jp/rss/topics/business.xml"},
                {"ライフ","https://news.yahoo.co.jp/rss/categories/life.xml"}
        };

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {   //フォームの最大化
            this.WindowState = FormWindowState.Maximized;
           
            cbLinq.Items.Add("スポーツ");
            cbLinq.Items.Add("経済");
            cbLinq.Items.Add("ライフ");
            //cbLinq.Items.Add(new ItemData {Title="スポーツ",Link= "https://news.yahoo.co.jp/rss/categories/sports.xml"});
            //cbLinq.Items.Add(new ItemData {Title="経済",Link= "https://news.yahoo.co.jp/rss/topics/business.xml" });
            //cbLinq.Items.Add(new ItemData {Title="ライフ",Link= "https://news.yahoo.co.jp/rss/categories/life.xml" });

        }

        private void btGet_Click(object sender, EventArgs e) {

                if (tbUrl.Text == "")
                return;

            using (var wc = new WebClient()){
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                           .Select(x => new ItemData
                                           {
                                               Title = (string)x.Element("title"),
                                               Link = (string)x.Element("link"),
                                           }).ToList();
                lbRssTitle.Items.Clear();
                foreach (var node in ItemDatas){
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }
        private void lbRssTitle_Click(object sender, EventArgs e) {     //クリックするとブラウザーに写る
            int Browser;

            Browser = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ItemDatas[Browser].Link);
            if (lbRssTitle.SelectedIndex == -1) ;
            //wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);　模範解答
        }

        private void btUrl_Click(object sender, EventArgs e) { //URL1（btUrl）をクリックして保存
            if (!CbKeep.Items.Contains(tbUrl.Text)){
                CbKeep.Items.Add(tbUrl.Text);
            }
        }

        private void CbKeep_SelectedValueChanged(object sender, EventArgs e) { //保存されたURLをクリックして反映
            tbUrl.Text = (string)CbKeep.SelectedItem;
        }

        private void CbLinq_SelectedIndexChanged(object sender, EventArgs e) {
            //      tbUrl.Text = ((ItemData)(cbLinq.SelectedItem)).Link;
            tbUrl.Text = title[cbLinq.Text];
        }
    }
}
//https://news.yahoo.co.jp/rss/topics/business.xml　　　経済
//https://news.yahoo.co.jp/rss/topics/science.xml       科学
//https://news.yahoo.co.jp/rss/categories/life.xml　　　ライフ
//https://news.yahoo.co.jp/rss/categories/sports.xml　　スポーツ
