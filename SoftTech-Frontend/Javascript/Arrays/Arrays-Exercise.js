function addAndSubtract(arr){
    let sum = arr.reduce((a,b) => a + b);

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 == 0)
            arr[i] += i;
        else
            arr[i] -= i;
    }

    console.log(arr);
    console.log(sum);
    console.log(arr.reduce((a,b) => a + b));
}

function commonElements(arrOne, arrTwo){
    for (let i = 0; i < arrOne.length; i++) {
        for (let j = 0; j < arrTwo.length; j++) {
            if (arrOne[i] === arrTwo[j])
                console.log(arrOne[i]);
        }
    }
}

function mergeArrays(arrOne, arrTwo){
    let result = [];

    for (let i = 0; i < arrOne.length; i++) {
        if (i % 2 == 0)
            result.push(Number(arrOne[i]) + Number(arrTwo[i]));
        else
            result.push(arrOne[i] + arrTwo[i]);
    }

    console.log(result.join(' - '));
}

function arrayRotation(arr, rotations){
    for (let i = 0; i < rotations; i++) {
        let temp = arr.shift();
        arr.push(temp);
    }

    console.log(arr.join(' '));
}

function distinctArray(arr){
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        if (!result.includes(arr[i]))
            result.push(arr[i]);
    }

    console.log(result.join(' '));
}

function houseParty(commands){
    let guests = [];

    for (let i = 0; i < commands.length; i++) {
        let command = commands[i].split(' ');
        if (command.length != 3){
            if (guests.includes(command[0]))
                guests.splice(guests.indexOf(command[0]), 1);
            else
                console.log(`${command[0]} is not in the list!`);
        }
        else{
            if (guests.includes(command[0]))
                console.log(`${command[0]} is already in the list!`);
            else
                guests.push(command[0]);
        }
    }

    console.log(guests.join('\n'));
}

function sortArray(array){
    array.sort((a,b) => a.length - b.length || a.localeCompare(b));
    console.log(array.join('\n'));
}

function bombNumbers(arr, bomb){
    let bombNumber = bomb[0];
    let bombPower = bomb[1];

    while (arr.includes(bombNumber)){
        let index = arr.indexOf(bombNumber);
        let startIndex = index - bombPower < 0 ? 0 : index - bombPower;
        let endIndex = index + bombPower > arr.length - 1 ? arr.length - 1 : index + bombPower;
        arr.splice(startIndex, endIndex - startIndex + 1);
    }

    console.log(arr.reduce((a,b) => a + b));
}

function searchNumber(baseArr, commandsArr){
    let elementsToTake = commandsArr[0];
    let elementsToDelete = commandsArr[1];
    let searchedNumber = commandsArr[2];
    let occurences = 0;

    let result = baseArr.slice(0, elementsToTake);

    result.splice(0, elementsToDelete);

    for (let i = 0; i < result.length; i++) {
        if (result[i] == searchedNumber)
            occurences++;
    }

    console.log(`Number ${searchedNumber} occurs ${occurences} times.`)
}

searchNumber([5, 2, 3, 4, 1, 6], [5, 2, 3])