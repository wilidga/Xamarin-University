using System;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
  public class MyViewController : UIViewController
  {
    public MyViewController()
    {
    }
    public override void ViewDidLoad()
    {
      base.ViewDidLoad();



      var totalAmount = new UITextField()
      {
        Frame = new CGRect(20, 50, View.Bounds.Width - 40, 35),
        KeyboardType = UIKeyboardType.DecimalPad,
        BorderStyle = UITextBorderStyle.RoundedRect,
        Placeholder = "Enter Total Amount",

    };

      var calcButton = new UIButton()
      {
        Frame = new CGRect(20, 100, View.Bounds.Width - 40, 45),
        BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),

      };

      calcButton.SetTitle("Calculate", UIControlState.Normal);
      this.View.BackgroundColor = UIColor.Yellow;

      var resultLabel = new UILabel()
      {
        Frame = new CGRect(20, 150, View.Bounds.Width -40, 40),
      };

      resultLabel.TextColor = UIColor.Black;
      resultLabel.TextAlignment = UITextAlignment.Center;
      resultLabel.Font = UIFont.SystemFontOfSize(24);
      resultLabel.Text = "Tip is $0.00";

      View.AddSubviews(totalAmount, calcButton, resultLabel);

      calcButton.TouchUpInside += (s, e) =>
      {
        double value = 0;

        Double.TryParse(totalAmount.Text, out value);
        resultLabel.Text = String.Format("Tip is {0:C}", value * 0.2);
        totalAmount.ResignFirstResponder();
      };
    }
  }
}
