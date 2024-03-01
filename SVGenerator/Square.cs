using System.Drawing;

namespace Svgenerator;

public class Square : Shape
{
    public Point TopLeft { get; set; }
    public int SideLength { get; set; }
    public Color? FillColor { get; set; }
    public Color? StrokeColor { get; set; }
    public int? StrokeWidth { get; set; }

    public Square(Point topLeft, int sideLength, Color? fillColor, Color? strokeColor, int? strokeWidth)
    {
        this.TopLeft = topLeft;
        this.SideLength = sideLength;
        this.FillColor = fillColor;
        this.StrokeColor = strokeColor;
        this.StrokeWidth = strokeWidth;
    }

    public string ToSvgString()
    {
        return $@"<rect x=""{this.TopLeft.X}"" y=""{this.TopLeft.Y}"" width=""{this.SideLength}"" height=""{this.SideLength}"" stroke=""{this.StrokeColor?.Name}"" stroke-width=""{this.StrokeWidth}"" fill=""{this.FillColor?.Name}"" />";
    }
}
