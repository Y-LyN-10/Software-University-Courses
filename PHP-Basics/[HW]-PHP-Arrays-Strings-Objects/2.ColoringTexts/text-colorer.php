<?php
$text = htmlentities($_POST["text"]);
if (isset($text)) {
    if (!empty($text)) {
    	if(!isCyrillic($text)){
	        for ($i = 0; $i < mb_strlen($text); $i++) {
	            $character = mb_substr($text, $i, 1);
	            $order = uniord($character);

	            $css_color_order = $order % 2 == 0 ? "#DF0000" : "#6718F8";
				$css_style = "style=\"color:$css_color_order;padding:5px;\"";

	            echo "<span $css_style>$character</span>";
	        }
    	} else {
    		echo "<div>Cyrillic symbols are not allowed.</div>";
    	}
    } else {
        echo "<div>No text provided.</div>";
    }
}

function uniord($c) {
    $h = ord($c{0});
    if ($h <= 0x7F) {
        return $h;
    } else if ($h < 0xC2) {
        return false;
    } else if ($h <= 0xDF) {
        return ($h & 0x1F) << 6 | (ord($c{1}) & 0x3F);
    } else if ($h <= 0xEF) {
        return ($h & 0x0F) << 12 | (ord($c{1}) & 0x3F) << 6
        | (ord($c{2}) & 0x3F);
    } else if ($h <= 0xF4) {
        return ($h & 0x0F) << 18 | (ord($c{1}) & 0x3F) << 12
        | (ord($c{2}) & 0x3F) << 6
        | (ord($c{3}) & 0x3F);
    } else {
        return false;
    }
}

function isCyrillic($text){
    return preg_match('/[А-Яа-я]/u', $text);
}
?>