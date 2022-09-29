function basicCalculator(numOne, operator, numTwo){
    switch(operator){
        case '+':
            console.log(numOne + numTwo);
            break;
        case '-':
            console.log(numOne - numTwo);
            break;
        case '*':
            console.log(numOne * numTwo);
            break;
        case '/':
            if (numTwo == 0){
                console.log("Can't divide by 0!");
                break;
            }
            console.log(numOne / numTwo);
            break;
    }
}