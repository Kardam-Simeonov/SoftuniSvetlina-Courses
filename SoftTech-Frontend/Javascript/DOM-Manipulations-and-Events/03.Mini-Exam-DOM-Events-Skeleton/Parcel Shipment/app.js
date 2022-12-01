function solution() {
    let registerButton = document.querySelector('#registerButton');
    let input = document.querySelector('input');
    let lists = document.querySelectorAll('ul');

    let listOfParcels = lists[0];
    let sentParcels = lists[1];

    registerButton.addEventListener('click', function () {
        let parcel = input.value;
        let li = document.createElement('li');
        let sendButton = document.createElement('button');
        sendButton.textContent = 'Send';
        sendButton.addEventListener('click', function () {
            sentParcels.appendChild(li);
            sendButton.remove();
        });
        
        li.textContent = parcel;
        li.appendChild(sendButton);
        listOfParcels.appendChild(li);
        
        Array.from(listOfParcels.children).sort((a, b) => a.textContent.localeCompare(b.textContent)).forEach(li => listOfParcels.appendChild(li));
        input.value = '';
    });
}