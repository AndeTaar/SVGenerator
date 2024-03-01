// See https://aka.ms/new-console-template for more information

using System.Drawing;
using Svgenerator;
using Point = Svgenerator.Point;
using Rectangle = Svgenerator.Rectangle;

// SVG content
SvgDocument svgDocument = new SvgDocument("output.svg", 200, 200);

Square square = new Square(new Point(10, 10), 180, Color.White, Color.Black, 3);
svgDocument.Shapes.Add(square);

List<Point> points = new List<Point>()
{
    new Point(70, 70),
    new Point(130, 70),
    new Point(70, 70),
    new Point(130, 70),
    new Point(100, 100),
    new Point(85, 85),
    new Point(115, 85)
};
List<Circle> circles = new List<Circle>()
{
    new Circle(points[0], 37, Color.Black, Color.Black, 1),
    new Circle(points[1], 37, Color.Black, Color.Black, 1),
    new Circle(points[2], 30, Color.White, Color.Black, 1),
    new Circle(points[3], 30, Color.White, Color.Black, 1),
    new Circle(points[4], 50, Color.White, Color.Black, 3),
    new Circle(points[5], 10, Color.White, Color.Black, 3),
    new Circle(points[6], 10, Color.White, Color.Black, 3)
};

Line line = new Line(new Point(0, 0), new Point(200, 200), Color.Red, 10);
Line line2 = new Line(new Point(200, 0), new Point(0, 200), Color.Red, 10);

svgDocument.Shapes.AddRange(circles);
svgDocument.Shapes.Add(line);
svgDocument.Shapes.Add(line2);

Text txt = new Text("It's even worse for mouses!", new Point(17, 170), 14, "Arial", Color.Black, null, null);
svgDocument.Shapes.Add(txt);
svgDocument.SaveContent();
