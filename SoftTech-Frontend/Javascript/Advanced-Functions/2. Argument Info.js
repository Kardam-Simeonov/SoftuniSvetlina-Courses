function argumentInfo(...args){
    let typeCount = {};
    for (let i = 0; i < arguments.length; i++) {
        let type = typeof arguments[i];
        console.log(`${type}: ${arguments[i]}`);
        if (typeCount.hasOwnProperty(type) == false) {
            typeCount[type] = 0;
        }
        typeCount[type]++;
    }

    let arr = Object.entries(typeCount).sort((a, b) => b[1] - a[1]);

    for (const [type, count] of arr) {
        console.log(`${type} = ${count}`)
    }
}

argumentInfo({ name: 'bob'}, 3.333, 9.999);