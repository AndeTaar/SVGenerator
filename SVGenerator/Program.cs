// See https://aka.ms/new-console-template for more information

using System.Drawing;
using Svgenerator;
using Point = Svgenerator.Point;
using Rectangle = Svgenerator.Rectangle;

// SVG content
SvgDocument svgDocument = new SvgDocument("output.svg", 200, 200);

Square square = new Square(new Point(10, 10), 180, Color.White, Color.Black, 3);
svgDocument.Shapes.Add(square);


Group mouse = new Group( "mouse" , new Point(100, 100));

Group mouseEars = new Group("mouseEars", new Point(0, -70));
Circle leftEar = new Circle(new Point(-30, 0), 37, Color.Black, Color.Black, 1);
Circle rightEar = new Circle(new Point(30, 0), 37, Color.Black, Color.Black, 1);
mouseEars.AddShapeRange(new List<Shape>() {leftEar, rightEar});

Group mouseFace = new Group("mouseFace", new Point(0,0));
Circle leftEye = new Circle(new Point(-30, 0), 30, Color.White, Color.Black, 1);
Circle rightEye = new Circle(new Point(30, 0), 30, Color.White, Color.Black, 1);
Circle nose = new Circle(new Point(0, 30), 50, Color.White, Color.Black, 3);
mouseFace.AddShapeRange(new List<Shape>() {leftEye, rightEye, nose});

Group mouseMouth = new Group("mouseMouth", new Point(0,0));
Circle leftWhisker = new Circle(new Point(-15, -15), 10, Color.White, Color.Black, 3);
Circle rightWhisker = new Circle(new Point(15, -15), 10, Color.White, Color.Black, 3);
mouseMouth.AddShapeRange(new List<Shape>() {leftWhisker, rightWhisker});

mouse.AddGroupRange(new List<Group>() {mouseEars, mouseFace, mouseMouth});

Point x = new Point(0, 0);
Line line = new Line(x, new Point(200, 200), Color.Red, 10);
Line line2 = new Line(new Point(200, 0), new Point(0, 200), Color.Red, 10);
Line line3 = new Line(new Point(100, 0), new Point(100, 200), Color.Aquamarine, 10);
svgDocument.Shapes.Add(mouse);
svgDocument.Shapes.Add(line);
svgDocument.Shapes.Add(line2);
svgDocument.Shapes.Add(line3);
Rectangle rect = new Rectangle(new Point(10, 150), 180, 40, Color.White, Color.Black, 3);
svgDocument.Shapes.Add(rect);

Text txt = new Text("It's even worse for mouses!", new Point(17, 170), 14, "Arial", Color.Black, null, null);
svgDocument.Shapes.Add(txt);
svgDocument.SaveContent();
