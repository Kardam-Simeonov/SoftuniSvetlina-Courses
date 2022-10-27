function wordTracker(inputArray){
    let wordsToSearch = inputArray.shift().split(' ');
    let words = {};
    for (let word of wordsToSearch){
        words[word] = 0;
    }
    for (let word of inputArray){
        if (words.hasOwnProperty(word)){
            words[word]++;
        }
    }
    let sortedWords = Object.entries(words).sort((a, b) => b[1] - a[1]);
    for (let [word, count] of sortedWords){
        console.log(`${word} - ${count}`);
    }
}

function oddOccurrences(inputArray){
    arr = inputArray.split(' ');
    let words = {};
    for (let currentWord of arr){
        currentWord = currentWord.toLowerCase();
        if (words.hasOwnProperty(currentWord)){
            words[currentWord]++;
        }
        else{
            words[currentWord] = 1;
        }
    }

    let result = [];
    for (let word of arr){
        word = word.toLowerCase();

        if (words[word] % 2 != 0){
            if (!result.includes(word)){
                result.push(word);
            }
        }
    }

    console.log(result.join(" "));
}

function piccolo(inputArray){
    let parking = [];

    for (let car in inputArray){
        inputArray[car] = inputArray[car].split(", ");

        if (inputArray[car][0] == "IN"){
            parking.push(inputArray[car][1]);
        }
        else if (inputArray[car][0] == "OUT"){
            if (parking.includes(inputArray[car][1])){
                parking.splice(parking.indexOf(inputArray[car][1]), 1);
            }
        }
    }

    if (parking.length == 0){
        console.log("Parking Lot is Empty");
    }
    else{
        parking.sort((a, b) => a.localeCompare(b));
        for (let car of parking){
            console.log(car);
        }
    }
}

function partyTime(inputArray){
    let vip = [];
    let regular = [];
    let index = inputArray.indexOf("PARTY");

    for (let i = 0; i < index; i++){
        if (isNaN(inputArray[i][0])){
            regular.push(inputArray[i]);
        }
        else{
            vip.push(inputArray[i]);
        }
    }

    for (let i = index + 1; i < inputArray.length; i++){
        if (vip.includes(inputArray[i])){
            vip.splice(vip.indexOf(inputArray[i]), 1);
        }
        else if (regular.includes(inputArray[i])){
            regular.splice(regular.indexOf(inputArray[i]), 1);
        }
    }

    console.log(vip.length + regular.length);
    for (let guest of vip){
        console.log(guest);
    }
    for (let guest of regular){
        console.log(guest);
    }
}

function cardGame(inputArray){
    
}