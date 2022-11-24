function furniture(input){
    let total = 0;
    let boughtFurniture = [];
    let myRegexp = new RegExp('>>([a-zA-z]+)<<([0-9]+\.[0-9]+|[0-9]+)!([0-9]+)', 'gm');

    for (const order of input) {
        let match = myRegexp.exec(order);
        if(match != null){
            total += Number(match[2]) * Number(match[3]);
            boughtFurniture.push(match[1]);
        }
    }

    console.log('Bought furniture:');
    for (const furniture of boughtFurniture) {
        console.log(furniture);
    }
    console.log(`Total money spend: ${total.toFixed(2)}`);
}

function race(input) {
    let expression = new RegExp('[A-Za-z]|[0-9]', 'gm');
    let participants = input.shift().split(', ');
    let racers = {};

    for (const participant of input) {
        let match = expression.exec(participant);
        let name = '';
        let distance = 0;
        
        while (match != null) {
            if (match[0].match(/[A-Za-z]/gm)) {
                name += match[0];
            } else {
                distance += Number(match[0]);
            }

            match = expression.exec(participant);
        }
        if (participants.includes(name)) {
            if (racers.hasOwnProperty(name)) {
                racers[name] += distance;
            } else {
                racers[name] = distance;
            }
        }
    }
    
    racers = Object.entries(racers).sort((a, b) => b[1] - a[1]);
    console.log(`1st place: ${racers[0][0]}`);
    console.log(`2nd place: ${racers[1][0]}`);
    console.log(`3rd place: ${racers[2][0]}`);
}

function softUniBarIncome(input){
    let expression = new RegExp('%([A-z][a-z]+)%[^|$%.]*<([A-Za-z]+)>[^|$%.]*\|([0-9]+)[^|$%.]*\|([0-9]+\.[0-9]+|[0-9]+)\$', 'gm');
    let total = 0;

    for (const order of input) {
        let match = expression.exec(order);
        if (match != null) {
            let price = Number(match[3]) * Number(match[4]);
            total += price;
            console.log(`${match[1]}: ${match[2]} - ${price.toFixed(2)}`);
        }
    }
    console.log(`Total income: ${total.toFixed(2)}`);
}
