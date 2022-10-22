function solve() {
    
    document.getElementById("add-worker").addEventListener("click", HireWorker);

    let firstName = document.getElementById("fname");
    let lastName = document.getElementById("lname");
    let email = document.getElementById("email");
    let birthDate = document.getElementById("birth");
    let position = document.getElementById("position");
    let salary = document.getElementById("salary");
    let hiredArea = document.getElementById("tbody");
    let totalSalary = document.getElementById("sum");
    let totalSalaryJS = 0;

    function HireWorker(e){
        
        e.preventDefault();
        let firstNameValue = firstName.value;
        let lastNameValue = lastName.value;
        let emailValue = email.value;
        let birthDateValue = birthDate.value;
        let positionValue = position.value;
        let salaryValue = salary.value;
        if(!firstNameValue || !lastNameValue || !emailValue || !birthDateValue || !positionValue || !salaryValue){
            return;
        }

        CreateWorkerProfile(firstNameValue, lastNameValue, emailValue, birthDateValue, positionValue, salaryValue);
        firstName.value = "";
        lastName.value = "";
        email.value = "";
        birthDate.value = "";
        position.value = "";
        salary.value = "";
        hiredArea.value = "";
    }

    function CreateWorkerProfile(firstNameValue, lastNameValue, emailValue, birthDateValue, positionValue, salaryValue){

        let tr = document.createElement("tr");

        let tdfirstName = document.createElement("td");
        tdfirstName.textContent = firstNameValue;

        let tdlastName = document.createElement("td");
        tdlastName.textContent = lastNameValue;

        let tdemail = document.createElement("td");
        tdemail.textContent = emailValue;

        let tdBirth = document.createElement("td");
        tdBirth.textContent = birthDateValue;

        let tdPosition = document.createElement("td");
        tdPosition.textContent = positionValue;

        let tdSalary = document.createElement("td");
        tdSalary.textContent = salaryValue;

        let tdButtons = document.createElement("td");
            let fireButton = document.createElement("button");
            fireButton.classList.add("fired");
            fireButton.addEventListener("click", FireWorker);
            fireButton.textContent = "Fired";

            let editButton = document.createElement("button");
            editButton.classList.add("edit");
            editButton.addEventListener("click", EditWorker);
            editButton.textContent = "Edit";
        tdButtons.appendChild(fireButton);
        tdButtons.appendChild(editButton);

        tr.appendChild(tdfirstName);
        tr.appendChild(tdlastName);
        tr.appendChild(tdemail);
        tr.appendChild(tdBirth);
        tr.appendChild(tdPosition);
        tr.appendChild(tdSalary);
        tr.appendChild(tdButtons);

        hiredArea.appendChild(tr);

        totalSalaryJS += Number(salaryValue);
        totalSalary.textContent = totalSalaryJS.toFixed(2);
    };

    function EditWorker(e){

        let workerInfo = e.target.parentElement.parentElement.children;
        firstName.value = workerInfo[0].textContent;
        lastName.value = workerInfo[1].textContent;
        email.value = workerInfo[2].textContent;
        birthDate.value = workerInfo[3].textContent;
        position.value = workerInfo[4].textContent;
        salary.value = workerInfo[5].textContent;

        totalSalaryJS -= Number(workerInfo[5].textContent);
        totalSalary.textContent = totalSalaryJS.toFixed(2);
        e.target.parentElement.parentElement.remove();       
    }

    function FireWorker(e){

        let salaryToRemove = e.target.parentElement.parentElement.children[5].textContent;
        totalSalaryJS -= Number(salaryToRemove);
        totalSalary.textContent = totalSalaryJS.toFixed(2);

        e.target.parentElement.parentElement.remove();
        //debugger;
    }
}
solve()