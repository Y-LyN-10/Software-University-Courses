<!--Problem 5. Sentence Extractor
	Write a PHP program SentenceExtractor.php that takes a text from a textarea
	and a word from an input field and prints all sentences from the text,
	containing that word. A sentence is any sequence of words ending with ., ! or ?. -->

<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");

$word = "is";
$text = "This is my cat! And this is my dog. We happily live in Paris – the most
		 beautiful city in the world! Isn’t it great? Well it is :)";

$sentences = preg_split('/\s*(?<=[.?!])\s+/', $text, 0, PREG_SPLIT_NO_EMPTY);

foreach ($sentences as $sentence) {
	$sentence = trim($sentence);
	if (preg_match('/(\s+)' . $word . '\1(.*)[.?!]/', $sentence)) {
		echo $sentence . "<br />";
	}
}

?>