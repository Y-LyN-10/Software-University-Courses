// Problem 8. Sum Numbers from a Text File
// Write a program to read a text file "Input.txt" holding a sequence of integer 
// numbers, each at a separate line. Print the sum of the numbers at the console. 
// Ensure you close correctly the file in case of exception or in case of normal 
// execution. In case of exception (e.g. the file is missing), print "Error" as a result. 

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
public class _8_Sum_Numbers_From_Text {

	public static void main(String[] args) {

		try (BufferedReader fileReader = new BufferedReader(new FileReader("Input.txt"))) {

			String line = fileReader.readLine();
			int totalSum = 0;

			System.out.print("Numbers:");
			
			while (line != null) {
				System.out.print(" + " + line);
				totalSum += Integer.parseInt(line);
				line = fileReader.readLine();
			}
			System.out.println();
			System.out.println("Total sum: " + totalSum);

		} catch (IOException e) {
			System.out.println("Error!");
		}
	}
}