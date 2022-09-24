function solve(data){

    let result = {};

    for(let el of data){
        
        let [town, product, price] = el.split(" | ");
        price = Number(price);

        if(result.hasOwnProperty(product)){
            

        
        } else if(!result[product].hasOwnProperty(town)){
            result[product][town] = price;
        } else if(result[product][town] > price){
            result[product][town] = price;
        }

    }

    for(let [town, value] of Object.entries(result)){
        for(let [product, price] of Object.entries(value)){
            console.log(`${product} -> ${price} ${(town)}`);    
        }
    }

}
solve(
['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);