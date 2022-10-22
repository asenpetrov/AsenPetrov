class SummerCamp{

    constructor(organizer, location) {
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = {
            child: 150,
            student: 300,
            collegian: 500
        }
        this.listOfParticipants = [];
    }

    registerParticipant(name, condition, money){

        money = Number(money);

        if(condition === "child" || condition === "collegian" || condition === "student"){
           
            let participant = this.listOfParticipants.find(p => p.name === name);
            if(participant){

            return `The ${name} is already registered at the camp.`
        }
        else{
            if(money < this.priceForTheCamp[condition]){
                return `The money is not enough to pay the stay at the camp.`;
            }
            else{

                let newParticipant = {
                    name: name,
                    condition: condition,
                    power: 100,
                    wins: 0
                }
                this.listOfParticipants.push(newParticipant);
                return `The ${name} was successfully registered.`;
            }
        }
        }
        else{

            throw new Error("Unsuccessful registration at the camp.");

        }
        
    }

    unregisterParticipant(name){

        let participant = this.listOfParticipants.find(p => p.name === name);
        if (!participant){

            throw new Error(`The ${name} is not registered in the camp.`);
        }
        else{

            this.listOfParticipants = this.listOfParticipants.filter(p => p.name !== name)
            return `The ${name} removed successfully.`;
        }
    }

    timeToPlay (typeOfGame, participant1, participant2){

        let player1 = this.listOfParticipants.find(p => p.name === participant1);
        let player1Condition = player1.condition;

        if(participant2 === undefined){

            if (!player1) {
                throw new Error(`Invalid entered name/s.`);
            }
            if (typeOfGame === "Battleship"){
                player1.power += 20;
                return `The ${player1.name} successfully completed the game ${typeOfGame}.`;
            }
        }
        else{
            let player2 = this.listOfParticipants.find(p => p.name === participant2)
            let player2Condition = player2.condition;
            if (!player2) {
                throw new Error(`Invalid entered name/s.`);
            }
            if (player1Condition !== player2Condition) {
                throw new Error(`Choose players with equal condition.`);
            }
            if (typeOfGame === "WaterBalloonFights"){
                
                if (player1.power > player2.power) {
                    
                    player1.wins++;
                    return `The ${player1.name} is winner in the game ${typeOfGame}.`;
                }
                else if(player1.power < player2.power) {

                    player2.wins++;
                    return `The ${player2.name} is winner in the game ${typeOfGame}.`;
                }
                else{
                    return `There is no winner.`;
                }

            }

        }
    }

    toString(){
        let result = `${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`;
        //`{name} - {condition} - {power} - {wins}`
        let sortedList = this.listOfParticipants.sort((a, b) => b.wins - a.wins);
        sortedList.forEach(participant => result+= `\n${participant.name} - ${participant.condition} - ${participant.power} - ${participant.wins}`);

        return result;
    }
}

const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());



