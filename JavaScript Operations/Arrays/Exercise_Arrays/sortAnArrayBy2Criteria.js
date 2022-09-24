function solve(array){

    let sortedArray = array.sort().sort((a,b) => a.length - b.length);
    
    sortedArray.forEach(element => {
        console.log(element);
    });

}
solve(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']
)