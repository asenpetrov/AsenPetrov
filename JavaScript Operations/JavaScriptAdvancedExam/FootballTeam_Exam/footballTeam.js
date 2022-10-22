class footballTeam{

    constructor(clubName, country){

        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }

    newAdditions(footballPlayers){

        footballPlayers.forEach(player => {
            let [playerName, age, value] = player.split('/');
            age = Number(age);
            value = Number(value);

            let checkedPlayer = this.invitedPlayers.find(player => player.playerName === playerName);
            if(!checkedPlayer){
                this.invitedPlayers.push({
                    playerName: playerName,
                    age: age,
                    value: value
                });
            }
            else{
                if(checkedPlayer.value < value){
                    checkedPlayer.value = value;
                }
            }
        });
        //"You successfully invite {name1}, {name2}, …{nameN}."

        let names = "";
        this.invitedPlayers.forEach(player => names += `${player.playerName}, `);
        let result = `You successfully invite `;
        result+= names;
        result = result.substring(0, result.length - 2);
        result += `.`;

        return result;

    }

    signContract(selectedPlayer){

        let [name, offer] = selectedPlayer.split("/");
        offer = Number(offer);

        let currentPlayer = this.invitedPlayers.find(player => player.playerName === name);
        if(!currentPlayer){
            throw new Error(`${name} is not invited to the selection list!`);
        }
        else{

            if(currentPlayer.value > offer){

                let priceDifference = currentPlayer.value - offer;
                throw new Error(`The manager's offer is not enough to sign a contract with ${name}, ${priceDifference} million more are needed to sign the contract!`)
            }
            else{

                currentPlayer.value = `Bought`;
                return `Congratulations! You sign a contract with ${name} for ${offer} million dollars.`;
            }
        }
    }

    ageLimit(name, age){
        age = Number(age);
        let currentPlayer = this.invitedPlayers.find(player => player.playerName === name)

        if (!currentPlayer) {
            throw new Error(`${name} is not invited to the selection list!`);
        }
        else{

            if (currentPlayer.age >= age) {
                return `${name} is above age limit!`;
            }
            else{
                let difference = Math.abs(age - currentPlayer.age);
            if (difference < 5){

                return `${name} will sign a contract for ${difference} years with ${this.clubName} in ${this.country}!`;
            }
            else if(difference >= 5){
                return `${name} will sign a full 5 years contract for ${this.clubName} in ${this.country}!`;
            }
            }
            
        }
    }

    transferWindowResult(){

        let result = "Players list:"
        //"Player {name}-{playerValue}"
        //this.invitedPlayers.sort(a, b => a.playerName)
        this.invitedPlayers.sort((a, b) => {

            if (a.name > b.name) return 1;
      
            if (b.name > a.name) return -1;
      
      
      
            return 0;
      
          });
        this.invitedPlayers.forEach(player => result+= `\nPlayer ${player.playerName}-${player.value}`);

        return result;
    }
}
let fTeam = new footballTeam("Barcelona", "Spain");
console.log(fTeam.newAdditions(["Kylian Mbappé/23/160", "Lionel Messi/35/50", "Pau Torres/25/52"]));
console.log(fTeam.signContract("Kylian Mbappé/240"));
console.log(fTeam.ageLimit("Kylian Mbappé", 30));
console.log(fTeam.transferWindowResult());



