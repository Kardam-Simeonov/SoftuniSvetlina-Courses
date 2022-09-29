function returnPenultimate(arr){
    let ultimate = Number.MIN_VALUE;
    let penUltimate = Number.MIN_VALUE;

    for (let i = 0; i < arr.length; i++)
        if (arr[i] > ultimate)
            ultimate = arr[i];
        
    for (let i = 0; i < arr.length; i++)
        if (arr[i] > penUltimate && arr[i] < ultimate)
            penUltimate = arr[i];

    console.log(penUltimate);
}