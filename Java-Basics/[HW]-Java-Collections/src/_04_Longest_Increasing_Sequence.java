// Problem 4. Longest Increasing Sequence

// Write a program to find all increasing sequences inside an array of 
// integers. The integers are given in a single line, separated by a space. 
// Print the sequences in the order of their appearance in the input array, 
// each at a single line. Separate the sequence elements by a space. Find also 
// the longest increasing sequence and print it at the last line. If several 
// sequences have the same longest length, print the leftmost of them. 

import java.util.ArrayList;
import java.util.Scanner;

public class _04_Longest_Increasing_Sequence {

	public static void main(String[] args) {

		try (Scanner scanner = new Scanner(System.in)) {

			String line = scanner.nextLine();
			String[] numbersStrings = line.split(" ");
			int[] numbers = new int[numbersStrings.length];
			
			for (int i = 0; i < numbers.length; i++) {
				numbers[i] = Integer.parseInt(numbersStrings[i]);
			}
			
			ArrayList<ArrayList<Integer>> sequences = new ArrayList<>();
			ArrayList<Integer> sequence = new ArrayList<>();
			sequence.add(numbers[0]);
			
			for (int i = 1; i < numbers.length; i++) {

				if (numbers[i] > numbers[i - 1]) {
					sequence.add(numbers[i]);
				} else {
					sequences.add(sequence);
					sequence = new ArrayList<>();
					sequence.add(numbers[i]);
				}
			}
			sequences.add(sequence);
			
			for (ArrayList<Integer> seq : sequences) {
				for (Integer integer : seq) {
					System.out.print(integer + " ");
				}
				System.out.println();
			}
			ArrayList<Integer> longest = new ArrayList<>();
			
			for (int i = 1; i < sequences.size(); i++) {
				if (sequences.get(i).size() > sequences.get(i - 1).size()) {
					longest = sequences.get(i);
				}
			}
			System.out.print("Longest: ");
			
			for (Integer integer : longest) {
				System.out.print(integer + " ");
			}
		}
	}

}
