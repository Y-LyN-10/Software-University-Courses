import java.util.Scanner;

public class _07_CountOfBits {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)) {
			
			int n = input.nextInt();
			int bitsCount = Integer.bitCount(n);
			
			System.out.println(bitsCount);
		}
	}
}
