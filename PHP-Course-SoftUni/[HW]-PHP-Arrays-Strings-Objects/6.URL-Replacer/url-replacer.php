<!--Problem 6. URL Replacer
	Write a PHP program URLReplacer.php that takes a text from a textarea and
	replaces all URLs with the HTML syntax <a href= "…" ></a> with a special
	forum-style syntax [URL=…][/URL]. -->

<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");

$text = "<p>Come and visit <a href=\"http://softuni.bg\">the Software University</a>
		 to master the art of programming. You can always check our
		 <a href=\"www.softuni.bg/forum\">forum</a> if you have any questions.</p>";

$result = preg_replace('/<\s*\/\s*a\s*>/', '[/URL]', $text);
echo htmlentities(preg_replace('/<a(.*?)href=(\'|")([^>]+)(\'|")(.*?)>/', '[URL=\3]', $result));

?>