using Aspose.Svg;
using Aspose.Svg.Builder;
using System.Drawing;


// Initialize an SVG document
using (var document = new SVGDocument())
{
    // Create an <svg> element with specified width, height and viewBox, and add into it other required elements
    var svg = new SVGSVGElementBuilder()
        .Width(100).Height(100)
        .ViewBox(-21, -21, 42, 42)
        .AddDefs(def => def
            .AddRadialGradient(id: "b", cx: .2, cy: .2, r: .5, fx: .2, fy: .2, extend: ev => ev
                .AddStop(offset: 0, stopColor: Color.FromArgb(0xff, 0xff, 0xFF), stopOpacity: .7)
                .AddStop(offset: 1, stopColor: Color.FromArgb(0xff, 0xff, 0xFF), stopOpacity: 0)
            )
            .AddRadialGradient(id: "a", cx: .5, cy: .5, r: .5, extend: ev => ev
                .AddStop(offset: 0, stopColor: Color.FromArgb(0xff, 0xff, 0x00))
                .AddStop(offset: .75, stopColor: Color.FromArgb(0xff, 0xff, 0x00))
                .AddStop(offset: .95, stopColor: Color.FromArgb(0xee, 0xee, 0x00))
                .AddStop(offset: 1, stopColor: Color.FromArgb(0xe8, 0xe8, 0x00))
            )
        )
        .AddCircle(r: 20, fill: "url( #a)", stroke: Color.FromArgb(0, 0, 0), extend: c => c.StrokeWidth(.15))
        .AddCircle(r: 20, fill: "b")
        .AddG(g => g.Id("c")
            .AddEllipse(cx: -6, cy: -7, rx: 2.5, ry: 4)
            .AddPath(fill: Paint.None, stroke: Color.FromArgb(0, 0, 0), d: "M10.6 2.7a4 4 0 0 0 4 3", extend: e => e.StrokeWidth(.5).StrokeLineCap(StrokeLineCap.Round))
        )
        .AddUse(href: "#c", extend: e => e.Transform(t => t.Scale(-1, 1)))
        .AddPath(d: "M-12 5a13.5 13.5 0 0 0 24 0 13 13 0 0 1-24 0", fill:Paint.None, stroke: Color.FromArgb(0,0,0), extend: e => e.StrokeWidth(.75))
        .Build(document.FirstChild as SVGSVGElement);

    // Save the SVG document
    document.Save(Path.Combine(Directory.GetCurrentDirectory().Split("bin/")[0], "face.svg"));
}
