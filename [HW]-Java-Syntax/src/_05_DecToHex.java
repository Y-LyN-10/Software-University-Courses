import java.util.Scanner;

public class _05_DecToHex {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)) {	
		
			int decimal = input.nextInt();
			System.out.printf("%X", decimal);
		}
	}
}
