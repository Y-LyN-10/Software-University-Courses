<!--Problem 2. Most Frequent Tag
	Write a PHP script MostFrequentTag.php which generates an HTML input 
	text field and a submit button. In the text field the user must enter 
	different tags, separated by a comma and a space (", "). When the 
	information is submitted, the script should generate a list of the tags, 
	sorted by frequency. Then you must print: "Most Frequent Tag is: 
	[most frequent tag]". Semantic HTML is required. Styling is not required -->

<!DOCTYPE html>
<html>
<head>
    <title>Most Frequent Tag</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
<?php
if ($_POST && isset($_POST["submit"])) {
    $tags_string = $_POST["tags"];
    $tags = preg_split('/[ ,]+/', $tags_string);
    $tags_count = array_count_values($tags);

    arsort($tags_count);
    echo "<div id=\"result\">";
    foreach ($tags_count as $key => $value) {
        echo $key . " : " . $value . " time" . ($value == 1 ? "" : "s") . "<br />";
    }

    echo "Most frequent tag is: " . array_keys($tags_count)[0] . "</div>";
}
?>
</form>
</body>
</html>
