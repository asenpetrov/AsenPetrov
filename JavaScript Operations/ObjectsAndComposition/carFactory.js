function solve(input){

    let result = {};
    result.model = input.model;

    let currentPower = Number(input.power);
    if (currentPower <= 90) {
        
        result.engine = {
            power: 90,
            volume: 1800
        };

    }
    else if (currentPower <= 120) {
        result.engine = {
            power: 120,
            volume: 2400
        };
    }
    else if (currentPower <= 200) {
        result.engine = {
            power: 200,
            volume: 3500
        };
    }

    if (input.carriage === "hatchback") {
            result.carriage = {
                type: "hatchback",
                color: input.color
        };
    }
    else{
        result.carriage = {
            type: "coupe",
            color: input.color
        };
    }

    let size;
    if(input.wheelsize % 2 !== 0){
        size = input.wheelsize;
    }
    else{
        size = input.wheelsize - 1;
    }

    result.wheels = [size, size, size, size]

    return result;
}
solve({
    model: "VW Golf II",
    power: 90,
    color: "blue",
    carriage: "hatchback",
    wheelsize: 14
  });