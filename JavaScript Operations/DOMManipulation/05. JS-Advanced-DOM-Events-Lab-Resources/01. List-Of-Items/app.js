function addItem() {
    
    let listLi = document.getElementById('items');

    let customerInput = document.getElementById("newItemText").value;
    let newLi = document.createElement('li');

    newLi.textContent = customerInput;

    listLi.appendChild(newLi);

    document.getElementById("newItemText").value = "";

}