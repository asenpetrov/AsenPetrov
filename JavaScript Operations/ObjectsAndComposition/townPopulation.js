function solve(input){
    let cities = {};
    for(let i = 0; i < input.length; i++){
        
        let [city, population] = input[i].split(" <-> ");
        population = Number(population);

        if(cities[city] !== undefined){
            cities[city] += population;
        }
        else{
             cities[city] = population;
        }
    }

    for (const key in cities) {
        
        console.log(`${key} : ${cities[key]}`)
    }

}
solve([
'Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
)