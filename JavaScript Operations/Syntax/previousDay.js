function solve(year, month, day){

    let initialDate = new Date(year, month, day-1);
    //initialDate.setDate(initialDate.getDate()-1);
    console.log(`${initialDate.getFullYear()}-${initialDate.getMonth()}-${initialDate.getDate()}`)


}
solve(2016, 9, 30);
