function solve() {
  let textArea = document.getElementById('input');
  let sentences = textArea.value.split('.').filter(x => x !== '');
  let result = document.getElementById('output');

  for (let i = 0; i < sentences.length; i += 3) {
    let paragraph = document.createElement('p');
    paragraph.textContent = sentences.slice(i, i + 3).join('.') + '.';
    result.appendChild(paragraph);
  }

  textArea.value = '';
}