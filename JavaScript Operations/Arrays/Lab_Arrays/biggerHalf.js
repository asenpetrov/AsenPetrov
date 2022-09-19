function solve(array){
    
    array.sort(function(a, b){return a - b});

    return array.slice(array.length / 2);

}
solve([4, 7, 2, 5]);