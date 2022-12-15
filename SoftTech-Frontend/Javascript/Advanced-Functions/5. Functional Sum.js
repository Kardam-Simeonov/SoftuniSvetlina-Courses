function add(num) {
    let sum = num;

    function subFunction(subNum) {
        sum += subNum;
        return subFunction;
    }

    subFunction.toString = function() { return sum };
    return subFunction;
}
console.log(add(1).toString());
console.log(add(1)(6)(-3).toString());