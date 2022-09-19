function walk(steps, stepLenght, speed){
    
    let totalTime = 0;

    let totalDistanceMeters = steps * stepLenght;
    let speedMetersinSec = speed/3.6;
    let time = totalDistanceMeters / speedMetersinSec;

    let numOfBreaks = Math.floor(totalDistanceMeters / 500);
    time+=numOfBreaks*60;

    let timeInMinutes = Math.floor(time/60)

    let timeInMin = Math.floor(time/60);
    //let timeInSec = Number(Math.round(time % 60).toFixed(0));
    let timeInSec = Number((time-(timeInMin*60))).toFixed(0);
    let timeInHour = Math.floor(time/3600);

    if (timeInHour   < 10) {timeInHour   = "0"+timeInHour;}
    console.log(`${timeInHour}:${timeInMin}:${timeInSec}`)


    // let hrs = (totalTime / 3600);
    // let mins = ((totalTime % 3600) / 60);
    // let secs = totalTime % 60;

    
}
walk(2564, 0.70, 5.5)

