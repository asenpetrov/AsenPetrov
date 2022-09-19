function solve(type, weight, price){

let weightKG = (weight/1000);
let priceToPay = (weightKG*price);

    console.log(`I need $${priceToPay.toFixed(2)} to buy ${weightKG.toFixed(2)} kilograms ${type}.`)
}

