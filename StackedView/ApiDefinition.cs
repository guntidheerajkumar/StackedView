using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreAnimation;

namespace StackedView
{
	// @interface JZ : UIView
	[BaseType(typeof(UIView))]
	interface JZ
	{
		// @property (nonatomic, unsafe_unretained) id<JZDataSource> dataSource __attribute__((iboutlet));
		[Export("dataSource", ArgumentSemantic.Assign)]
		JZDataSource DataSource { get; set; }

		[Wrap("WeakDelegate")]
		JZDelegate Delegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<JZDelegate> delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) CGFloat perspective;
		[Export("perspective")]
		nfloat Perspective { get; set; }

		// @property (assign, nonatomic) CGFloat decelerationRate;
		[Export("decelerationRate")]
		nfloat DecelerationRate { get; set; }

		// @property (assign, nonatomic) CGFloat scrollSpeed;
		[Export("scrollSpeed")]
		nfloat ScrollSpeed { get; set; }

		// @property (assign, nonatomic) CGFloat bounceDistance;
		[Export("bounceDistance")]
		nfloat BounceDistance { get; set; }

		// @property (getter = isScrollEnabled, assign, nonatomic) BOOL scrollEnabled;
		[Export("scrollEnabled")]
		bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

		// @property (getter = isPagingEnabled, assign, nonatomic) BOOL pagingEnabled;
		[Export("pagingEnabled")]
		bool PagingEnabled { [Bind("isPagingEnabled")] get; set; }

		// @property (getter = isVertical, assign, nonatomic) BOOL vertical;
		[Export("vertical")]
		bool Vertical { [Bind("isVertical")] get; set; }

		// @property (readonly, getter = isWrapEnabled, nonatomic) BOOL wrapEnabled;
		[Export("wrapEnabled")]
		bool WrapEnabled { [Bind("isWrapEnabled")] get; }

		// @property (assign, nonatomic) BOOL bounces;
		[Export("bounces")]
		bool Bounces { get; set; }

		// @property (assign, nonatomic) CGFloat scrollOffset;
		[Export("scrollOffset")]
		nfloat ScrollOffset { get; set; }

		// @property (readonly, nonatomic) CGFloat offsetMultiplier;
		[Export("offsetMultiplier")]
		nfloat OffsetMultiplier { get; }

		// @property (assign, nonatomic) CGSize contentOffset;
		[Export("contentOffset", ArgumentSemantic.Assign)]
		CGSize ContentOffset { get; set; }

		// @property (assign, nonatomic) CGSize viewpointOffset;
		[Export("viewpointOffset", ArgumentSemantic.Assign)]
		CGSize ViewpointOffset { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfItems;
		[Export("numberOfItems")]
		nint NumberOfItems { get; }

		// @property (readonly, nonatomic) NSInteger numberOfPlaceholders;
		[Export("numberOfPlaceholders")]
		nint NumberOfPlaceholders { get; }

		// @property (assign, nonatomic) NSInteger currentItemIndex;
		[Export("currentItemIndex")]
		nint CurrentItemIndex { get; set; }

		// @property (readonly, nonatomic, strong) UIView * currentItemView;
		[Export("currentItemView", ArgumentSemantic.Strong)]
		UIView CurrentItemView { get; }

		// @property (readonly, nonatomic, strong) NSArray * indexesForVisibleItems;
		[Export("indexesForVisibleItems", ArgumentSemantic.Strong)]
		NSObject[] IndexesForVisibleItems { get; }

		// @property (readonly, nonatomic) NSInteger numberOfVisibleItems;
		[Export("numberOfVisibleItems")]
		nint NumberOfVisibleItems { get; }

		// @property (readonly, nonatomic, strong) NSArray * visibleItemViews;
		[Export("visibleItemViews", ArgumentSemantic.Strong)]
		NSObject[] VisibleItemViews { get; }

		// @property (readonly, nonatomic) CGFloat itemWidth;
		[Export("itemWidth")]
		nfloat ItemWidth { get; }

		// @property (readonly, nonatomic, strong) UIView * contentView;
		[Export("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; }

		// @property (readonly, nonatomic) CGFloat toggle;
		[Export("toggle")]
		nfloat Toggle { get; }

		// @property (assign, nonatomic) CGFloat autoscroll;
		[Export("autoscroll")]
		nfloat Autoscroll { get; set; }

		// @property (assign, nonatomic) BOOL stopAtItemBoundary;
		[Export("stopAtItemBoundary")]
		bool StopAtItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL scrollToItemBoundary;
		[Export("scrollToItemBoundary")]
		bool ScrollToItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL ignorePerpendicularSwipes;
		[Export("ignorePerpendicularSwipes")]
		bool IgnorePerpendicularSwipes { get; set; }

		// @property (assign, nonatomic) BOOL centerItemWhenSelected;
		[Export("centerItemWhenSelected")]
		bool CenterItemWhenSelected { get; set; }

		// @property (readonly, getter = isDragging, nonatomic) BOOL dragging;
		[Export("dragging")]
		bool Dragging { [Bind("isDragging")] get; }

		// @property (readonly, getter = isDecelerating, nonatomic) BOOL decelerating;
		[Export("decelerating")]
		bool Decelerating { [Bind("isDecelerating")] get; }

		// @property (readonly, getter = isScrolling, nonatomic) BOOL scrolling;
		[Export("scrolling")]
		bool Scrolling { [Bind("isScrolling")] get; }

		// -(void)scrollByOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export("scrollByOffset:duration:")]
		void ScrollByOffset(nfloat offset, double duration);

		// -(void)scrollToOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export("scrollToOffset:duration:")]
		void ScrollToOffset(nfloat offset, double duration);

		// -(void)scrollByNumberOfItems:(NSInteger)itemCount duration:(NSTimeInterval)duration;
		[Export("scrollByNumberOfItems:duration:")]
		void ScrollByNumberOfItems(nint itemCount, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index duration:(NSTimeInterval)duration;
		[Export("scrollToItemAtIndex:duration:")]
		void ScrollToItemAtIndex(nint index, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("scrollToItemAtIndex:animated:")]
		void ScrollToItemAtIndex(nint index, bool animated);

		// -(UIView *)itemViewAtIndex:(NSInteger)index;
		[Export("itemViewAtIndex:")]
		UIView ItemViewAtIndex(nint index);

		// -(NSInteger)indexOfItemView:(UIView *)view;
		[Export("indexOfItemView:")]
		nint IndexOfItemView(UIView view);

		// -(NSInteger)indexOfItemViewOrSubview:(UIView *)view;
		[Export("indexOfItemViewOrSubview:")]
		nint IndexOfItemViewOrSubview(UIView view);

		// -(CGFloat)offsetForItemAtIndex:(NSInteger)index;
		[Export("offsetForItemAtIndex:")]
		nfloat OffsetForItemAtIndex(nint index);

		// -(UIView *)itemViewAtPoint:(CGPoint)point;
		[Export("itemViewAtPoint:")]
		UIView ItemViewAtPoint(CGPoint point);

		// -(void)removeItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("removeItemAtIndex:animated:")]
		void RemoveItemAtIndex(nint index, bool animated);

		// -(void)insertItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("insertItemAtIndex:animated:")]
		void InsertItemAtIndex(nint index, bool animated);

		// -(void)reloadItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("reloadItemAtIndex:animated:")]
		void ReloadItemAtIndex(nint index, bool animated);

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @protocol JZDataSource <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface JZDataSource
	{
		// @required -(NSInteger)numberOfItemsInJZStackedView:(JZ *)JZStackedView;
		[Abstract]
		[Export("numberOfItemsInJZStackedView:")]
		nint NumberOfItemsInJZStackedView(JZ JZStackedView);

		// @required -(UIView *)JZStackedView:(JZ *)JZStackedView viewForItemAtIndex:(NSInteger)index reusingView:(UIView *)view;
		[Abstract]
		[Export("JZStackedView:viewForItemAtIndex:reusingView:")]
		UIView JZStackedView(JZ JZStackedView, nint index, UIView view);

		// @optional -(NSInteger)numberOfPlaceholdersInJZStackedView:(JZ *)JZStackedView;
		[Export("numberOfPlaceholdersInJZStackedView:")]
		nint NumberOfPlaceholdersInJZStackedView(JZ JZStackedView);
	}

	// @protocol JZDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface JZDelegate
	{
		// @optional -(void)JZStackedViewWillBeginScrollingAnimation:(JZ *)JZStackedView;
		[Export("JZStackedViewWillBeginScrollingAnimation:")]
		void JZStackedViewWillBeginScrollingAnimation(JZ JZStackedView);

		// @optional -(void)JZStackedViewDidEndScrollingAnimation:(JZ *)JZStackedView;
		[Export("JZStackedViewDidEndScrollingAnimation:")]
		void JZStackedViewDidEndScrollingAnimation(JZ JZStackedView);

		// @optional -(void)JZStackedViewDidScroll:(JZ *)JZStackedView;
		[Export("JZStackedViewDidScroll:")]
		void JZStackedViewDidScroll(JZ JZStackedView);

		// @optional -(void)JZStackedViewCurrentItemIndexDidChange:(JZ *)JZStackedView;
		[Export("JZStackedViewCurrentItemIndexDidChange:")]
		void JZStackedViewCurrentItemIndexDidChange(JZ JZStackedView);

		// @optional -(void)JZStackedViewWillBeginDragging:(JZ *)JZStackedView;
		[Export("JZStackedViewWillBeginDragging:")]
		void JZStackedViewWillBeginDragging(JZ JZStackedView);

		// @optional -(void)JZStackedViewDidEndDragging:(JZ *)JZStackedView willDecelerate:(BOOL)decelerate;
		[Export("JZStackedViewDidEndDragging:willDecelerate:")]
		void JZStackedViewDidEndDragging(JZ JZStackedView, bool decelerate);

		// @optional -(void)JZStackedViewWillBeginDecelerating:(JZ *)JZStackedView;
		[Export("JZStackedViewWillBeginDecelerating:")]
		void JZStackedViewWillBeginDecelerating(JZ JZStackedView);

		// @optional -(void)JZStackedViewDidEndDecelerating:(JZ *)JZStackedView;
		[Export("JZStackedViewDidEndDecelerating:")]
		void JZStackedViewDidEndDecelerating(JZ JZStackedView);

		//// @optional -(BOOL)JZStackedView:(JZ *)JZStackedView shouldSelectItemAtIndex:(NSInteger)index;
		//[Export("JZStackedView:shouldSelectItemAtIndex:")]
		//bool JZStackedView(JZ JZStackedView, nint index);

		// @optional -(void)JZStackedView:(JZ *)JZStackedView didSelectItemAtIndex:(NSInteger)index;
		[Export("JZStackedView:didSelectItemAtIndex:")]
		void JZStackedView(JZ JZStackedView, nint index);

		// @optional -(CGFloat)JZStackedViewItemWidth:(JZ *)JZStackedView;
		[Export("JZStackedViewItemWidth:")]
		nfloat JZStackedViewItemWidth(JZ JZStackedView);

		// @optional -(CATransform3D)JZStackedView:(JZ *)JZStackedView itemTransformForOffset:(CGFloat)offset baseTransform:(CATransform3D)transform;
		[Export("JZStackedView:itemTransformForOffset:baseTransform:")]
		CATransform3D JZStackedView(JZ JZStackedView, nfloat offset, CATransform3D transform);

		// @optional -(CGFloat)JZStackedView:(JZ *)JZStackedView valueForOption:(JZOption)option withDefault:(CGFloat)value;
		[Export("JZStackedView:valueForOption:withDefault:")]
		nfloat JZStackedView(JZ JZStackedView, JZOption option, nfloat value);
	}
}
