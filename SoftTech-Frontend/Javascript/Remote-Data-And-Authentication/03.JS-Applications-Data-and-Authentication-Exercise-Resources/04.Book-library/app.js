function attachEvents() {
    let tableBody = document.querySelector('tbody');
    let loadBtn = document.querySelector('#loadBooks');
    let submitCreate = document.querySelector('#submitCreate');
    let submitEdit = document.querySelector('#submitEdit');
    let isEdit = false;
    let editId = '';

    loadBtn.addEventListener('click', loadBooks);
    submitCreate.addEventListener('click', createBook);
    submitEdit.addEventListener('click', editBook);

    async function createBook(e) {
        e.preventDefault();

        let formData = new FormData(document.querySelector('form'));
        
        let title = formData.get('title');
        let author = formData.get('author');

        if (title == '' || author == '') {
            return alert('All fields are required!');
        }

        let book = {
            title,
            author
        };

        try {
            await fetch('http://localhost:3030/jsonstore/collections/books', {
                method: 'post',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(book)
            });
        } catch (error) {
            alert(error);
        }

        loadBooks();
    }

    async function editBook(e) {
        e.preventDefault();

        let formData = new FormData(document.querySelector('form'));

        let title = formData.get('title');
        let author = formData.get('author');

        if (title == '' || author == '') {
            return alert('All fields are required!');
        }

        let book = {
            title,
            author
        };

        try {
            await fetch('http://localhost:3030/jsonstore/collections/books/' + editId, {
                method: 'PUT',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(book)
            });
        } catch (error) {
            alert(error);
        }

        loadBooks();
    }

    async function loadBooks() {
        try {
            let response = await fetch('http://localhost:3030/jsonstore/collections/books');
            let data = await response.json();

            tableBody.innerHTML = '';

            Object.values(data).forEach(book => {
                let tr = document.createElement('tr');
                // get the key of the object in the object data
                tr.setAttribute('data-id', Object.keys(data).find(key => data[key] === book));

                let tdTitle = document.createElement('td');
                tdTitle.textContent = book.title;

                let tdAuthor = document.createElement('td');
                tdAuthor.textContent = book.author;

                let tdButtons = document.createElement('td');

                let editBtn = document.createElement('button');
                editBtn.textContent = 'Edit';

                editBtn.addEventListener('click', () => {
                    isEdit = true;
                    editId = tr.getAttribute('data-id');
                    loadForm();
                })

                let deleteBtn = document.createElement('button');
                deleteBtn.textContent = 'Delete';

                deleteBtn.addEventListener('click', async () => {
                    let id = tr.getAttribute('data-id');

                    try {
                        await fetch('http://localhost:3030/jsonstore/collections/books/' + id, {
                            method: 'delete'
                        });
                    } catch (error) {
                        alert(error);
                    }

                    loadBooks();
                });

                tdButtons.appendChild(editBtn);
                tdButtons.appendChild(deleteBtn);

                tr.appendChild(tdTitle);
                tr.appendChild(tdAuthor);
                tr.appendChild(tdButtons);

                tableBody.appendChild(tr);
            });
        } catch (error) {
            alert(error);
        }

        isEdit = false;
        editId = '';
        loadForm();
    }

    function loadForm() {
        if (isEdit) {
            submitCreate.style.display = 'none';
            submitEdit.style.display = 'block';

            document.querySelector('form h3').textContent = 'Edit FORM';
        } else {
            submitCreate.style.display = 'block';
            submitEdit.style.display = 'none';
            document.querySelector('form h3').textContent = 'FORM';
        }
    }

    loadForm();
}

attachEvents();