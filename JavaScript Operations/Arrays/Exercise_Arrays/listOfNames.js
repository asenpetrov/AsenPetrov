function sort(input){

    let result = input.sort((a, b)=>{
        if(a.toLowerCase() > b.toLowerCase()){
          return 1;
        }else{
          return -1;
        }
      });
    for (let i = 0; i < result.length; i++){
        console.log(`${i+1}.${result[i]}`)
    }
}
sort(["Pgf", "Zh", "fA", "K", "Z", "Aa"])