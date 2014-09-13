<!--Problem 4. Text Filter
	Write a PHP program TextFilter.php that takes a text from a textfield and
	a string of banned words from a text input field. All words included in the
	ban list should be replaced with asterisks "*", equal to the word’s length.
	The entries in the banlist will be separated by a comma and space ", ". -->

<?php
// Well, I have no time now to write html files and styling.
$ban_list = "Linux, Windows";
$text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel,
		while GNU adds the functionality. Therefore we owe it to them
		by calling the OS GNU/Linux! Sincerely, a Windows client";

$banned_words = preg_split('/[,\s+]+/', $ban_list, 0, PREG_SPLIT_NO_EMPTY);
$new_text = $text;

// Use a whole word as regular expression
foreach ($banned_words as $banned_word) {
	$replacement = str_repeat('*', strlen($banned_word));
	$new_text = preg_replace('/'.$banned_word.'/', $replacement, $new_text);
}

echo $new_text;
?>