function deleteByEmail() {

  let emailToCheck = document.getElementsByName("email")[0].value;

  let emailList = Array.from(document.querySelectorAll("td")).filter((x, i) => i % 2 !== 0);
  let result = document.getElementById("result");

  console.log(emailList);

  for (let i = 0; i < emailList.length; i++) {
    if (emailList[i].textContent === emailToCheck) {
      emailList[i].parentElement.remove();
      result.textContent = "Deleted.";
      break;
    } else {
      result.textContent = "Not found.";
    }
  }
}
