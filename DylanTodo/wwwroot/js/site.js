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
let darklight = document.getElementById("theme-switcher");
let menuTheme = document.getElementById("menu-theme");
let menuThemeIcon = document.getElementById("menu-theme-icon");

darklight.addEventListener("mouseenter", function( event ) {   
    if (hello === "dark") {
        document.getElementById("menu-theme").innerHTML = "Light";
        document.getElementById("menu-theme-icon").innerHTML = "🌕";
        event.target.style.backgroundColor = '#eceff4';
        event.target.style.color = '#4c566a';
    }
    else {
        document.getElementById("menu-theme").innerHTML = "Dark";
        document.getElementById("menu-theme-icon").innerHTML = "🌑";
        event.target.style.backgroundColor = '#2e3440';
        event.target.style.color = '#eceff4';
    }
  }, false);
  darklight.addEventListener("mouseleave", function( event ) {   
    if (hello === "dark") {
        document.getElementById("menu-theme").innerHTML = "Dark";
        document.getElementById("menu-theme-icon").innerHTML = "🌑";
    }
    else {
        document.getElementById("menu-theme").innerHTML = "Light";
        document.getElementById("menu-theme-icon").innerHTML = "🌕";
    }
    event.target.removeAttribute("style");
  }, false);
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