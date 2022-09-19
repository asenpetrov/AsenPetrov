function solve(n, k){

    let arr = [1];
    arr[0] = Number(1);

    for (let i = 0; i < n-1; i++) {
        
        let currentNum = Number(0);
        for (let j = 0; j < k; j++) {
            if (i-j < 0) {
                continue;
            }
            currentNum += Number(arr[i-j]);           
        }
       
       arr.push(Number(currentNum));     
        
    }
    console.log(arr.join(', '));
    //return arr;
}
solve(6, 3);
solve(8, 2);