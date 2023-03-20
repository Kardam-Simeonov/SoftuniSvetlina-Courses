function attachEvents() {
    let textArea = document.getElementById('messages');
    let authorField = document.querySelector('input[name="author"]');
    let contentField = document.querySelector('input[name="content"]');
    let submitBtn = document.getElementById('submit');
    let refreshBtn = document.getElementById('refresh');

    submitBtn.addEventListener('click', submitMessage);
    refreshBtn.addEventListener('click', refreshMessages);

    async function submitMessage() {
        let author = authorField.value;
        let content = contentField.value;
        
        let response = await fetch('http://localhost:3030/jsonstore/messenger', {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ author, content })
        });

        if (response.ok) {
            textArea.appendChild(document.createTextNode(`${author}: ${content}`));
            authorField.value = '';
            contentField.value = '';
        }
    };

    async function refreshMessages() {
        let response = await fetch('http://localhost:3030/jsonstore/messenger');
        response = await response.json();

        textArea.textContent = '';
        for (const message of Object.values(response)) {
            textArea.appendChild(document.createTextNode(`${message.author}: ${message.content} \n`));  
        }
    }
}

attachEvents();