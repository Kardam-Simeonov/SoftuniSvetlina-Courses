function attachEvents() {
    let phonebook = document.getElementById('phonebook');
    let btnLoad = document.getElementById('btnLoad');
    let personName = document.getElementById('person');
    let personPhone = document.getElementById('phone');
    let btnCreate = document.getElementById('btnCreate');

    btnLoad.addEventListener('click', loadContacts);
    btnCreate.addEventListener('click', createContact);

    async function loadContacts() {
        phonebook.innerHTML = '';
        try {
            let contacts = await fetch('http://localhost:3030/jsonstore/phonebook');
            contacts = await contacts.json();

            for (let contact of Object.entries(contacts)) {
                let li = document.createElement('li');
                li.textContent = `${contact[1].person}: ${contact[1].phone}`;
                
                let deleteBtn = document.createElement('button');
                deleteBtn.textContent = 'Delete';

                deleteBtn.addEventListener('click', async () => {
                    try {
                        await fetch(`http://localhost:3030/jsonstore/phonebook/${contact[0]}`, {
                            method: 'DELETE'
                        });
                        loadContacts();
                    }
                    catch (err) {
                        displayError(err);
                    }
                });

                li.append(deleteBtn);
                phonebook.append(li);
            }
        }
        catch (err) {
            displayError(err);
        }
    }

    async function createContact() {
        try {
            await fetch('http://localhost:3030/jsonstore/phonebook', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ person: personName.value, phone: personPhone.value })
            });
            personName.value = '';
            personPhone.value = '';
            loadContacts();
        }
        catch (err) {
            displayError(err);
        }
    }

    function displayError(err) {
        phonebook.append(document.createElement('li').textContent = 'Error: ' + err);
    }
}

attachEvents();