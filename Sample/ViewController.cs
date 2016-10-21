using System;
using StackedView;
using UIKit;
using CoreGraphics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			JZ sView = new JZ();
			sView.Frame = new CGRect(0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height * 0.75);
			sView.Center = new CGPoint(this.View.Frame.Size.Width * 0.5, this.View.Frame.Size.Height * 0.5);
			sView.Bounces = true;
			sView.ScrollSpeed = 0.85f;
			sView.Vertical = true;
			sView.BounceDistance = 0.4f;
			sView.PagingEnabled = true;
			sView.IgnorePerpendicularSwipes = true;
			sView.Delegate = new JDelegate();
			sView.DataSource = new JZSource();
			this.View.AddSubview(sView);
		}
		public class JDelegate : JZDelegate
		{
			public override void JZStackedViewCurrentItemIndexDidChange(JZ JZStackedView)
			{
				if (JZStackedView.VisibleItemViews.Length > 0) {
					UIView view0 = (UIView)JZStackedView.VisibleItemViews[0];
					UIView.Animate(0.35, () => {
						view0.Alpha = 0.25f;
					}, () => {
					});
				}

				if (JZStackedView.VisibleItemViews.Length > 2) {
					UIView view1 = (UIView)JZStackedView.VisibleItemViews[1];
					UIView.Animate(0.35, () => {
						view1.Alpha = 0.45f;
					}, () => {
					});
				}

				if (JZStackedView.VisibleItemViews.Length == 3) {
					UIView view2 = (UIView)JZStackedView.VisibleItemViews[2];
					UIView.Animate(0.35, () => {
						view2.Alpha = 1.0f;
					}, () => {
					});
				}

				if (JZStackedView.VisibleItemViews.Length > 0) {

					UIView.Animate(0.35, () => {
						JZStackedView.CurrentItemView.Alpha = 1.0f;
					}, () => {
					});
				}
			}
		}

		public class JZSource : JZDataSource
		{

			public override UIView JZStackedView(JZ JZStackedView, nint index, UIView view)
			{
				if (view == null) {
					view = new UIView(new CGRect(0, 0, 345 * 0.9, 600 * 0.71));
					view.BackgroundColor = UIColor.Blue;
					view.Layer.CornerRadius = 5.0f;
					view.ContentMode = UIViewContentMode.Center;
					UIBezierPath path = UIBezierPath.FromRect(view.Bounds);
					view.Layer.MasksToBounds = false;
					view.Layer.ShadowColor = UIColor.Black.CGColor;
					view.Layer.ShadowOffset = new CGSize(0f, 3f);
					view.Layer.ShadowOpacity = 0.2f;
					view.Layer.ShadowPath = path.CGPath;
				}
				return view;
			}

			public override nint NumberOfItemsInJZStackedView(JZ JZStackedView)
			{
				return 10;
			}
		}
	}
}