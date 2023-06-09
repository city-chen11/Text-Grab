using System;
using System.Drawing;
using System.Windows;

namespace Text_Grab;

public static class ShapeExtensions
{
    public static Rectangle RectangleFromRect(Rect rect)
    {
        return new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
    }

    public static Rect GetScaledDownByDpi(this Rect rect, DpiScale dpi)
    {
        return new Rect(rect.X / dpi.DpiScaleX,
                    rect.Y / dpi.DpiScaleY,
                    rect.Width / dpi.DpiScaleX,
                    rect.Height / dpi.DpiScaleY);
    }

    public static Rect GetScaledUpByDpi(this Rect rect, DpiScale dpi)
    {
        return new Rect(rect.X * dpi.DpiScaleX,
                    rect.Y * dpi.DpiScaleY,
                    rect.Width * dpi.DpiScaleX,
                    rect.Height * dpi.DpiScaleY);
    }

    public static Rect GetScaledUpByFraction(this Rect rect, Double scaleFactor)
    {
        return new Rect(rect.X * scaleFactor,
                    rect.Y * scaleFactor,
                    rect.Width * scaleFactor,
                    rect.Height * scaleFactor);
    }

    public static Rect GetScaleSizeByFraction(this Rect rect, Double scaleFactor)
    {
        return new Rect(rect.X,
                    rect.Y,
                    rect.Width * scaleFactor,
                    rect.Height * scaleFactor);
    }
}