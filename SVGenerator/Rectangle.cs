using System.Drawing;

namespace Svgenerator;

public class Rectangle : Shape
{
    public Point TopLeft { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Color FillColor { get; set; }
    public Color StrokeColor { get; set; }
    public int StrokeWidth { get; set; }

    public Rectangle(Point topLeft, int width, int height, Color fillColor, Color strokeColor, int strokeWidth)
    {
        this.TopLeft = topLeft;
        this.Width = width;
        this.Height = height;
        this.FillColor = fillColor;
        this.StrokeColor = strokeColor;
        this.StrokeWidth = strokeWidth;
    }

    public string ToSvgString()
    {
        return $@"<rect x=""{this.TopLeft.X}"" y=""{this.TopLeft.Y}"" width=""{this.Width}"" height=""{this.Height}"" stroke=""{this.StrokeColor.Name}"" stroke-width=""{this.StrokeWidth}"" fill=""{this.FillColor.Name}"" />";
    }

}
