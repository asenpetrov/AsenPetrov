window.addEventListener("load", solve);

function solve() {

    document.getElementById("form-btn").addEventListener("click", PublishStory);

    let firstName = document.getElementById("first-name");
    let lastName = document.getElementById("last-name");
    let age = document.getElementById("age");
    let genre = document.getElementById("genre");
    let title = document.getElementById("story-title");
    let text = document.getElementById("story");
    let publishButton = document.getElementById("form-btn");
    let mainDiv = document.getElementById("main");

    let previewArea = document.getElementById("preview-list");

    function PublishStory(e){

      let firstNameValue = firstName.value;
      let lastNameValue = lastName.value;
      let ageValue = age.value;
      let genreValue = genre.value;
      let titleValue = title.value;
      let textValue = text.value;

      if (!firstNameValue || !lastNameValue || !ageValue || !genreValue || !titleValue || !textValue) {
          return;
      }

      CreateStory(firstNameValue, lastNameValue, ageValue, genreValue, titleValue, textValue);
      firstName.value = "";
      lastName.value = "";
      age.value = "";
      genre.value = "";
      title.value = "";
      text.value = "";

      e.target.setAttribute("disabled", true);
    }

    function CreateStory(firstNameValue, lastNameValue, ageValue, genreValue, titleValue, textValue) {

        let li = document.createElement("li");
        li.classList.add("story-info");

          let article = document.createElement("article");

          let h4 = document.createElement("h4");
          h4.textContent = `Name: ${firstNameValue} ${lastNameValue}`;

          let pAge = document.createElement("p");
          pAge.textContent = `Age: ${ageValue}`;

          let pTitle = document.createElement("p");
          pTitle.textContent = `Title: ${titleValue}`;

          let pGenre = document.createElement("p");
          pGenre.textContent = `Genre: ${genreValue}`;

          let pText = document.createElement("p");
          pText.textContent = textValue;

        let saveButton = document.createElement("button");
        saveButton.classList.add("save-btn");
        saveButton.textContent = "Save Story";
        saveButton.addEventListener("click", SaveStory);

        let editButton = document.createElement("button");
        editButton.classList.add("edit-btn");
        editButton.textContent = "Edit Story";
        editButton.addEventListener("click", EditStory);

        let deleteButton = document.createElement("button");
        deleteButton.classList.add("delete-btn");
        deleteButton.textContent = "Delete Story";
        deleteButton.addEventListener("click", DeleteStory);

        article.appendChild(h4);
        article.appendChild(pAge);
        article.appendChild(pTitle);
        article.appendChild(pGenre);
        article.appendChild(pText);

        li.appendChild(article);
        li.appendChild(saveButton);
        li.appendChild(editButton);
        li.appendChild(deleteButton);

    previewArea.appendChild(li);
    }

    function EditStory(e){

      let elements =  e.target.parentElement.children[0].children;
      firstName.value = elements[0].textContent.split(": ")[1].split(" ")[0];
      lastName.value = elements[0].textContent.split(": ")[1].split(" ")[1];
      age.value = Number(elements[1].textContent.split(": ")[1]);
      title.value = elements[2].textContent.split(": ")[1];
      genre.value = elements[3].textContent.split(": ")[1];
      text.value = elements[4].textContent;

      e.target.parentElement.remove();
      publishButton.disabled = false;
      
    }

    function SaveStory(e){
      
      Array.from(mainDiv.children).forEach(child => child.remove());
      let h1 = document.createElement("h1");
      h1.textContent = "Your scary story is saved!";

      mainDiv.appendChild(h1);     
    }

    function DeleteStory(e){

      publishButton.disabled = false;
      e.target.parentElement.remove();
      //debugger;
    }
}
