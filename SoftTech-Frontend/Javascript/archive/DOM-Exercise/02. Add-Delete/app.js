function solve() {
  let ul = document.getElementById('items');
  ul.addEventListener("click", deleteItem);

  let li = document.createElement('li');
  li.innerHTML = `${document.getElementById('newText').value} <a href="#">[Delete]</a>`;
  ul.appendChild(li)

  function deleteItem(item) {
    let element = item.target.parentNode
    element.remove()
}
}


