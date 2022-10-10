function calculateSign(input){
    let numArr = input.map(Number);
    let negativeCount = 0;

    for (let i = 0; i < numArr.length; i++) {
        if (numArr[i] < 0)
            negativeCount++;
    }

    if (negativeCount % 2 == 0)
        console.log("Positive");
    else
        console.log("Negative");
}