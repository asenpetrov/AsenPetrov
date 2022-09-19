function solve(commands){

    let result = [];
    let currentNum = 1;
    commands.forEach(command => {
       if (command == 'add') {
        result.push(currentNum);
        currentNum++;
       }
       else if (command == 'remove') {
        result.pop();
        currentNum++;
       }
    });

    if (result.length > 0) {
        result.forEach(number => {
           console.log(number); 
        });
    }
    else{
        console.log('Empty');

    }
}
solve(['add', 
'add', 
'add', 
'add']
)