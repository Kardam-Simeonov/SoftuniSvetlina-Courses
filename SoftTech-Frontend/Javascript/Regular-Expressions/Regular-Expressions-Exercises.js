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

furniture(['>>Laptop<<312.2323!3','>>TV<<300.21314!5','>Invalid<<!5','>>TV<<300.21314!20','>>Invalid<!5','>>TV<<30.21314!5','>>Invalid<<!!5','Purchase'])