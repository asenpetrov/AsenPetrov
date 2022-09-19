// •	On the motorway, the limit is 130 km/h
// •	On the interstate, the limit is 90 km/h
// •	In the city, the limit is 50 km/h 
// •	Within a residential area, the limit is 20 km/h

function solve(speed, area){
    const motorway = 130;
    const interstate = 90;
    const city = 50;
    const residence = 20;

    if (area == 'motorway') {
        if (speed <= 130) {
            console.log(`Driving ${speed} km/h in a 130 zone`)
        }
        else{
            let difference = speed - motorway;
            if (difference <= 20 ) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorway} - speeding`)  
            }
            else if (difference > 20 && difference <= 40) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorway} - excessive speeding`)
            } else {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorway} - reckless driving`)
            }
                  
        }
    }
    else if (area == 'interstate') {
        if (speed <= 90) {
            console.log(`Driving ${speed} km/h in a 90 zone`)
        }
        else{
            let difference = speed-interstate
            if (difference <= 20 ) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstate} - speeding`)  
            }
            else if (difference > 20 && difference <= 40) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstate} - excessive speeding`)
            } else {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstate} - reckless driving`)
            }   
        }
    }
    else if (area == 'city') {
        if (speed <= 50) {
            console.log(`Driving ${speed} km/h in a 50 zone`)
        }
        else{
            let difference = speed-city;
            if (difference <= 20 ) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${city} - speeding`)  
            }
            else if (difference > 20 && difference <= 40) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${city} - excessive speeding`)
            } else {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${city} - reckless driving`)
            } 
        }
    }
    else if (area == 'residential') {
        if (speed <= 20) {
            console.log(`Driving ${speed} km/h in a 20 zone`) 
        }
        else{
            let difference = speed-residence
            if (difference <= 20 ) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residence} - speeding`)  
            }
            else if (difference > 20 && difference <= 40) {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residence} - excessive speeding`)
            } else {
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residence} - reckless driving`)
            } 
        }
    }
}