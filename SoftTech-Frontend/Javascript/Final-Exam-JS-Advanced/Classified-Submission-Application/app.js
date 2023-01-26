function solve() {
    let main = document.querySelector('main section');
    let author = document.querySelector('#creator');
    let title = document.querySelector('#title');
    let content = document.querySelector('#content');
    let buttonCreate = document.querySelector('.create');

    buttonCreate.addEventListener('click', (e) => {
        e.preventDefault();

        let article = document.createElement('article');
        let h1 = document.createElement('h1');
        let creatorP = document.createElement('p');
        let contentP = document.createElement('p');
        let div = document.createElement('div');
        let buttonDelete = document.createElement('button');

        h1.textContent = title.value;
        creatorP.textContent = `Creator: ${author.value}`;
        contentP.textContent = content.value;
        buttonDelete.textContent = 'Delete';

        div.className = 'buttons';
        buttonDelete.className = 'btn delete';

        div.appendChild(buttonDelete);
        article.appendChild(h1);
        article.appendChild(creatorP);
        article.appendChild(contentP);
        article.appendChild(div);
        main.appendChild(article);

        buttonDelete.addEventListener('click', (e) => {
            article.remove();
        });
    });
}