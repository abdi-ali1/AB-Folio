SetPriceContainerElement();

function CheckColorPriceChange(item) {
    if (item.textContent.charAt(0) == "-") {
        item.style.color = "red";
    } else {
        item.style.color = "green";
    }
}

function SetPriceContainerElement() {
    const priceContainer = document.getElementsByClassName("Price_Change_Container");
    for (let i = 0; i < priceContainer.length; i++) {
        CheckColorPriceChange(priceContainer[i]);
    }
}


