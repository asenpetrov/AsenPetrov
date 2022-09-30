function search() {
   
   let input = document.getElementById("searchText").value;
   let towns = Array.from(document.getElementsByTagName("li")).filter((x)=> x.textContent.match(input));

   document.getElementById("result").textContent = `${towns.length} matches found`; 
   
   for (let town of towns){
      
      town.style.cssText = "font-weight: bold; text-decoration: underline";
   }
   
}
