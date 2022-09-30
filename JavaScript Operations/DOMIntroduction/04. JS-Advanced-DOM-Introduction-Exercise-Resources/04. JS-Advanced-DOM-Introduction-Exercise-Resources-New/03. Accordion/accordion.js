function toggle() {
    
    let moreButton = document.querySelector(".button");
    let displayStyle = document.getElementById("extra");

    let isNotShown = displayStyle.style.display === "none";

    if (isNotShown) {
        moreButton.textContent = "Less"
        displayStyle.style.display = "block"
    }
    else{
        moreButton.textContent = "More"
        displayStyle.style.display = "none" 
    }


}