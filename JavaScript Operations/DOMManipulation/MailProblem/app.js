function solve() {

    document.getElementById("add").addEventListener("click", AddEmail);
    document.getElementById("reset").addEventListener("click", ResetEmail);

    let recipient = document.getElementById("recipientName");
    let title = document.getElementById("title");
    let message = document.getElementById("message");
    let listMailsArea = document.getElementById("list")
    let sentMailsArea = document.querySelector(".sent-list");
    let deletedMailsArea = document.querySelector(".delete-list");

    function AddEmail(e){

        e.preventDefault();
        let recipientValue = recipient.value;
        let titleValue = title.value;
        let messageValue = message.value;

        if (!recipientValue || !titleValue || !messageValue) {
            return;
        }

        CreateEmail(recipientValue, titleValue, messageValue);
        recipient.value = "";
        title.value = "";
        message.value = "";
    }
    
    function CreateEmail(recipientValue, titleValue, messageValue){

        let li = document.createElement("li");

        let hTitle = document.createElement("h4");
        hTitle.textContent = `Title: ${titleValue}`;

        let hRecipient = document.createElement("h4");
        hRecipient.textContent = `Recipient Name: ${recipientValue}`;

        let spanMessage = document.createElement("span");
        spanMessage.textContent = `${messageValue}`;

        let divButtons = document.createElement("div");
            divButtons.id = "list-action";
                let sendButton = document.createElement("button");
                sendButton.textContent = "Send";
                sendButton.addEventListener("click", SendEmail);
                sendButton.id = "send";
                sendButton.type = "submit";
                
                let deleteButton = document.createElement("button");
                deleteButton.textContent = "Delete";
                deleteButton.addEventListener("click", DeleteMail);
                deleteButton.id = "delete";
                deleteButton.type = "submit";
        divButtons.appendChild(sendButton);
        divButtons.appendChild(deleteButton);

        li.appendChild(hTitle);
        li.appendChild(hRecipient);
        li.appendChild(spanMessage);
        li.appendChild(divButtons);

        listMailsArea.appendChild(li);
    };

    function SendEmail(e){

        let elements = e.target.parentElement.parentElement.querySelectorAll("h4")
        let li = document.createElement("li");

        let spanRecepient = document.createElement("span");
        spanRecepient.textContent = `To: ${elements[1].textContent.split(": ")[1]}`;

        let spanTitle = document.createElement("span");
        spanTitle.textContent = `Title: ${elements[0].textContent.split(": ")[1]}`;

        let divButton = document.createElement("div");
        let deleteButton = document.createElement("button");
        divButton.classList.add("btn");
        deleteButton.type = "submit";
        deleteButton.classList.add("delete");
        deleteButton.textContent = "Delete";
        deleteButton.addEventListener("click", DeleteMail);
        divButton.appendChild(deleteButton);


        li.appendChild(spanRecepient);
        li.appendChild(spanTitle);
        li.appendChild(divButton);
        sentMailsArea.appendChild(li);
        e.target.parentElement.parentElement.remove();
    }   

    function ResetEmail(e){
        e.preventDefault();
        recipient.value = "";
        title.value = "";
        message.value = "";    
    }

    function DeleteMail(e){

        let li = document.createElement("li");

        let spanRecepient = document.createElement("span");
        let spanTitle = document.createElement("span");
        if (e.target.parentElement = document.getElementById("list-action")) {
            
            let elements = e.target.parentElement.parentElement.querySelectorAll("h4");
            spanRecepient.textContent = `To: ${elements[1].textContent.split(": ")[1]} `;
            spanTitle.textContent = `Title: ${elements[0].textContent.split(": ")[1]}`;
            e.target.parentElement.parentElement.remove();
        }
        else{

            let elements = e.target.parentElement.parentElement.querySelectorAll("span")
            spanRecepient.textContent = `${elements[0].textContent} `;
            spanTitle.textContent = elements[1].textContent;
            e.target.parentElement.parentElement.remove();
            //debugger;
        }
        li.appendChild(spanRecepient);
        li.appendChild(spanTitle);

        deletedMailsArea.appendChild(li);
        //e.target.parentElement.parentElement;  => sent Mails (li);
    }

}
solve()