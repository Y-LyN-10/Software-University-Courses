// Problem 5. Angle Unit Converter (Degrees ↔ Radians)

// Write a method to convert from degrees to radians. Write a method to convert 
// from radians to degrees. You are given a number n and n queries for conversion. 
// Each conversion query will consist of a number + space + measure. Measures are 
// "deg" and "rad". Convert all radians to degrees and all degrees to radians. Print 
// the results as n lines, each holding a number + space + measure. Format all numbers 
// with 6 digit after the decimal point. Examples:

import java.util.Scanner;

public class _5_Angle_Converter {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)) {

			int rows = input.nextInt();

			double[] number = new double[rows];
			String[] type = new String[rows];

			for (int i = 0; i < rows; i++) {
				number[i] = input.nextDouble();
				type[i] = input.next();
			}

			for (int i = 0; i < rows; i++) {
				convert(number[i], type[i]);
			}
		}
	}

	public static void convert(double number, String type) {

		double result = 0;

		if (type.equals("deg")) {
			result = Math.toRadians(number);
			System.out.printf("%.6f rad \n", result);
		} else if (type.equals("rad")) {
			result = Math.toDegrees(number);
			System.out.printf("%.6f deg \n", result);
		}
	}
}
