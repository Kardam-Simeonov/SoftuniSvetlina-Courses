function againstSecond(input){
    let numArr = input.map(Number);
    if(numArr[1] >= numArr[0])
        console.log(numArr[0] * numArr[1]);
    else
        console.log(numArr[0] / numArr[1]);
}