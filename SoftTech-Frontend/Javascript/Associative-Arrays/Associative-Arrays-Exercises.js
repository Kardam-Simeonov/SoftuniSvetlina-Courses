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
    let playersCards = {};

    for (let entry of inputArray) {
        let splitArray = entry.split(": ");
        let name = splitArray[0];

        if (!playersCards.hasOwnProperty(name)){
            playersCards[name] = [];
        }

        for (let card of splitArray[1].split(", ")){
            if (!playersCards[name].includes(card)){
                playersCards[name].push(card);
            }
        }
    }


    for (let player in playersCards) {
        let handValue = 0;

        for (let card of playersCards[player]) {
            let power = card.substring(0, card.length - 1);
            let type = card.substring(card.length - 1);

            if (isNaN(power)) {
                switch (power) {
                    case "J":
                        power = 11;
                        break;
                    case "Q":
                        power = 12;
                        break;
                    case "K":
                        power = 13;
                        break;
                    case "A":
                        power = 14;
                        break;
                }
            }

            switch (type) {
                case "S":
                    type = 4;
                    break;
                case "H":
                    type = 3;
                    break;
                case "D":
                    type = 2;
                    break;
                case "C":
                    type = 1;
                    break;
            }

            handValue += Number(power) * Number(type);
        }

        console.log(`${player}: ${handValue}`);
    }
}
