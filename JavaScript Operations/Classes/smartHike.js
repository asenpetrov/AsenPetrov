class SmartHike{

    constructor(username){
        this.username = username;
        this.goals = {};
        this.listOfHikes = [];
        this.resources = Number(100);
    }

    addGoal(peak, altitude){
        altitude = Number(altitude);

        if(this.goals.hasOwnProperty(peak)){
            return `${peak} has already been added to your goals`
        }else{
            this.goals[peak] = altitude;
            return `You have successfully added a new goal - ${peak}`
        }
    }

    hike (peak, time, difficultyLevel){
        time = Number(time);        
        if(this.goals[peak] === undefined){
           throw new Error(`${peak} is not in your current goals`);
        }

        if(this.resources === 0){
            throw new Error("You don't have enough resources to start the hike")
        }

        if(this.resources - time * 10 < 0){
            return "You don't have enough resources to complete the hike"
        }else{

            this.resources -= time * 10;
            this.listOfHikes.push({
                peak: peak,
                time: time,
                difficultyLevel: difficultyLevel
            })
            return `You hiked ${peak} peak for ${time} hours and you have ${this.resources}% resources left`
        }
    }

    rest (time){
        time = Number(time);
        if(time * 10 + this.resources >= 100){
            this.resources = 100;
            return `Your resources are fully recharged. Time for hiking!`
        }
        else{
            this.resources += time*10;
            return `You have rested for ${time} hours and gained ${time*10}% resources`
        }

    }

    showRecord (criteria){

        if(this.listOfHikes.length === 0){
            return `${this.username} has not done any hiking yet`
        }
       
        if (criteria === "hard") {
            
            let hardHikes = this.listOfHikes.filter(h => h.difficultyLevel === criteria);
            
            if (hardHikes.length === 1) {
                return `${this.username}'s best ${criteria} hike is ${hardHikes[0].peak} peak, for ${hardHikes[0].time} hours`
            }
            else if (hardHikes.length > 1){
                let bestHardHike = hardHikes.sort(a, b => a.time - b.time)[0];
                return `${this.username}'s best ${criteria} hike is ${bestHardHike.peak} peak, for ${bestHardHike.time} hours`
            }
            else if(hardHikes.length === 0){
                return `${this.username} has not done any ${criteria} hiking yet`;
            }
   
        }
        else if (criteria === "easy") {
            
            let easyHikes = this.listOfHikes.filter(h => h.difficultyLevel === criteria);
            
            if (easyHikes.length === 1) {
                return `${this.username}'s best ${criteria} hike is ${easyHikes[0].peak} peak, for ${easyHikes[0].time} hours`
            }
            else if (easyHikes.length > 1){
                let bestEasyHike = hardHikes.sort(a, b => a.time - b.time)[0];
                return `${this.username}'s best ${criteria} hike is ${bestEasyHike.peak} peak, for ${bestEasyHike.time} hours`
            }
            else if(easyHikes.length === 0){
                return `${this.username} has not done any ${criteria} hiking yet`;
            }
   
        }

        else if(criteria === "all"){
            let result = "All hiking records:\n";
            this.listOfHikes.forEach(hike => result += `${this.username} hiked ${hike.peak} for ${hike.time} hours`) 
            return result;
        }
    }
}









