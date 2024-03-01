using System.Drawing;

namespace Svgenerator;

public class Circle : Shape
{
    public Point Center { get; set; }
    public int Radius { get; set; }
    public Color FillColor { get; set; }
    public Color StrokeColor { get; set; }
    public int StrokeWidth { get; set; }

    public Circle(Point center, int radius, Color fillColor, Color strokeColor, int strokeWidth)
    {
        this.Center = center;
        this.Radius = radius;
        this.FillColor = fillColor;
        this.StrokeColor = strokeColor;
        this.StrokeWidth = strokeWidth;
    }

    public string ToSvgString()
    {
        return $@"<circle cx=""{this.Center.X}"" cy=""{this.Center.Y}"" r=""{this.Radius}"" stroke=""{this.StrokeColor.Name}"" stroke-width=""{this.StrokeWidth}"" fill=""{this.FillColor.Name}"" />";
    }
}
