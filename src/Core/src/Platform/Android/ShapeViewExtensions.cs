﻿using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Platform
{
	public static class ShapeViewExtensions
	{
		public static void UpdateShape(this MauiShapeView nativeView, IShapeView shapeView)
		{
			nativeView.Drawable = new ShapeDrawable(shapeView);
		}

		public static void InvalidateShape(this MauiShapeView nativeView, IShapeView shapeView)
		{
			nativeView.Invalidate();
		}
	}
}