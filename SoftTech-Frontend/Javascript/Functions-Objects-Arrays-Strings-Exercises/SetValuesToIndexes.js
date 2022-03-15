function assignValueIndex(input){
    let count = Number( input[ 0 ] );
    let output = [];

    for(let i = 1; i < input.length; i++) {
        let [ index, value ] = input[ i ].split( ' - ' );
        output[ index ] = value;
    }
    
    for (let i = 0; i < count; i++) {
        if (output[i] == undefined)
            console.log(0);
        else
            console.log(output[i]);
    }
}