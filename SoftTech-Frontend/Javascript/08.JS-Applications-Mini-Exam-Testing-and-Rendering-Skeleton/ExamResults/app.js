import { html, render } from './node_modules/lit-html/lit-html.js';
import { students } from './students.js';

const template = (students, searchTerm) => html`
  <table class="styled-table">
    <thead>
      <tr>
        <th>Name</th>
        <th>Points</th>
      </tr>
    </thead>
    <tbody>
      ${students.map((student) => html`
        <tr>
          <td class="${student.name.toLowerCase().startsWith(searchTerm.toLowerCase()) ? 'active' : ''}">${student.name}</td>
          <td class="${student.name.toLowerCase().startsWith(searchTerm.toLowerCase()) ? 'active' : ''}">${student.points}</td>
        </tr>
      `)}
    </tbody>
  </table>
  <div class="search">
    <input type="text" class="searchTerm">
    <button class="searchButton" @click=${search}>Search</button>
  </div>
`;

const main = document.querySelector('main');
render(template(students, ''), main);

function search() {
  const searchTerm = document.querySelector('.searchTerm').value;
  render(template(students, searchTerm), main);
}