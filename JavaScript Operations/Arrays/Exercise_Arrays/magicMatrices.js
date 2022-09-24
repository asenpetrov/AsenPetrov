function solve(array){

    let sumToCheck = 0;
    let flag = true;

    for (let col = 0; col < array.length; col++) {       
        let currentNum = array[0][col];
        sumToCheck += currentNum;       
    }

    for (let row = 1; row < array.length; row++) {
        let currentRowSum = 0;
        for (let col = 0; col < array.length; col++) {
            currentRowSum += array[row][col];
        }
        if (currentRowSum != sumToCheck) {
            flag = false;
            break;
        }
    }

    for (let col = 0; col < array.length; col++) {

        let currentColSum = 0;
        for (let row = 0; row < array.length; row++) {
            currentColSum += array[row][col];
        }
        if (currentColSum != sumToCheck) {
            flag = false;
            break;
        }
    }


    console.log(flag);
}
solve(
    [[1, 0, 0],
 [0, 0, 1],
 [0, 1, 0]]


   )