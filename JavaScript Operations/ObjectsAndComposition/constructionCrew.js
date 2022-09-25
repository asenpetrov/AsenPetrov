function solve(obj) {
  let worker = {
    weight: obj.weight,
    experience: obj.experience,
    levelOfHydrated: obj.levelOfHydrated,
    dizziness: obj.dizziness,
  };

  if (worker.dizziness == true) {
    let waterNeeded = (worker.weight * worker.experience) / 10;
    worker.levelOfHydrated += waterNeeded;
    worker.dizziness = false;
  }

  //console.log(worker);
  return worker;
}
solve({
  weight: 80,
  experience: 1,
  levelOfHydrated: 0,
  dizziness: true,
});
