function addItem() {
    
    let input = document.getElementById("newItemText").value;
    let list = document.getElementById("items");

    let li = document.createElement("li");
    li.textContent = input;

    let link = document.createElement("a");
    link.textContent = "[Delete]";
    link.href = "#";
    link.addEventListener("click", deleteElement);
    li.appendChild(link);
    
    if (input === "") return;

    list.appendChild(li);
  
  
  
    function deleteElement(event) {
  
      event.target.parentElement.remove();
  
    }
}