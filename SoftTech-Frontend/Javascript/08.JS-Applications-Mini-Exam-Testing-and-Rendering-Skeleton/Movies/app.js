import { html, render } from './node_modules/lit-html/lit-html.js';
import { movies } from './movieSeeder.js';

const movieTemplate = (movie) => html`
<li class="cards_item">
    <div class="card">
        <div class="card_image"><img src="./images/${movie.imageLocation}.jpg"></div>
        <div class="card_content">
            <h2 class="card_title">${movie.title}</h2>
            <button class="showBtn">Read More</button>
            <div class="movie" style="display: none" id="${movie.id}">
                <p class="card_text">${movie.description}</p>
            </div>
        </div>
    </div>
</li>`;

const container = document.getElementById('allMovies');
const ul = document.createElement('ul');
container.appendChild(ul);
const result = movies.map(movieTemplate);
render(result, container);

const buttons = document.querySelectorAll('.showBtn');
buttons.forEach((button) => {
  button.addEventListener('click', (event) => {
    const movieId = event.target.nextElementSibling.getAttribute('id');
    const movieDiv = document.getElementById(movieId);
    if (movieDiv.style.display === 'none') {
      movieDiv.style.display = 'block';
      button.textContent = 'Read More';
    } else {
      movieDiv.style.display = 'none';
      button.textContent = 'Read Less';
    }
  });
});
