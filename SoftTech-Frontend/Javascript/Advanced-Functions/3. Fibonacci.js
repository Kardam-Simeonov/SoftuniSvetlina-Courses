function result() {
    let x = 0;
    let y = 1;

    return function() {
        let temp = x + y;
        x = y;
        y = temp;
        return x;
    };
}
let fib = result();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13