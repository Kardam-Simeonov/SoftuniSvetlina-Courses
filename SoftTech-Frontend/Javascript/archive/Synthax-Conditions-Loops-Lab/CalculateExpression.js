function calculate(){
    console.log((30 + 25) + ((35 - 14) * 2));
}


let a = 1;
let b = 2;

function sumOfTwo(a, b) {
    return a + b;
}

function sumMany(arr){
    let currentSum = 0;

    for(i = 0; i < arr.length; i++)
        currentSum += arr[i];

    return currentSum;
}

function getEven(arr){
    evenArr = [];
    for(i = 0; i < arr.length; i+= 2){
        if (arr[i] % 2 == 0)
            evenArr.push(arr[i]);
    }
    return evenArr;
}

arr = [0,1,2,3,4,5,6,7,8,9];

console.log(getEven(arr));