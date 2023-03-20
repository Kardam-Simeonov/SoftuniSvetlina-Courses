async function solution() {
    let main = document.getElementById('main');
    try {
        let articleTitles = await fetch('http://localhost:3030/jsonstore/advanced/articles/list');
        articleTitles = await articleTitles.json();

        for (const title of articleTitles) {
            let articleContent = await fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${title._id}`);
            articleContent = await articleContent.json();

            let div = document.createElement('div');
            div.classList.add('accordion');

            div.innerHTML = `
            <div class="head">
                <span>${title.title}</span>
                <button class="button" id="${title._id}">More</button>
            </div>
            <div class="extra">
                <p>${articleContent.content}</p>
            </div>`;

            let button = div.querySelector('button');
            button.addEventListener('click', (e) => {
                let extra = e.target.parentNode.parentNode.querySelector('.extra');
                if (e.target.textContent == 'More') {
                    e.target.textContent = 'Less';
                    extra.style.display = 'block';
                } else {
                    e.target.textContent = 'More';
                    extra.style.display = 'none';
                }
            });

            main.appendChild(div);
        }
    }
    catch (err) {
        console.log(err);
    }
}

solution();