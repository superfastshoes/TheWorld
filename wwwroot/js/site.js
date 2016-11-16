// site.js

// Immediately Invoked Function Expression, nameless function invoked immediately.
 (function () {

/*    var ele = $("#username");
    ele.text("Naruto Uzimaki");

    //FIX THIS!
    var main = $("main");
    main.on("mouseenter", function () {
        main.style.backgroundColor = "#888";
    });

    main.on("mouseleave", function () {
        main.style.backgroundColor = "";
    });

    var menuItems = $("ul.menu li a");
    menuItems.on("click", function () {
        var me = $(this);
        alert(me.text());
    });
*/

     //Wrap set of DOM elements
     var $sidebarAndWrapper = $("#sidebar,#wrapper");

     $("#sidebarToggle").on("click", function () {
         // ToggleClass: Add a class if it doesnt exist or remove it if it does. 
         $sidebarAndWrapper.toggleClass("hide-sidebar");
         if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
             //(this) = the toggle btn.
             $(this).text("Show Sidebar");
         } else {
             $(this).text("Hide Sidebar");
         }
     });

})();




