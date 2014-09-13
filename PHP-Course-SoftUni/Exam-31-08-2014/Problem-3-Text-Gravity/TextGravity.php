<?php

$text = htmlspecialchars($_GET['text']); //"The Milky Way is the galaxy that contains our star system";
$line_length = intval($_GET['lineLength']);

$chars_on_line = [];
$matrix = [];

$rows = str_split($text, $line_length);
$result = "<table><tr>";
for ($i=count($rows)-1; $i >= 0; $i--) {
	$current_row = $rows[$i];
	$current_row = str_replace(' ', ".", $current_row);
	if (strlen($current_row) < $line_length) {
		$current_row  .= str_repeat('.', $line_length - strlen($current_row));
	}
	for ($j=0; $j < $line_length; $j++) {
		$ch = $current_row[$j];
		if ($ch == ".") {
			$ch = $rows[$i-1][$j];
			for ($k=0; $k < $line_length; $k++) {
				$rows[$i - $k][$j] = $rows[$i-$k - 1][$j];
			}
		}
		$chars_on_line[] = $ch;
	}
	$matrix[] = $chars_on_line;
	$chars_on_line = '';
}

for ($n=count($matrix)-1; $n >= 0; $n--) {
	for ($m=0; $m < $line_length; $m++) {
		$char = $matrix[$n][$m];
		if (empty(trim($char))) {
			$char = " ";
		}
		$result .= "<td>".$char."</td>";
	}
	if ($n == 0) {
		$result .= "</tr>";
	} else {
		$result .= "</tr><tr>";
	}
}

$result .= "<table>";
echo $result;

// Result: 75/100 points.
// Possible reason - rows with only white spaces should be displayed too.

?>