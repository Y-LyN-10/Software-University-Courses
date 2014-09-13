// Problem 9. List of Products

// Create a class Product to hold products, which have name (string) and price 
// (decimal number). Read from a text file named "Input.txt" a list of products. 
// Each product will be in format name + space + price. You should hold the products 
// in objects of class Product. Sort the products by price and write them in format price 
// + space + name in a file named "Output.txt". Ensure you close correctly all used resources.

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class _9_List_Of_Products {

	public static void main(String[] args) throws IOException {

		List<Product> products = new ArrayList<Product>();

		try (BufferedReader fileReader = new BufferedReader(new FileReader(
				"Input_Products.txt"))) {

			String[] currentProduct = new String[2];
			String line = fileReader.readLine();

			while (line != null) {
				currentProduct = line.split(" ");
				products.add(new Product(currentProduct[0], new BigDecimal(
						currentProduct[1])));
				line = fileReader.readLine();
			}

		} catch (IOException e) {
			System.out.println("Cannot read from file.");
			System.out.println(e.getMessage());
		}

		// Need to implemented the Comparable interface in the Product class
		Collections.sort(products);

		for (Product item : products) {
			System.out.println(item.toString());
		}

		System.out.println("Not trying to write to file Output.txt");

		BufferedWriter fileWriter = new BufferedWriter(new FileWriter("Output.txt", false));

			for (Product item : products) {
				fileWriter.write(item.toString());
				fileWriter.newLine();
			}

		System.out.println("File is written in project directory");
	}
}