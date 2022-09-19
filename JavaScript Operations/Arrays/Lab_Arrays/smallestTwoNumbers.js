function solve(array){

    let minNumberOne = Math.min(...array);

    let indexOfMinNumberOne = array.indexOf(minNumberOne);
    array.splice(indexOfMinNumberOne,1);
    
    let minNumberTwo = Math.min(...array);
    console.log(`${minNumberOne} ${minNumberTwo}`)
}
solve([30, 15, 50, 5])