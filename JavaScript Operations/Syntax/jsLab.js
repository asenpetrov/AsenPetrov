// function solve(str1, str2, str3)
// {
//     let firstArgLength = str1.length;
//     let secondArgLength = str2.length;
//     let thirdArgLength = str3.length;

//     let sumOfLenght = firstArgLength + secondArgLength + thirdArgLength;
//     let averageLenght = Math.floor(sumOfLenght/3);

//     console.log(sumOfLenght);
//     console.log(averageLenght);
// }

//ctrl + k + u

// function solve(a, b, c)
// {
//     if(a>=b && a>=c)
//     {
//         console.log(`The largest number is ${a}.`);
//     }
//     else if(b>=c && b>=a)
//     {
//         console.log(`The largest number is ${b}.`);
//     }
//     else if(c>=a && c>=b)
//     {
//         console.log(`The largest number is ${c}.`);
//     }
// }

// function solve(a)
// {
//     if(typeof a === 'number')
//     {
//         const result = (a*a*Math.PI).toFixed(2);
//         console.log(result);
//     }
//     else{
//         console.log(`We can not calculate the circle area, because we receive a ${typeof(a)}.`)
//     }
// }
// The string may be one of the following: '+', '-', '*', '/', '%', '**'.
// function solve(a, b, operator) {
//     let result;
//   switch (operator) {
//     case "+":
//     result=a+b;
//       break;
//     case "-":
//         result=a-b;
//       break;
//     case "*":
//         result=a*b;
//       break;
//       case "/":
//         result=a/b;
//       break;
//       case "%":
//         result=a%b;
//       break;
//       case "**":
//         result=a**b;
//       break;

//   }
//   console.log(result);
// }
// function solve(a, b){

//     let sum;
//     for(let i = a; i <= b; i++)
//     {
//         sum+=i;
//     }

//     console.log(sum);
// }
// solve('1', '5')

// function solve(input) {
//   let result;
//   if (input == "Monday") {
//     result = 1;
//   } else if (input == "Tuesday") {
//     result = 2;
//   } else if (input == "Wednesday") {
//     result = 3;
//   } else if (input == "Thursday") {
//     result = 4;
//   } else if (input == "Friday") {
//     result = 5;
//   } else if (input == "Saturday") {
//     result = 6;
//   } else if (input == "Sunday") {
//     result = 7;
//   }
//   else{
//     result = 'error';
//   }

//   console.log(result);
// }

// function solve(month, year){
//     //const daysInSeptember = getDays(2021, 7); // Returns 31.

    
//     const numOfDays = (year, month) => { return new Date(year, month, 0). getDate(); };
//     const days = numOfDays(year, month)

//     console.log(days);
// }
// solve(1, 2012);

// function solve(a=5){
 
//     let result = '';
//     for (let i = 0; i < a; i++) {
        
//         result+='* ';
//     }
//     result.trimEnd();
//     for (let i = 0; i < a; i++) {
//         console.log(result);
        
//     }
// }
// solve(4)

function solve(array){

    let sum=0;
    array.forEach(element => {
        sum+=element;
    });

    let inverseSum=0;
    array.forEach(element => {
        inverseSum+=1/element;
    });

    let concatResult = '';

    array.forEach(element => {
        concatResult+=String(element);
    });

    console.log(sum);
    console.log(inverseSum);
    console.log(concatResult);

}
solve([1, 2, 3])