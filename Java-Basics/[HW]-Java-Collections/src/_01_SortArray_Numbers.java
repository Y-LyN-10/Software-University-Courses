// Problem 1. Sort Array of Numbers

// Write a program to enter a number n and n integer numbers and 
// sort and print them. Keep the numbers in array of integers: int[]. 

import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArray_Numbers {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)){
			
			int n = Integer.parseInt(input.nextLine());
			
			int[] numbers = new int[n];
			for (int i = 0; i < numbers.length; i++) {
				numbers[i] = input.nextInt();
			}

			Arrays.sort(numbers);
			for (int number : numbers) {
				System.out.println(number);
			}		
		}
	}
}
