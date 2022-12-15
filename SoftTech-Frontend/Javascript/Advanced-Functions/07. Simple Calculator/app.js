function calculator() {
    function init(selector1, selector2, resultSelector){
        let firstNum = document.querySelector(selector1);
        let secondNum = document.querySelector(selector2);
        let result = document.querySelector(resultSelector);

        document.querySelector('#sumButton').addEventListener('click', sum);
        document.querySelector('#subtractButton').addEventListener('click', subtract);

        function sum(){
            result.value = Number(firstNum.value) + Number(secondNum.value);
        }

        function subtract(){
            result.value = Number(firstNum.value) - Number(secondNum.value);
        }
    }
}

const calculate = calculator ();
calculate.init ('#num1', '#num2', '#result');


