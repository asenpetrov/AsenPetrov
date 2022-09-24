function createAssemblyLine() {
  let assemblyLine = {
    hasClima(myCar) {
      let climaSettings = {
        temp: 21,
        tempSettings: 21,

        adjustTemp() {
          if (this.temp < this.tempSettings) {
            this.temp++;
          } else if (this.temp > this.tempSettings) {
            this.temp--;
          }
        },
      };
      return Object.assign(myCar, climaSettings);
    },

    hasAudio(myCar) {
      let songToPlay = {
        currentTrack: null,
        nowPlaying() {
          if (this.currentTrack !== null) {
            console.log(`Now playing '${this.currentTrack.name}' by ${this.currentTrack.artist}`);
          }
        }
      };
      return Object.assign(myCar, songToPlay);
    },

    hasParktronic(myCar)
    {
        let distanceToCheck = {

            checkDistance(distance)
            {
                if(distance < 0.1){
                    console.log("Beep! Beep! Beep!");
                }
                else if(distance >= 0.1 && distance < 0.25){
                    console.log("Beep! Beep!");
                }
                else if(distance >= 0.25 && distance < 0.5){
                    console.log("Beep!");
                }
            }
        }
        
        return Object.assign(myCar, distanceToCheck);
    }
    

  };

  return assemblyLine;
}

const assemblyLine = createAssemblyLine();

const myCar = {
  make: "Toyota",
  model: "Avensis",
};

//assemblyLine.hasAudio(myCar);
//console.log(myCar);
assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);


