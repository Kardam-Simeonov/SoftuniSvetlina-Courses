function revealWords(words, sentence){
    let wordsArr = words.split(', ');
    for (let word of wordsArr) {
        let replace = '*'.repeat(word.length);
        if (sentence.includes(replace))
            sentence = sentence.replace(replace, word);
    }
    console.log(sentence);
}

function modernTimes(sentence){
    let words = sentence.split(' ');
    let result = [];

    for (let word of words) {
        if (word.startsWith('#') && word.length > 1 && !word.match(/[1-9]/g)) {
            result.push(word.substring(1));
        }
    }

    console.log(result.join('\n'));
}

function extractFile(filePath){
    let file = filePath.split('\\').pop();
    let fileName = file.split('.');
    let fileExtension = fileName.pop();

    console.log(`File name: ${fileName.join('.')}`);
    console.log(`File extension: ${fileExtension}`);
}

function stringSubstring(searchedWord, sentence){
    let words = sentence.split(' ');
    let isFound = false;
    for (let word of words) {
        if (word.toLowerCase() == searchedWord.toLowerCase()) {
            isFound = true;
            break;
        }
    }

    if (isFound)
        console.log(searchedWord);
    else
        console.log(`${searchedWord} not found!`);
}

function replaceRepeatingChars(text){
    let result = '';
    for (let i = 0; i < text.length; i++) {
        if (text[i] != text[i + 1])
            result += text[i];
    }

    console.log(result);
}

function pascalCaseSplitter(text){
    let splitString = [];
    let currentWord = '';

    for (let letter of text) {
        if (letter == letter.toUpperCase()) {
            splitString.push(currentWord);
            currentWord = '';
        }

        currentWord += letter;
    }
    splitString.push(currentWord);
    splitString.shift();

    console.log(splitString.join(', '));
}