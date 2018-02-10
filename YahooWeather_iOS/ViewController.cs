using System;
using System.Drawing;
using Foundation;
using HtmlAgilityPack;
using UIKit;

namespace YahooWeather_iOS
{
    public partial class ViewController : UIViewController
    {
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        partial void TappedStart(UIButton sender)
        {
            this.labelTitle.Text = "Yahoo! お天気";
            this.labelAnnounce.Text = "発表日時：2018年2月10日 12時";
            this.labelDate.Text = "日付け：2018年2月10日";
            this.labelWeather.Text = "天気：晴れ後曇り";
            this.labelTempHigh.Text = "最高気温：10℃";
            this.labelTempLow.Text = "最低気温：5℃";

            this.labelPrecip01.Text = "0%";
            this.labelPrecip02.Text = "5%";
            this.labelPrecip03.Text = "50%";
            this.labelPrecip04.Text = "100%";

            //(1)指定したサイトのHTMLをストリームで取得する
            const string url = "https://weather.yahoo.co.jp/weather/jp/14/4610.html";
            var urlstring = string.Format(url);

            //(2)指定したサイトのHTMLをストリームで取得する
            var doc = new HtmlAgilityPack.HtmlDocument();
            using (var client = new System.Net.WebClient())
            {
                var html = client.DownloadString(new Uri(urlstring));

                // HtmlAgilityPack.HtmlDocumentオブジェクトにHTMLを読み込ませる
                doc.LoadHtml(html);
            }

            //(3)XPathを使って情報を抽出
            //タイトル
            HtmlNodeCollection node0 =
            doc.DocumentNode.SelectNodes("//title");
            this.labelTitle.Text = node0[0].InnerText;

            //Anounce Date & Time（発表日時）
            HtmlNodeCollection node1 =
            doc.DocumentNode.SelectNodes("//div[@class='yjw_title_h2 yjw_clr']//p[@class='yjSt yjw_note_h2']");
            this.labelAnnounce.Text = node1[0].InnerText;    //node1(0).InnerText

            //WeatherDate（対象日）
            HtmlNodeCollection node2 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='date']");
            this.labelDate.Text = node2[0].InnerText;

            //Weather（天候）
            HtmlNodeCollection node3 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']");
            this.labelWeather.Text = node3[0].InnerText;

            //High Temp（最高気温）
            HtmlNodeCollection node4 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='high']");
            this.labelTempHigh.Text = "最高気温 [前日差]： " + node4[0].InnerText;

            //Low Temp（最低気温）
            HtmlNodeCollection node5 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='low']");
            this.labelTempLow.Text = "最低気温 [前日差]： " + node5[0].InnerText;

            //Precip1[0-6]（降水確率）
            HtmlNodeCollection node6 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//tr[@class='precip']//td");
            this.labelPrecip01.Text = node6[0].InnerText;

            //Precip1[6-12]（降水確率）
            this.labelPrecip02.Text = node6[1].InnerText;

            //Precip1[12-18]（降水確率）
            this.labelPrecip03.Text = node6[2].InnerText;

            //Precip1[18-24]（降水確率）
            this.labelPrecip04.Text = node6[3].InnerText;

            //WeatherPicture（天気画像）
            HtmlNodeCollection node7 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']//img");
            //this.imageWeather.Image = node7[0].GetAttributeValue("src", "");
       
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
