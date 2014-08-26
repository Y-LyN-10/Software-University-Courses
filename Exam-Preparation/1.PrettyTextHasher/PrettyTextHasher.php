<?php

$text = $_GET["text"];
$hash_value = $_GET["hashValue"];
$font_size = $_GET["fontSize"];
$font_style = $_GET["fontStyle"];

$css_style = "font-size:$font_size;";
if($font_style == 'bold'){
	$css_style .= "font-weight:bold;";
}
if($font_style == 'italic' || $font_style == 'normal'){
	$css_style .= "font-style:$font_style;";
}

$encrypted_text = encryptText($text, $hash_value); //htmlspecialchars

function encryptText($text, $hash_value){
	$result = '';
	for ($i=0; $i < strlen($text) ; $i++) {
		$ch = $text[$i];
		if($i % 2 == 0){
			$newCh = chr(ord($ch) + $hash_value); //$hash_value;
		} else {
			$newCh = chr(ord($ch) - $hash_value);
		}
		$result .= $newCh;
	}
	return $result;
}

echo "<p style=\"$css_style\">$encrypted_text</p>";

?>