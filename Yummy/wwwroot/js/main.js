function myFunction() {
    var x = document.getElementById("sidebar");
    if (x.className === "sidebar close") {
      x.className = "sidebar opened";
    } else {
      x.className = "sidebar close";
    }
  }