function printBigger(input){
    let a = Number(input[0]);
    let b = Number(input[1]);

    if (a > b)
        console.log(a);
    else
        console.log(b);
}

printBigger([1,2]);