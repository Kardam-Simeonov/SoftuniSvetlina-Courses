function addItem() {
    var ul = document.getElementById("items");
    var li = document.createElement("li");
    ul.appendChild(li).textContent = document.getElementById('newItemText').value;
}