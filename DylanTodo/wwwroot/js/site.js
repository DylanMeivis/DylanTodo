// Dark Mode JS Code below 
// -----------------------

var hello = "light";
const currentTheme2 = localStorage.getItem("theme");

if (currentTheme2) {
  document.documentElement.setAttribute("data-theme", currentTheme2);

  if (currentTheme2 === "dark") {
    document.getElementById("menu-theme").innerHTML = "Dark";
    document.getElementById("menu-theme-icon").innerHTML = "🌑";
    hello = "dark";
  } else {
    document.getElementById("menu-theme").innerHTML = "Light";
    document.getElementById("menu-theme-icon").innerHTML = "🌕";
    hello = "light";
  }
}

document.getElementById("theme-switcher").addEventListener("click", function() {
    if ( hello === "dark") {
        document.documentElement.setAttribute("data-theme", "light");
        document.getElementById("menu-theme").innerHTML = "Light";
        document.getElementById("menu-theme-icon").innerHTML = "🌕";
        localStorage.setItem("theme", "light");
        hello = "light";
    }
    else {
        document.documentElement.setAttribute("data-theme", "dark");
        document.getElementById("menu-theme").innerHTML = "Dark";
        document.getElementById("menu-theme-icon").innerHTML = "🌑";
        localStorage.setItem("theme", "dark");
        hello = "dark";
    }
});
// --------------------

// Hamburger JS Code below 
// -----------------------

  // Look for .hamburger
  var hamburger = document.querySelector(".hamburger");
  // On click
  hamburger.addEventListener("click", function() {
    // Toggle class "is-active"
    hamburger.classList.toggle("is-active");
    // Do something else, like open/close menu
  });

  // -----------------------