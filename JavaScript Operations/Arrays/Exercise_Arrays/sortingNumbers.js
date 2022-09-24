function solve(array){

    let result = [];

    array.sort((a, b) => a-b);

    
    while(array.length > 0){

        let currentMin = array.shift();
        let currentMax = array.pop();

        result.push(currentMin);
        result.push(currentMax);
    }

    return result;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);