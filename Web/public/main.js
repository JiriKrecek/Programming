console.log("hello");

var cookies = document.cookie.split(";");

for (var i = 0; i < cookies.length; i++) {
    var cookie = cookies[i];
    console.log(cookie);
}
console.log("Ahoj");