using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using System.Drawing;

namespace DioDocsTest
{
    class QuickStart
    {
        public void createHelloWorldPDF ()
        {
            // create a new PDF document
            GcPdfDocument doc = new GcPdfDocument();
            // add a page, get the graphics
            GcPdfGraphics g = doc.NewPage().Graphics;
            // render the string in the page
            g.DrawString("Hello, World",
                    new TextFormat() { Font = StandardFonts.Times, FontSize = 12 },
                    new PointF(72, 72));
            // save the PDF
            doc.Save("HelloWorld.pdf");
        }
    }
}
