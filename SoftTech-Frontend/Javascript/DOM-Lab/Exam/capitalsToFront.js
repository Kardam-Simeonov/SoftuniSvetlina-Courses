function capitalsToFront(word){
    let charArr = word.split("");
    let capital = []; 
    let lower = [];

    for (let i = 0; i < charArr.length; i++)
    {
        if (charArr[i] == charArr[i].toUpperCase())          
            capital.push(charArr[i]);

        else if (charArr[i] == charArr[i].toLowerCase())
            lower.push(charArr[i]);
    }
    console.log(capital.join("").concat(lower.join("")));
}