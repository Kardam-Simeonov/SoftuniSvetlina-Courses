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

    for (const participant of participants) {
        let match = expression.exec(participant);
        let name = '';
        let distance = 0;
        
        while (match != null) {
            if (!racers.hasOwnProperty(participant)) {
                racers[participant] = 0;
            }
            
            racers[participant] += Number(match[0]);
            match = expression.exec(participant);
        }
    }
}