// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace YahooWeather_iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageWeather { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelAnnounce { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPrecip01 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPrecip02 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPrecip03 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPrecip04 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTempHigh { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTempLow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelWeather { get; set; }

        [Action ("TappedStart:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TappedStart (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (imageWeather != null) {
                imageWeather.Dispose ();
                imageWeather = null;
            }

            if (labelAnnounce != null) {
                labelAnnounce.Dispose ();
                labelAnnounce = null;
            }

            if (labelDate != null) {
                labelDate.Dispose ();
                labelDate = null;
            }

            if (labelPrecip01 != null) {
                labelPrecip01.Dispose ();
                labelPrecip01 = null;
            }

            if (labelPrecip02 != null) {
                labelPrecip02.Dispose ();
                labelPrecip02 = null;
            }

            if (labelPrecip03 != null) {
                labelPrecip03.Dispose ();
                labelPrecip03 = null;
            }

            if (labelPrecip04 != null) {
                labelPrecip04.Dispose ();
                labelPrecip04 = null;
            }

            if (labelTempHigh != null) {
                labelTempHigh.Dispose ();
                labelTempHigh = null;
            }

            if (labelTempLow != null) {
                labelTempLow.Dispose ();
                labelTempLow = null;
            }

            if (labelTitle != null) {
                labelTitle.Dispose ();
                labelTitle = null;
            }

            if (labelWeather != null) {
                labelWeather.Dispose ();
                labelWeather = null;
            }
        }
    }
}