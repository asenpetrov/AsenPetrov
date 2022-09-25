function solve(input) {
  let result = [];

  for (let i = 1; i < input.length; i++) {
    let [town, latitude, longitude] = input[i].split(" | ");
    town = town.slice(2);
    latitude = Number(latitude).toFixed(2);
    longitude = longitude.slice(0, -2);
    longitude = Number(longitude).toFixed(2);

    let currentTown = [town, latitude, longitude];
    let townJSON = {
      Town: currentTown[0],
      Latitude: Number(currentTown[1]),
      Longitude: Number(currentTown[2]),
    };
    result.push(townJSON);
  }
  console.log(JSON.stringify(result));
}
solve([
  "| Town | Latitude | Longitude |",
  "| Sofia | 42.696552 | 23.32601 |",
  "| Beijing | 39.913818 | 116.363625 |",
]);
