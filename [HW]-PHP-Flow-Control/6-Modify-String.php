<!--Problem 6. Modify String
	Write a PHP script StringModifier.php which receives a string from an
	input form and modifies it according to the selected option (radio button).
	You should support the following operations: palindrome check, reverse string,
	split to extract leters only, hash the string with the default PHP hashing
	algorithm, shuffle the string characters randomly. The result should be displayed
	right under the input field. Styling the page is optional. Think about which of
	the modification can be achieved with already built-in functions in PHP. Where
	necessary, write your own algorithms to modify the given string. Hint: Use the
	crypt() function for the "Hash String" modification.  -->

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Modify String</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
	<form method="post">
		<input type="text" name="string" placeholder="Enter your string"/>

		<input type="radio" name="function" value="check_palindrome" id="check_palindrome" checked/>
		<label for="check_palindrome">Check Palindrome</label>

		<input type="radio" name="function" value="reverse" id="reverse"/>
		<label for="reverse">Reverse String</label>

		<input type="radio" name="function" value="split" id="split"/>
		<label for="split">Split</label>

		<input type="radio" name="function" value="hash" id="hash"/>
		<label for="hash">Hash String</label>

		<input type="radio" name="function" value="shuffle" id="shuffle"/>
		<label for="shuffle">Shuffle String</label>

		<input type="submit" value="Submit"/>
	</form>
	<div id="result">
		<?php echo modify_string(); ?>
	</div>
</body>
</html>

<?php

// ==================================================================
//
// Solution
//
// ------------------------------------------------------------------

function modify_string() {
	$input_string = htmlentities($_POST["string"]);
	$chosen_function = htmlentities($_POST["function"]);
	return $chosen_function($input_string);
}

function check_palindrome($string) {
	$normalizedString = strtolower(preg_replace("/[^A-Za-z0-9]/", "", $string));
	return "$string is " . ($normalizedString == strrev($normalizedString) ? "" : "not ") . "a palindrome!";
}

function reverse($string) { return strrev($string); }

function split($string) {
	$result = array();
	preg_match_all('/[A-Za-z]/', $string, $result);
	return implode(" ", $result[0]);
}

function hash($string) { return crypt($string); }

function shuffle($string) { return str_shuffle($string); }

?>