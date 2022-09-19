function solve(matrix){

    let maxNum = Number.MIN_SAFE_INTEGER;
    
    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix[row].length; col++){

            let currentNum = matrix[row][col];
            if(currentNum >= maxNum){
                maxNum = currentNum;
            }
        }
    }
    console.log(maxNum);
}
solve([[20, 50, 10],
    [8, 33, 145]])
    