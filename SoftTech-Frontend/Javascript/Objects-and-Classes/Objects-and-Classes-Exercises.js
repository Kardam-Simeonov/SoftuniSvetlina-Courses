function employees(namesArray){
    employeeObject = {};

    for (const employee of namesArray) {
        employeeObject[employee] = employee.length;
    }
    
    for (const employee in employeeObject) {
        console.log(`Name: ${employee} -- Personal Number: ${employeeObject[employee]}`);
    }
}

function towns(input){
    for (const town of input) {
        let [name, latitude, longitude] = town.split(' | ');
        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);
        let townObject = {
            town: name,
            latitude: latitude,
            longitude: longitude
        }
        console.log(townObject);
    }
}

function storeProvision(storageArray, deliveryArray){
    let storageObject = {};
    for (let i = 0; i < storageArray.length; i+=2) {
        storageObject[storageArray[i]] = Number(storageArray[i+1]);
    }

    for (let i = 0; i < deliveryArray.length; i+=2) {
        if(storageObject.hasOwnProperty(deliveryArray[i])){
            storageObject[deliveryArray[i]] += Number(deliveryArray[i+1]);
        } else {
            storageObject[deliveryArray[i]] = Number(deliveryArray[i+1]);
        }
    }

    for (const product in storageObject) {
        console.log(`${product} -> ${storageObject[product]}`);
    }
}

function movies(input){
    let movies = [];
    for (const movie of input) {
        if(movie.includes('addMovie')){
            let movieName = movie.split('addMovie ')[1];
            let movieObject = {
                name: movieName
            }
            movies.push(movieObject);
        } else if (movie.includes('directedBy')){
            let [movieName, director] = movie.split(' directedBy ');
            let movieObject = movies.find(m => m.name === movieName);
            if(movieObject){
                movieObject.director = director;
            }
        } else if (movie.includes('onDate')){
            let [movieName, date] = movie.split(' onDate ');
            let movieObject = movies.find(m => m.name === movieName);
            if(movieObject){
                movieObject.date = date;
            }
        }
    }

    movies.forEach(movie => {
        if(movie.name && movie.director && movie.date){
            console.log(JSON.stringify(movie));
        }
    });
}

function inventory(input){
    let heroes = [];
    for (const hero of input) {
        let [name, level, items] = hero.split(' / ');
        level = Number(level);
        items = items.split(', ').sort((a, b) => a.localeCompare(b));
        let heroObject = {
            name: name,
            level: level,
            items: items
        }
        heroes.push(heroObject);
    }

    heroes.sort((a, b) => a.level - b.level);
    heroes.forEach(hero => {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items.join(', ')}`);
    });
}

function dictionary(input){
    let dictionary = {};
    for (const word of input) {
        let wordObject = {
            term: word,
            definition: ''
        }
        dictionary[word] = wordObject;
    }

    let sortedDictionary = Object.values(dictionary).sort((a, b) => a.term.localeCompare(b.term));
    for (const [term, definition] of sortedDictionary) {
        console.log(`Term: ${term} => Definition: ${definition}`);
    }
}
        