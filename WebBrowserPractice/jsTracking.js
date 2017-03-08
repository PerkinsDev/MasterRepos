// this code loops through a page to find the script tags with a src prop. can use dot notation if common prop. use name (["src"]) to access 


//var arr = document.getElementsByTagName("script");
//for(var i=0; i < arr.length; i++) {
//    if (arr[i].src) {
//    console.log(arr[i].src);
//    }
//}


// turn into a function - make generic to pass in any type of tag. use name (["src"]) to access
function list(tagName, propName) {
    var arr = document.getElementsByTagName(tagName);
    for(var i=0; i < arr.length; i++) {
        if (arr[i][propName]) {
            console.log(arr[i][propName]);
        }
    }
}

// An example Call to the function
list("script", "src");
list("img", "src");
list("audio", "src");
list("video", "src");
list("a", "href");
