<?php

$text = $_GET['text'];
$blacklist = $_GET['blacklist'];
$blacklist_items = preg_split('/\s+/', $blacklist, -1, PREG_SPLIT_NO_EMPTY);
// explode("\n", $blacklist); works too

$email_pattern = '/\b[A-Za-z0-9\-\_\+]+@[A-Za-z0-9\-]+\.[A-Za-z0-9\-\.]+\b/';

$new_text = preg_replace_callback($email_pattern, 'getReplacement', $text);

function getReplacement($match){
	$email = $match[0];
	if(shouldBlackList($email)){
		return str_repeat('*', strlen($match[0]));
	} else {
		return "<a href=\"mailto:$email\">$email</a>";
	}
}

function shouldBlackList($email){
	global $blacklist_items;
	$isBlackListed = false;
	foreach ($blacklist_items as $item) {
		//if(strlen($item) > 0 && $item[0] == '*')
		//if(substr($item, 0, 1) == '*'){
		if(startsWith($item, '*')){
			$blacklisted_domain = substr($item, 1);
			if(endsWith($email, $blacklisted_domain)){
				$isBlackListed = true;
			}
		} else {
			if($email === $item){
				$isBlackListed = true;
			}
		}
	}
	return $isBlackListed;
}

function startsWith($location, $target) {
    return $target === "" || strpos($location, $target) === 0;
}
function endsWith($location, $target) {
    return $target === "" || substr($location, -strlen($target)) === $target;
}

echo "<p>$new_text</p>";

?>