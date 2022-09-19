function solve(array){

    let result = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 !== 0){
            result.push(array[i]);
        }
    }
    result.reverse();
    result = result.map(n => n *2)
    return result;

}
solve([10, 15, 20, 25]);