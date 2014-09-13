package CardDeck;

import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Font;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.Font.FontFamily;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.PdfWriter;

public class CardDeck {

	public static final String RESULT = "CardDeck.pdf";

	public static final Font NORMAL = new Font(FontFamily.SYMBOL, 6);

	public static void main(String[] args)
			throws DocumentException, IOException {
		new CardDeck().createPdf(RESULT);
	}

	public void createPdf(String filename) throws DocumentException,IOException {

		try (Scanner input = new Scanner(System.in)){
			
			Document document = new Document();
			PdfWriter.getInstance(document, new FileOutputStream(filename));
			document.open();

			PdfPTable table = new PdfPTable(6);
			table.setWidthPercentage(110);
			table.getDefaultCell().setFixedHeight(90);

			BaseFont baseFont = BaseFont.createFont("Arial.ttf", BaseFont.IDENTITY_H, true);
			Font black = new Font(baseFont, 50f, 0, BaseColor.BLACK);
			Font red = new Font(baseFont, 50f, 0, BaseColor.RED);
			
			String[] cardValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
	        String[] cardSuits = { "♥", "♣", "♦", "♠ " }; //2â™¥ 2â™£ 2â™¦ 2â™ 

			for (String value : cardValues)
	        {
	            for (String suit : cardSuits) {
					if(suit == "♥" || suit == "♦"){
						table.addCell(new Paragraph(value + suit + "", red));
					}
					else{
						table.addCell(new Paragraph(value + suit + "", black));
					}
				}   
	        }

			document.add(table);
			document.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}