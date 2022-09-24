function solve(array){
    let obj = {};

    for (let i = 0; i < array.length; i+=2) {
        let currentFood = array[i];
        let currentCalories = array[i+1];

        obj[currentFood] = Number(currentCalories);
    }
    console.log(obj);

}
solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52'])