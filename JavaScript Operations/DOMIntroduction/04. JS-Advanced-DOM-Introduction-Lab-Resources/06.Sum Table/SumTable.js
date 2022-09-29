function sumTable() {

    let table = Array.from(document.querySelectorAll('td'));
    console.log(table);

    let sum = 0;
    let total = document.getElementById('sum');
    for (let i = 1; i < table.length - 2; i+=2) {

       sum += Number(table[i].textContent);

    }

    total.textContent = sum;
}