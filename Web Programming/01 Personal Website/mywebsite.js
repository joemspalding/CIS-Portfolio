$("#dropdown-content_resume").hide();
$("#dropdown-content_connect").hide();
$(function(){
    var sidebarHeight = $(window).innerHeight();
    $('#sidebar').css('height',sidebarHeight);
});

$(document).ready(function(){
	$("#dropdown_resume").hover(function(){
		$("#dropdown-content_resume").slideDown();
	}, function(){
		$("#dropdown-content_resume").slideUp();
	});
});

$(document).ready(function(){
	$("#dropdown_connect").hover(function(){
		$("#dropdown-content_connect").slideDown();
	}, function(){
		$("#dropdown-content_connect").slideUp();
	});
});

$(document).ready(function(){
	$(".aboutme").hover(function(){
		$(".aboutme").animate({backgroundColor: "#ff9A53"},'slow');
	}, function(){
		$(".aboutme").animate({backgroundColor: "white"},'slow');
	});
});

function aboutScroll(){
	window.scrollTo(0,200);
};