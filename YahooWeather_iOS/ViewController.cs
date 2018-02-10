using System;

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
