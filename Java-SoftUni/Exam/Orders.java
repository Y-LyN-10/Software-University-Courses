import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;

public class Orders {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);

		int n = Integer.parseInt(input.nextLine());

		HashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<String, TreeMap<String, Integer>>();
				
		for (int i = 0; i < n; i++) {

			String line = input.nextLine();
			String[] singleOrder = line.split(" ");
			String name = singleOrder[0];
			int howMany = Integer.parseInt(singleOrder[1]);
			String fruit = singleOrder[2];

			TreeMap<String, Integer> numsAndFruits = orders.get(fruit);

			if (numsAndFruits == null) {
				numsAndFruits = new TreeMap<String, Integer>();
				orders.put(fruit, numsAndFruits);
			}
			numsAndFruits.put(name, howMany);
		}

		Set<String> fruits = orders.keySet();
		
		for (String fruit : fruits) {
			System.out.printf("%s: ", fruit);
			TreeMap<String, Integer> numsAndFruits = orders.get(fruit);
			
			for (Map.Entry<String, Integer> entry : numsAndFruits.entrySet()) {
				String name = entry.getKey();
				int howMany = entry.getValue();
				
				System.out.printf("%s %s", name, howMany);
				if(!(name.equals(numsAndFruits.lastKey()))){
					System.out.printf(", ");					
				}
			}
			System.out.println("");
		}
	}
}

/*
 * 
 * steve 8 apples maria 3 bananas kiro 3 bananas kiro 9 apples maria 2 apples
 * steve 4 apples kiro 1 bananas kiro 1 apples
 */