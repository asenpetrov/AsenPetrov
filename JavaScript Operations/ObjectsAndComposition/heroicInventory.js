function solve(input){

    let result = [];

    for (const element of input) {
        
        let [name, level, items] = element.split(' / ');
        level = Number(level);
        items = items ? items.split(', ') : [];

        result.push({name, level, items})
    }
    console.log(JSON.stringify(result));
}
solve(['Jake / 1000 / Gauss, HolidayGrenade'])