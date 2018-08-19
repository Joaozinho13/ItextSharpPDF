using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;

namespace pdftotext
{
    public partial class teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PdfReader pdfReader = new PdfReader("C:\\TESTE\\export.pdf");
            //
            // Summary:
            //     Constructs a Rectangle-object.
            //
            // Parameters:
            //   llx:
            //     lower left x
            //
            //   lly:
            //     lower left y
            //
            //   urx:
            //     upper right x
            //
            //   ury:
            //     upper right y
            Rectangle rect = new Rectangle(800, 700, 0, 500);
            RenderFilter regionFilter = new RegionTextRenderFilter(rect);
            ITextExtractionStrategy strategy = new FilteredTextRenderListener(
                    new LocationTextExtractionStrategy(), regionFilter);
            lblText.Text = PdfTextExtractor.GetTextFromPage(pdfReader, 1, strategy).ToString();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            PdfReader pdfReader = new PdfReader("C:\\TESTE\\export.pdf");
            
            lblText.Text = PdfTextExtractor.GetTextFromPage(pdfReader, 1).ToString();


        }

        protected void bntLimpar_Click(object sender, EventArgs e)
        {


            lblText.Text = string.Empty;


        }
    }
}