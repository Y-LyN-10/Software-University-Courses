<?php

$html = $_GET['list'];
$max_size = intval($_GET['maxSize']);

$lines = preg_split('/$\R?^/m', $html, 0, PREG_SPLIT_NO_EMPTY);
$result = "<ul>";

foreach ($lines as $line) {
	$line = str_replace(array("\n", "\r", "\x0B", "\t", "\0"), "", $line);
	$line = trim($line);

	if (empty($line)) {
		continue;
	}
	if(strlen($line) > ($max_size)) {
		$result.= "<li>".htmlentities(substr(($line),0, $max_size)).'...</li>';
	} else {
		$result.= "<li>".htmlentities($line)."</li>";
	}
}

echo $result."</ul>";

// Result: 100/100 points

?>