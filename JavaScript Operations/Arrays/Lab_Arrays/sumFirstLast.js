function sumFirstLast(array) {

    //let firstNum = Number(array[0]);
    //let lastNum = Number(array[array.length - 1]);

    let firstNum = Number(array.shift());
    let lastNum = Number(array.pop());
    
    let sum = firstNum + lastNum;
    return sum;
}
sumFirstLast(['20', '30', '40']);