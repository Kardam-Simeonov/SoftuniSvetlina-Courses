function booksForSummer(pages, pagesPerHour, days) {
    let totalHours = pages / pagesPerHour;
    let result = totalHours / days;
    console.log(result);
}

function birthdayParty(input) {
    let cake = input * 0.20;
    let drinks = cake * 0.55;
    let animator = input / 3;

    console.log(cake + drinks + animator + input);
}

function cinema(type, row, col) {
    if (type == 'Premiere') {
        console.log((12.00 * (row * col)).toFixed(2));
    }
    else if (type == 'Normal') {
        console.log((7.50 * (row * col)).toFixed(2));
    }
    else if (type == 'Discount') {
        console.log((5.00 * (row * col)).toFixed(2));
    }
}

function summerOutfit(temperature, weather) {
    let clothes = ''
    let shoes = ''

    if (temperature <= 18) {
        switch (weather) {
            case "Morning":
                clothes = "Sweatshirt";
                shoes = "Sneakers";
                break;
            case "Afternoon":
                clothes = "Shirt";
                shoes = "Moccasins";
                break;
            case "Evening":
                clothes = "Shirt";
                shoes = "Moccasins";
                break;
        }
    }
    else if (18 <= temperature && temperature <= 24) {
        switch (weather) {
            case "Morning":
                clothes = "Shirt";
                shoes = "Moccasins";
                break;
            case "Afternoon":
                clothes = "T-Shirt";
                shoes = "Sandals";
                break;
            case "Evening":
                clothes = "Shirt";
                shoes = "Moccasins";
                break;
        }
    }
    else if (temperature >= 25) {
        switch (weather) {
            case "Morning":
                clothes = "T-Shirt";
                shoes = "Sandals";
                break;
            case "Afternoon":
                clothes = "Swim Suit";
                shoes = "Barefoot";
                break;
            case "Evening":
                clothes = "Shirt";
                shoes = "Moccasins";
                break;
        }

    }

    console.log(`It's ${temperature} degrees, get your ${clothes} and ${shoes}.`);
}


function fishingBoat(budget, season, fisherman) {
    let price = 0;
    if (season == 'Spring') {
        price = 3000;
    }
    else if (season == 'Summer' || season == 'Autumn') {
        price = 4200;
    }
    else if (season == 'Winter') {
        price = 2600;
    }

    if (fisherman <= 6) {
        price *= 0.90;
    }
    else if (fisherman >= 7 && fisherman <= 11) {
        price *= 0.85;
    }
    else if (fisherman >= 12) {
        price *= 0.75;
    }

    if (fisherman % 2 == 0 && season != 'Autumn') {
        price *= 0.95;
    }

    if (budget >= price) {
        console.log(`Yes! You have ${(budget - price).toFixed(2)} leva left.`);
    }
    else {
        console.log(`Not enough money! You need ${(price - budget).toFixed(2)} leva.`);
    }
}

function journey(budget, season) {
    let destination = '';
    let place = '';
    let price = 0;

    if (budget <= 100) {
        destination = 'Bulgaria';
        if (season == 'summer') {
            place = 'Camp';
            price = budget * 0.30;
        }
        else if (season == 'winter') {
            place = 'Hotel';
            price = budget * 0.70;
        }
    }
    else if (budget <= 1000) {
        destination = 'Balkans';
        if (season == 'summer') {
            place = 'Camp';
            price = budget * 0.40;
        }
        else if (season == 'winter') {
            place = 'Hotel';
            price = budget * 0.80;
        }
    }
    else if (budget > 1000) {
        destination = 'Europe';
        place = 'Hotel';
        price = budget * 0.90;
    }

    console.log(`Somewhere in ${destination}`);
    console.log(`${place} - ${(price).toFixed(2)}`);
}