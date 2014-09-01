<?php

$html = htmlentities($_GET['html']);
$tagname = 'div';

$tag_pattern = '<!--(.*)-->';
preg_match_all($pattern, $html, $matches);

$style_pattern = 'div\s*(.*)(.*)\">';
preg_match_all($pattern, $html, $style_matches);

// var_dump($matches[1]);
$tag = trim(implode($matches[1]));
$style = trim(implode($style_matches[1]));
echo $style;
echo "<$tag $style\"></$tag>";

// no more time - result: 0/100

?>