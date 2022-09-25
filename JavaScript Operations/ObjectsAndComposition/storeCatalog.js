function solve(input) {
  let result = [];
  for (const el of input) {
    let [productName, productPrice] = el.split(" : ");

    result.push({ productName, productPrice });
  }
  result.sort((a, b) => a.productName.localeCompare(b.productName));

  let initialChar = result[0].productName.charAt(0).toUpperCase();
  console.log(initialChar);
  for (let i = 0; i < result.length; i++) {
    let currentChar = result[i].productName.charAt(0).toUpperCase();
    if (currentChar !== initialChar) {
      initialChar = currentChar;
      console.log(initialChar);
    }
    console.log(` ${result[i].productName}: ${result[i].productPrice}`);
  }
}
solve([
  "Appricot : 20.4",
  "Fridge : 1500",
  "TV : 1499",
  "Deodorant : 10",
  "Boiler : 300",
  "Apple : 1.25",
  "Anti-Bug Spray : 15",
  "T-Shirt : 10",
]);
