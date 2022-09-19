function solve(array, step){

    let result = [];

    for(let i = 0; i < array.length; i++){
        if(i<array.length){
            result.push(array[i]);
        }
        else{
            break;
        }  
    }
    return result;
}