function solve(inputNum, command1, command2, command3, command4, command5){


    inputNum = manipulate(inputNum, command1);
    inputNum = manipulate(inputNum, command2);
    inputNum = manipulate(inputNum, command3);
    inputNum = manipulate(inputNum, command4);
    inputNum = manipulate(inputNum, command5);

    function manipulate(num, command){
        switch (command) {
            case "chop":
                num /=2;
                console.log(num);
                break;
            case "dice":
                num = Math.sqrt(num)
                console.log(num);
                break;
            case "spice":
                num += 1;
                console.log(num);
                break;
            case "bake":
                num *=3;
                console.log(num);
                break;
            case "fillet":
                num *= 0.80;
                console.log(num);
                break;      
        } 
        return num;
    }
    

}
solve('32', 'chop', 'chop', 'chop', 'chop', 'chop')