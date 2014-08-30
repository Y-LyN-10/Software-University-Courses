<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");

if (isset($_POST["categories"]) && isset($_POST["tags"]) && isset($_POST["months"])) {
	if (!empty($_POST["categories"]) && !empty($_POST["tags"]) && !empty($_POST["months"])) {
		echo generateSidebar("Categories", $_POST["categories"]);
		echo generateSidebar("Tags", $_POST["tags"]);
		echo generateSidebar("Months", $_POST["months"]);
	} else {
		echo "<div>Not all fields have been filled in.</div>";
	}
}

function generateSidebar($title, $values)
{
	$valuesSplit = preg_split('/[,\s+]+/', $values, 0, PREG_SPLIT_NO_EMPTY);
	$sidebar = "<aside><header><h2>".$title."</h2></header><ul>";

	foreach ($valuesSplit as $item) {
		$sidebar .= "<li><a href=\"#\">".$item."</a></li>";
	}

	$sidebar .= "</ul></aside>";
	return $sidebar;
}
?>
