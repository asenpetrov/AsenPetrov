class CarDealership{

    constructor(name){
        this.name = name;
        this.availableCars = [];
        this.soldCars = [];
        this.totalIncome = 0;
    }

    addCar(model, horsepower, price, mileage){

        horsepower = Number(horsepower);
        price = Number(price);
        mileage = Number(mileage);

        if (model === "" || model === null || horsepower < 0 || price < 0 || mileage < 0) {
            
            throw new Error("Invalid input!");
        }
        else{
            
            console.log(model);
            this.availableCars.push({
                model: model,
                horsepower: horsepower,
                price: price,
                mileage: mileage
            });
            return `New car added: ${model} - ${horsepower} HP - ${mileage.toFixed(2)} km - ${price.toFixed(2)}$`;
        }

    }

    sellCar (model, desiredMileage){
        let desiredModel = this.availableCars.find(c => c.model === model);
        if(!desiredModel) {
            
            return `${model} was not found!`;
        }
        else{

            let currentMileage = desiredModel.mileage;
            let initialPrice = desiredModel.price;
            let mileageDifference = currentMileage - desiredMileage;

            if(currentMileage <= desiredMileage){
                this.availableCars = this.availableCars.filter((x) => x.model !== model);
                this.totalIncome += initialPrice;
                this.soldCars.push({
                    model: desiredModel.model,
                    horsepower: desiredModel.horsepower,
                    soldPrice: initialPrice
                });
                return `${model} was sold for ${initialPrice.toFixed(2)}$`;
            }
            else if (mileageDifference <= 40000) {
                let manipulatedPrice = initialPrice *0.95;
                this.totalIncome += manipulatedPrice;
                this.availableCars.pop(desiredModel);
                this.soldCars.push({
                    model: desiredModel.model,
                    horsepower: desiredModel.horsepower,
                    soldPrice: manipulatedPrice
                });
                return `${model} was sold for ${manipulatedPrice.toFixed(2)}$`;
            }
            else if(mileageDifference > 40000){
                let manipulatedPrice = initialPrice *0.90;
                this.totalIncome += manipulatedPrice;
                this.availableCars.pop(desiredModel);
                this.soldCars.push({
                    model: desiredModel.model,
                    horsepower: desiredModel.horsepower,
                    soldPrice: manipulatedPrice
                });
                return `${model} was sold for ${manipulatedPrice.toFixed(2)}$`;
            }
        }
    }

    currentCar(){
        let result = "-Available cars:";
        this.availableCars.forEach(car => result += `\n---${car.model} - ${car.horsepower} HP - ${car.mileage.toFixed(2)} km - ${car.price.toFixed(2)}$`)
        return result;
    }
    salesReport (criteria){
        
        if(criteria === "horsepower"){
            let sortedCars = this.soldCars.sort((a, b) => b.horsepower - a.horsepower);
            let result = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$\n`;
            result += `-${this.soldCars.length} cars sold:`
            sortedCars.forEach(c => result += `\n---${c.model} - ${c.horsepower} HP - ${c.soldPrice.toFixed(2)}$`);
            return result;
        }
        else if(criteria === "model"){

            let sortedCars = this.soldCars.sort((a, b) => {
                if(a.model < b.model) return -1;
                if(a.model > b.model) return 1;
                return 0;

            });
            let result = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$\n`;
            result += `-${this.soldCars.length} cars sold:\n`
            sortedCars.forEach(c => result += `---${c.model} - ${c.horsepower} HP - ${c.soldPrice}$\n`);
            return result;
        }
        else{
            throw new Error("Invalid criteria!");
        }
    }
}
let dealership = new CarDealership('SoftAuto');
dealership.addCar('Toyota Corolla', 100, 3500, 190000);
dealership.addCar('Mercedes C63', 300, 29000, 187000);
dealership.addCar('kur', 120, 4900, 240000);
console.log(dealership.availableCars)
console.log(dealership.currentCar());
dealership.sellCar('Toyota Corolla', 230000);
dealership.sellCar('kur', 250000);
dealership.sellCar('Mercedes C63', 110000);
console.log(dealership.salesReport('model'));






