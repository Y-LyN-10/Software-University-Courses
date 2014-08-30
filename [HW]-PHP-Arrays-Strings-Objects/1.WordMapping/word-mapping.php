<?php
$css_style = "style=\"border:1px solid black;
					  border-collapse:collapse;
					  padding-left:10px;
					  padding-right:10px;
					  background-color:#DBDBDB;\"";

$words = strtolower(htmlentities($_POST["words"]));
if (isset($words)) {
	if (!empty($words)) {
		echo "<table $css_style>";

		$split = preg_split('/\W+/', $words, 0, PREG_SPLIT_NO_EMPTY);
		$counts = array_count_values($split);

		foreach ($counts as $word => $count) {
			echo "<tr $css_style>
					<td $css_style>$word</td>
					<td $css_style>$count</td>
				 </tr>";
		}
		echo "</table>";
	} else {
		echo "<div>No words to count.</div>";
	}
}
?>