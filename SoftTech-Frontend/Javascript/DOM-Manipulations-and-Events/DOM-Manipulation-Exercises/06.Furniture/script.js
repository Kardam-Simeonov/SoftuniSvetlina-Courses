function solve() {
    let [inputArea, outputArea] = document.querySelectorAll('textarea');
    let [generateBtn, buyBtn] = document.querySelectorAll('button');
    let table = document.querySelector('table.table tbody');

    generateBtn.addEventListener('click', generate);
    buyBtn.addEventListener('click', buy);

    function generate() {
        let furniture = JSON.parse(inputArea.value);

        for (let i = 0; i < furniture.length; i++) {
            let row = document.createElement('tr');
            let img = document.createElement('td');
            let name = document.createElement('td');
            let price = document.createElement('td');
            let decFactor = document.createElement('td');
            let checkbox = document.createElement('td');

            img.innerHTML = `<img src="${furniture[i].img}">`;
            name.textContent = furniture[i].name;
            price.textContent = furniture[i].price;
            decFactor.textContent = furniture[i].decFactor;
            checkbox.innerHTML = `<input type="checkbox">`;

            row.appendChild(img);
            row.appendChild(name);
            row.appendChild(price);
            row.appendChild(decFactor);
            row.appendChild(checkbox);

            table.appendChild(row);
        }
    }

    function buy() {
        let boughtFurniture = [];
        let totalPrice = 0;
        let decFactor = 0;
        let count = 0;

        let checkboxes = document.querySelectorAll('input[type="checkbox"]:checked');

        for (let checkbox of checkboxes) {
            let row = checkbox.parentNode.parentNode;
            let name = row.children[1].textContent;
            let price = Number(row.children[2].textContent);
            let factor = Number(row.children[3].textContent);

            boughtFurniture.push(name);
            totalPrice += price;
            decFactor += factor;
            count++;
        }

        decFactor /= count;

        outputArea.value = `Bought furniture: ${boughtFurniture.join(', ')}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${decFactor}`;
    }
}