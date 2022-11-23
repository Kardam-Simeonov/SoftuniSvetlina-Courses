function lockedProfile() {
    let buttons = document.querySelectorAll('button');
    Array.from(buttons).forEach(b => b.addEventListener('click', showInfo));

    function showInfo(e) {
        let button = e.target;
        let unlockButton = button.parentNode.querySelector('input[type="radio"][value="unlock"]');
        let hiddenInfo = button.parentNode.querySelector('div');

        if (unlockButton.checked){
            if (button.textContent == 'Show more') {
                hiddenInfo.style.display = 'block';
                button.textContent = 'Hide it';
            } else {
                hiddenInfo.style.display = 'none';
                button.textContent = 'Show more';
            }
        }
    }

}