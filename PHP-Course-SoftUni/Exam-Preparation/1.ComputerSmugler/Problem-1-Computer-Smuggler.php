<?php

$list = $_GET['list'];
$list = explode(', ', $list);
$list = array_filter($list);

$counted_items = array_count_values($list);
asort($counted_items); // sort keys by values in ascending order

$spent_money = 0;

//count total spent money to buy the parts
foreach ($counted_items as $item => $count) {
	switch ($item) {
		case 'VIA': $spent_money += countSpentMoney($count, 45); break;
		case 'ROM': $spent_money += countSpentMoney($count, 45); break;
		case 'RAM': $spent_money += countSpentMoney($count, 35); break;
		case 'CPU': $spent_money += countSpentMoney($count, 85); break;
		default: break;
	}
}

// Assemble Pravetz 82
if (!array_key_exists('VIA', $counted_items) ||
	!array_key_exists('CPU', $counted_items) ||
	!array_key_exists('RAM', $counted_items) ||
	!array_key_exists('ROM', $counted_items)) {
	$computers_assembled = 0;
} else {
	$computers_assembled = reset($counted_items); // returns the value of the first key in array
}

$gained_money = $computers_assembled * 420;
$parts_left = 0;

foreach ($counted_items as $item => $count) {
	$count -= $computers_assembled;
	$parts_left += $count;

	switch ($item) {
		case 'VIA': $gained_money += $count*(45/2); break;
		case 'ROM': $gained_money += $count*(45/2); break;
		case 'RAM': $gained_money += $count*(35/2); break;
		case 'CPU': $gained_money += $count*(85/2); break;
		default: break;
	}
}

$gained_money -= $spent_money;

$result = "<ul><li>".$computers_assembled." computers assembled</li>";
$result .= "<li>".$parts_left." parts left</li></ul>";

if ($gained_money <= 0) {
	$result .= "<p>Nakov lost ".$gained_money." leva</p>";
} else {
	$result .= "<p>Nakov gained ".$gained_money." leva</p>";
}

echo $result;

function countSpentMoney($count, $price){
	if($count >= 5){
		return ($price/2)*$count;
	} else {
		return $price*$count;
	}
}

?>