function solve(number){
    let string = number.toString(); // == num + "";
    let flag = true;
    let sum =0;
    for (let i = 0; i < string.length; i++) {
        if (string[0] != string[i]) {
            flag = false;
            
        }
        sum+=Number(string[i]);
    }

    console.log(flag);
    console.log(sum);
}
solve(2222222);
solve(1234);