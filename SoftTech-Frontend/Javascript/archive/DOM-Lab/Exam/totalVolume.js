function totalVolume(boxes){
    let totalVolume = 0;

    for (let i = 0; i < boxes.length; i++) {
        totalVolume += boxVolume(boxes[i]);
    }

    function boxVolume(box){
        return box[0] * box[1] * box[2];
    }

    console.log(totalVolume);
}