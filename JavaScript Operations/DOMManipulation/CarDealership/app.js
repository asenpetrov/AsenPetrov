window.addEventListener("load", solve);

function solve() {

    document.getElementById("publish").addEventListener("click", PublishOffer);
    
    let make = document.getElementById("make");
    let model = document.getElementById("model");
    let year = document.getElementById("year");
    let fuelType = document.getElementById("fuel");
    let originalCost = document.getElementById("original-cost");
    let sellingPrice = document.getElementById("selling-price");
    let publishedOffersSection = document.getElementById("table-body");
    let soldCarsSection = document.getElementById("cars-list");
    let totalProfit = document.getElementById("profit");
    let totalProfitJS = Number(0);

    function PublishOffer(e){
      e.preventDefault();
      
      let makeValue = make.value;
      let modelValue = model.value;
      let yearValue = year.value;
      let fuelTypeValue = fuelType.value;
      let originalCostValue = originalCost.value;
      let sellingPriceValue = sellingPrice.value;

      if (!makeValue || !modelValue || !yearValue || !fuelTypeValue || (originalCostValue > sellingPriceValue)){
        return;
      }

      createOffer(makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue);
      make.value = "";
      model.value = "";
      year.value = "";
      fuelType.value = "";
      originalCost.value = "";
      sellingPrice.value = "";
    }

    function createOffer(makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue){

      let tr = document.createElement("tr");
      tr.classList.add("row");

      let tdMake = document.createElement("td");
      tdMake.textContent = makeValue;

      let tdModel = document.createElement("td");
      tdModel.textContent = modelValue;

      let tdYear = document.createElement("td");
      tdYear.textContent = yearValue;

      let tdFuel = document.createElement("td");
      tdFuel.textContent = fuelTypeValue;

      let tdCostPrice = document.createElement("td");
      tdCostPrice.textContent = originalCostValue;

      let tdSellingPrice = document.createElement("td");
      tdSellingPrice.textContent = sellingPriceValue;

      let tdButtons = document.createElement("td");
        let editButton = document.createElement("button");
        editButton.classList.add("action-btn", "edit");
        editButton.textContent = "Edit";
        editButton.addEventListener("click", EditOffer);
        let actionButton = document.createElement("button");
        actionButton.classList.add("action-btn", "sell");
        actionButton.addEventListener("click", SellCar)
        actionButton.textContent = "Sell";
      tdButtons.appendChild(editButton);
      tdButtons.appendChild(actionButton);

      tr.appendChild(tdMake);
      tr.appendChild(tdModel);
      tr.appendChild(tdYear);
      tr.appendChild(tdFuel);
      tr.appendChild(tdCostPrice);
      tr.appendChild(tdSellingPrice);
      tr.appendChild(tdButtons);

      publishedOffersSection.appendChild(tr);
    }

    function EditOffer(e){
      e.preventDefault();

      let tdCollection = e.target.parentElement.parentElement.querySelectorAll("td");
      make.value = tdCollection[0].textContent;
      model.value = tdCollection[1].textContent;
      year.value = Number(tdCollection[2].textContent);
      fuelType.value = tdCollection[3].textContent;
      originalCost.value = Number(tdCollection[4].textContent);
      sellingPrice.value = Number(tdCollection[5].textContent);

      e.target.parentElement.parentElement.remove();

    }

    function SellCar(e){

      e.preventDefault();
      let elements = e.target.parentElement.parentElement.children;
      
      

      let li = document.createElement("li");
      li.classList.add("each-list");
      let span1 = document.createElement("span");
      span1.textContent = `${elements[0].textContent} ${elements[1].textContent}`;

      let span2 = document.createElement("span");
      span2.textContent = `${elements[2].textContent}`;

      let productionCost = Number(elements[4].textContent);
      let finalPrice = Number(elements[5].textContent);
      let profitMade = finalPrice - productionCost;
      totalProfitJS += finalPrice - productionCost;
      let span3 = document.createElement("span");
      span3.textContent = `${profitMade}`;
      
      li.appendChild(span1);
      li.appendChild(span2);
      li.appendChild(span3);
      soldCarsSection.appendChild(li);
      
      totalProfit.textContent = totalProfitJS.toFixed(2);
      let currentCar = e.target.parentElement.parentElement;
      currentCar.remove();
    }
}
