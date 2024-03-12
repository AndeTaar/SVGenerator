namespace Svgenerator;

public class SvgDocument
{
    public string Name { get; set; }

    public string Content { get; set; }

    private string FilePath { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public List<Shape> Shapes { get; set; }

    public SvgDocument(string name, int width, int height)
    {
        this.Name = name;
        this.Width = width;
        this.Height = height;
        this.Shapes = new List<Shape>();
        this.FilePath = Path.Combine(Directory.GetCurrentDirectory().Split("bin/")[0], name);
    }

    public void SaveContent()
    {
        this.GenerateContent(this.Shapes);
        this.Save();
    }

    private void GenerateContent(List<Shape> shapes)
    {
        string content = $@"<svg width=""{this.Width}"" height=""{this.Height}"" xmlns=""http://www.w3.org/2000/svg"">";

        foreach (var shape in shapes)
        {
            content += "    " + shape.ToSvgString(new Point(0,0)) + "\n";
        }
        content += "</svg>";
        this.Content = content;
    }


    private void Save()
    {
        File.WriteAllText(this.FilePath, this.Content);
        Console.WriteLine("SVG created and saved successfully to " + this.FilePath);
    }
}
