<?php

date_default_timezone_set("Europe/Sofia");

$fisrt_date = $_GET["dateOne"];
$second_date = $_GET["dateTwo"];
$holidays = $_GET["holidays"];

$holidays = preg_split(('/\s+/'), $holidays, -1, PREG_SPLIT_NO_EMPTY);
// var_dump($holidays);

$holidays_time = [];
foreach ($holidays as $holiday) {
	$holidays_time[] = strtotime($holiday);
}

$current_date = strtotime($fisrt_date);
$last_date = strtotime($second_date);

$work_days = [];
while($current_date <= $last_date) {
	if(isWorkDay($current_date, $holidays_time)){
		$work_days[] = $current_date;
	}
	$current_date = strtotime("+1 day", $current_date);
}

if (count($work_days) > 0) {
	echo "<ol>";
	foreach ($work_days as $work_day) {
		$workday_day = date("d-m-Y", $work_day);
		echo "<li>$workday_day</li>";
	}
	echo "</ol>";
} else {
	echo "<h2>No workdays</h2>";
}

function isWorkDay($current_date, $holidays_time) {
	$day_of_week = date('N', $current_date);
	if(in_array($current_date, $holidays_time) || $day_of_week > 5){
		return false;
	} else {
		return true;
	}
}

?>