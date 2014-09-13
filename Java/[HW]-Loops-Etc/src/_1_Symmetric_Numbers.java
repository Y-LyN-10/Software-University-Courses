// Problem 1. Symmetric Numbers in Range

// Write a program to generate and print all symmetric numbers in given range [start…end] 
// (0 ≤ start ≤ end ≤ 999). A number is symmetric if its digits are symmetric toward its 
// middle. For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 
// are not symmetric. 	Example: Input: 5 11 | Output: 5 6 7 8 9 11

import java.util.Scanner;

public class _1_Symmetric_Numbers {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)) {

			int start = input.nextInt();
			int end = input.nextInt();
			for (int i = start; i <= end; i++) {
				if (isSymmetric(i)) {
					System.out.print(i + " ");
				}
			}
		}
	}

	private static boolean isSymmetric(int n) {

		char[] charArr = Integer.toString(n).toCharArray();

		boolean isSymmetric = true;

		for (int i = 0, j = 1; i < charArr.length; i++, j++) {
			if (isSymmetric) {
				if (charArr[i] != charArr[charArr.length - j]) {
					isSymmetric = false;
				}
			}
		}
		return isSymmetric;
	}
}
