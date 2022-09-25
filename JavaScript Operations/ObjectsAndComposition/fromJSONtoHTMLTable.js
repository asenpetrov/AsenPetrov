function solve(json) {
  let parsed = JSON.parse(json);

  let columnNames = Object.keys(parsed[0]);
  let values = parsed.map((obj) => Object.values(obj));

  let result = "<table>\n";
  result += "   <tr>";

  for (let columnName of columnNames) {
    result += `<th>${columnName}</th>`;
  }

  result += "</tr>\n";

  for (let value of values) {
    result += "   <tr>";
    for (let i = 0; i < value.length; i++) {
      result += `<td>${value[i]}</td>`;
    }

    result += "</tr>\n";
  }

  result += "</table>\n";

  console.log(result);
}
solve(
  `[{"Name":"Pesho",
    "Score":4,
    " Grade":8},
   {"Name":"Gosho",
    "Score":5,
    " Grade":8},
   {"Name":"Angel",
    "Score":5.50,
    " Grade":10}]`
);
