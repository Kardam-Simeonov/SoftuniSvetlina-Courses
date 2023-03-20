async function lockedProfile() {
    let main = document.querySelector('#main');

    try{
        let profiles = await (await fetch('http://localhost:3030/jsonstore/advanced/profiles')).json();

        for (const profile of Object.entries(profiles)) {
            console.log(profile)
            let profileDiv = document.createElement('div');
            profileDiv.classList.add('profile');

            profileDiv.innerHTML = `<img src="./iconProfile2.png" class="userIcon" />
            <label>Lock</label>
            <input type="radio" name="userLock" value="lock" checked>
            <label>Unlock</label>
            <input type="radio" name="userLock" id="userUnlocked" value="unlock"><br>
            <hr>
            <label>Username</label>
            <input type="text" name="userUsername" value="${profile[1].username}" disabled readonly />
            <div id="userHiddenFields" style="display: none">
                <hr>
                <label>Email:</label>
                <input type="email" name="userEmail" value="${profile[1].email}" disabled readonly />
                <label>Age:</label>
                <input type="email" name="userAge" value="${profile[1].age}" disabled readonly />
            </div>`; 

            let button = document.createElement('button');
            button.addEventListener('click', () => {
                let hiddenFields = profileDiv.querySelector('#userHiddenFields');
                let unlockInput = profileDiv.querySelector('#userUnlocked')

                console.log(unlockInput.checked)
                if (unlockInput.checked){
                    if (hiddenFields.style.display == 'block'){
                        console.log(hiddenFields.style.display == 'block')
                        hiddenFields.style.display = 'none';
                        button.textContent = 'Show more';
                    }
                    else {
                        hiddenFields.style.display = 'block';
                        button.textContent = 'Hide it';
                    }
                }
            });

            button.textContent = 'Show more';
            profileDiv.appendChild(button);
            main.appendChild(profileDiv);
        }
    }
    catch (error) {
        console.log('Error in fetch request ' + error)
    }
}