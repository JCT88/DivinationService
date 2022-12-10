

window.addEventListener("load", (event) => {


    var getReading = document.getElementById("getReading")
    getReading.addEventListener("click", (event) => {
        var classedItems = document.querySelectorAll(".reveal")
        classedItems.forEach((e) => {
            e.style.visibility = "visible"
        })
    });

})
