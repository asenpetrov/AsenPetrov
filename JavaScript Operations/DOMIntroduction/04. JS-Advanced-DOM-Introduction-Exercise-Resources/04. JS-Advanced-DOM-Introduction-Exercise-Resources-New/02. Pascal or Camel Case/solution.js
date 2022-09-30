function solve() {
  
  let string = document.getElementById("text").value;
  let convention = document.getElementById("naming-convention").value;

  let array = string.split(" ");
  let result = "";
  if (convention === "Camel Case") {
    result += array[0].toLowerCase();
    for (let i = 1; i < array.length; i++) {
      let currentWord = array[i].toLowerCase();
      let wordToAdd = currentWord[0].toUpperCase() + currentWord.substring(1);
      result += wordToAdd;
    }
  }
  else if (convention === "Pascal Case"){
    for (let i = 0; i < array.length; i++) {
      let currentWord = array[i].toLowerCase();
      let wordToAdd = currentWord[0].toUpperCase() + currentWord.substring(1);
      result += wordToAdd;
    }
  }
  else{
    result = "Error!"
  }
  
  document.getElementById("result").textContent = result;
}