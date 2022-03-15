function countHoles(arr){
    let holeDictionary = [1, 0, 0, 0, 1, 0, 1, 0, 2, 1];
    for(let i = 0; i < arr.length; i++){
        for(let j = 0; j < ( arr.length - i -1 ); j++){
            if(holeDictionary[arr[j]] > holeDictionary[arr[j+1]]){
                let temp = arr[j]
                arr[j] = arr[j + 1]
                arr[j+1] = temp
            }
        }
    }
    return arr;
}

let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];

console.log(countHoles(arr));