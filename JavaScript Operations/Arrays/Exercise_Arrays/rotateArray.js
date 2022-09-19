function rotate(array, number){

    for(var i = 0; i < number; i++){
        let elementToRotate = array.pop();
        array.unshift(elementToRotate);
    }
    console.log(array.join(' '));
}
rotate(['1', 
'2', 
'3', 
'4'], 
2
)