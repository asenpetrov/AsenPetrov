function solve() {
  document.querySelector("#searchBtn").addEventListener("click", onClick);

  function onClick() {
    let input = document.getElementById("searchField").value;
    let data =
      input !== ""
        ? Array.from(document.querySelectorAll("tbody tr td")).filter((x) =>
            x.textContent.match(input)
          ).map(x => x.parentElement.classList.add("select"))
        : [];
  }
}
