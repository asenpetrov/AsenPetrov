function extractText() {
    
    let elements = Array.from(document.getElementById('items').children)
    let textArea = document.getElementById('result');

    //let elements2 = document.querySelectorAll('li');

    for(let element of elements){      
        textArea.textContent += element.textContent + "\n"; 
    }
}