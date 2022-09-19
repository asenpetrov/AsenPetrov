function solve(array, pie1, pie2){
    
    let result = [];

    for(let i = 0; i < array.length; i++){
        if(array[i] == pie1){
            result.push(array[i]);

            for(let j = i + 1; j < array.length; j++){
                if(array[j] != pie2){
                    result.push(array[j]);
                }
                else{
                    result.push(array[j]);
                    break;
                }
            }
           
        }
    }
    //return result;
    console.log(result);
}
solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
)