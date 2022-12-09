function fibResult(){
    let fibonator = [0, 1];

    function fibonacci(){
        let temp = fibonator[0] + fibonator[1];
        fibonator[0] = fibonator[1];
        fibonator[1] = temp;

        return temp;
    }
}