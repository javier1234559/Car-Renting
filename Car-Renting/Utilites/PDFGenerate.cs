using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Car_Renting
{
    public class PDFGenerate
    {
        private static PDFGenerate Instance;
        public string pdfPath;

        private PDFGenerate() { }

        public static PDFGenerate getInstance()
        {
            if (Instance == null)
                Instance = new PDFGenerate();

            return Instance;
        }

        public void GeneratePDFRent(string pdfPath, Rent rent, Car car, Client client, User user)
        {
            if (String.IsNullOrEmpty(pdfPath)) return;

            PdfWriter writer = new PdfWriter(pdfPath);
            PdfDocument pdfDoc = new PdfDocument(writer);
            pdfDoc.SetDefaultPageSize(PageSize.A4);
            Document document = new Document(pdfDoc);

            Paragraph header = new Paragraph("Car Rental Contact")
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(20).SetBold();

            Paragraph subheader = new Paragraph("Please make sure to verify our contact information carefully before leaving our company")
                                   .SetTextAlignment(TextAlignment.CENTER)
                                   .SetFontSize(13);

            LineSeparator ls = new LineSeparator(new SolidLine());

            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string imagePath = @"./Resources/HeroContactCarRental.jpg";
            string filePath = System.IO.Path.Combine(projectPath, imagePath);
            Image image = new Image(ImageDataFactory.Create(filePath))
                                                    .Scale(1, 0.5f)
                                                    .SetMarginTop(20).SetAutoScaleWidth(true)
                                                    .SetTextAlignment(TextAlignment.CENTER);

            document.Add(header);
            document.Add(subheader);
            document.Add(ls);
            document.Add(image);

            // create a new Paragraph
            Paragraph content = new Paragraph();


            // add the value of the User object's Name property to the Paragraph
            if (user != null)
            {
                content.Add(new Text("Invoice Generation Staff : ").SetBold());
                content.Add(new Text(user.Name + "\n"));
            }

            // add the values of the Client object to the Paragraph
            foreach (var property in client.GetType().GetProperties())
            {
                if (!property.Name.Contains("Id"))
                {
                    content.Add(new Text(property.Name + ": ").SetBold());
                    content.Add(new Text(property.GetValue(client, null)?.ToString() + "\n"));
                }
            }

            // add the values of the Car object to the Paragraph
            foreach (var property in car.GetType().GetProperties())
            {
                if (property.Name.Contains("Id") == false && property.Name.Contains("ImageCar") == false)
                {
                    content.Add(new Text(property.Name + ": ").SetBold());
                    content.Add(new Text(property.GetValue(car, null)?.ToString() + "\n"));
                }
            }

            // add the values of the Rent object to the Paragraph
            foreach (var property in rent.GetType().GetProperties())
            {
                if (!property.Name.Contains("Id"))
                {
                    content.Add(new Text(property.Name + ": ").SetBold());
                    content.Add(new Text(property.GetValue(rent, null)?.ToString() + "\n"));
                }
            }

            // add the content Paragraph to the document
            document.Add(content);
            document.Close();
            pdfDoc.Close();
        }

    }
}
