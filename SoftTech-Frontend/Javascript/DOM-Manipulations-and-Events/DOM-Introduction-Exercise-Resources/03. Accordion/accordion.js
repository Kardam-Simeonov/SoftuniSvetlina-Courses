function toggle() {
    const extra = document.querySelector('#extra');
    let button = document.querySelector('.button');

    if (button.textContent === 'More') {
        button.textContent = 'Less';
        extra.style.display = 'block';
    }
    else {
        button.textContent = 'More';
        extra.style.display = 'none';
    }
}