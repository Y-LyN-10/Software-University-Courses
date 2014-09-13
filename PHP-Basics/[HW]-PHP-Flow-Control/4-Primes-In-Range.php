<!--Problem 4. Find Primes in Range
	Write a PHP script PrimesInRange.php that receives two numbers – 
	start and end – from an input field and displays all numbers in 
	that range as a comma-separated list. Prime numbers should be bolded. 
	Styling the page is optional. -->

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Find Primes in Range</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
	<form method="post">
		<label for="start">Start:</label>
		<input type="text" name="start" id="start" required="true"/>
		<label for="end">End:</label>
		<input type="text" name="end" id="end" required="true"/>
		<input type="submit" value="Show Primes"/>
	</form>		
	<div id="result">
		<?php echo print_primes(); ?>
	</div>
</body>
</html>

<?php
// ==================================================================
//
// Solution
//
// ------------------------------------------------------------------

function print_primes(){
	if ($_POST) {
		$start = intval($_POST["start"]);
		$end = intval($_POST["end"]);
		if ($start < $end) {
			$result = array();
			for ($number = $start; $number <= $end; $number++) {
				$result[] = is_prime($number) ? "<strong>$number</strong>" : $number;
			}
			return implode(", ", $result);
		} else {
			return "The start number must be less than the end number";
		}
	}
}

function is_prime($number){
	if ($number <= 1) {
		return false;
	} elseif ($number == 2) {
		return true;
	} else if ($number % 2 == 0) {
		return false;
	} else {
		for ($i = 3; $i <= ceil(sqrt($number)); $i += 2) {
			if ($number % $i == 0) {
				return false;
			}
		}
		return true;
	}
}

?>