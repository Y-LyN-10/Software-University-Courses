#!/usr/bin/bash

# Using imagemagick package, this script resizes all images in current folder to desired size
# By default, script resizes all jpg images to 1024x768 
# example script exec - ./resize-images.sh png 960

pkg_available=false
pkg="imagemagick"
ext=${1:-".jpg"} 
size=${2:-"1024x768"} 

function resize_images {
	work_is_done=false
	echo "Processing..."
	
	for img in *; do
		if [[ $img == *$ext ]]; then
			convert $img -resize $size $img;
			echo "$img is resized successfully"
			work_is_done=true
		fi
	done

	if $work_is_done; then
		echo "Done!"
	else 
		echo "Error - Not found any $ext images in directory"
	fi
}

# I'm arch user, so I'm not sure that the checks for other distros actually work, it's not tested
# Commands source: http://www.cyberciti.biz/faq/find-out-if-package-is-installed-in-linux/
# But I heard that strange things happen in debian versions...
# http://stackoverflow.com/questions/1298066/check-if-a-package-is-installed-and-then-install-it-if-its-not

function find_package {
	# Debian / Ubuntu Linux
	if type "dpkg -l" >/dev/null 2>&1; then
		if ["dpkg -s $pkg"]; then
			pkg_available=true #1
		fi
	fi
	
	# Red Hat Enterprise / Fedora Linux / Suse Linux / Cent OS
	if type "rpm -qa" >/dev/null 2>&1; then
		if ["rpm -qa | grep $pkg"]; then
			pkg_available=true
		fi
	fi
	
	# Arch & Arch-based linux (eg.Manjaro, etc with pacman)
	if type "pacman -h" >/dev/null 2>&1; then
		if "pacman -Qs $pkg"; then
			pkg_available=true
		fi
	fi
	
	# At least - the "command not found" errors are not visible ^^
	if $pkg_available == false; then
		echo "Error - Imagemagick package didn't found."
		exit;
	else
		resize_images
	fi
}

# First, by calling find_package function, we check if the imagemagick package is already installed
find_package
