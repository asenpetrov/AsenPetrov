class Garden {
  constructor(spaceAvailable) {
    this.spaceAvailable = spaceAvailable;
    this.plants = [];
    this.storage = [];
  }
  addPlant(plantName, spaceRequired) {
    spaceRequired = Number(spaceRequired);
    if (this.spaceAvailable < spaceRequired) {
      throw new Error("Not enough space in the garden.");
    } else {
      let currentPlant = {
        name: plantName,
        spaceRequired: spaceRequired,
        ripe: false,
        quantity: 0,
      };
      this.plants.push(currentPlant);
      this.spaceAvailable -= spaceRequired;
      return `The ${plantName} has been successfully planted in the garden.`;
    }
  }

  ripenPlant(plantName, quantity) {
    quantity = Number(quantity);
    let foundPlant = this.plants.find((plant) => plant.name === plantName);
    if (!foundPlant) {

      throw new Error(`There is no ${plantName} in the garden.`);
    }if (foundPlant.ripe === true) {

      throw new Error(`The ${plantName} is already ripe.`);
    }if (quantity <= 0) {

      throw new Error("The quantity cannot be zero or negative.");
    } 
      foundPlant.ripe = true;
      foundPlant.quantity = quantity;
      if (foundPlant.quantity === 1) {
        return `${quantity} ${plantName} has successfully ripened.`;
      } else {
        return `${quantity} ${plantName}s have successfully ripened.`;
      
    }
  }

  harvestPlant(plantName){
    let foundPlant = this.plants.find((plant) => plant.name === plantName);
    if(!foundPlant){
       throw new Error(`There is no ${plantName} in the garden.`); 
    }
    if(foundPlant.ripe = false){
        throw new Error(`The ${plantName} cannot be harvested before it is ripe.`);
    }

    this.storage.push({
        plantName : foundPlant.name, 
        quantity : foundPlant.quantity});
    this.plants.pop(foundPlant);
    this.spaceAvailable +- foundPlant.spaceRequired;
    return `The ${plantName} has been successfully harvested.`;
  }

  generateReport(){

    let result = "";
    result += `The garden has ${this.spaceAvailable} free space left.`;
    result += `\n`;
    let sortedPlants = this.plants.sort(function(a, b){
        a.name.localeCompare(b.name);
    });
    result += sortedPlants.join(', ');
    result += `\n`;
    if (this.storage.length === 0){
        result += "Plants in storage: The storage is empty."; 
    }
    else{
        let storageResult = "";
        this.storage.forEach(plant => storageResult += `${plant.plantName} ${plant.quantity }, `);
        storageResult = storageResult.substring(0, storageResult.length -2);
        result += storageResult;
    }
    return result;
  }
}

const myGarden = new Garden(250)
console.log(myGarden.addPlant('apple', 20));
console.log(myGarden.addPlant('orange', 200));
console.log(myGarden.addPlant('raspberry', 10));
console.log(myGarden.ripenPlant('apple', 10));
console.log(myGarden.ripenPlant('orange', 1));
console.log(myGarden.harvestPlant('orange'));
console.log(myGarden.generateReport());



