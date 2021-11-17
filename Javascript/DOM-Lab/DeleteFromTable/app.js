function deleteByEmail() {
    let email = document.getElementsByName("email")[0].value;
    let emailColArr = document.querySelectorAll(
        "#customers tr td:nth-child(2)"
    );
    for (let td of emailColArr) {
        if (td.textContent == email) {
            let row = td.parentElement;
            row.parentElement.removeChild(row);
            document.getElementById('result').textContent = 'Deleted.';
        }
        else{
            document.getElementById('result').textContent = "Not found.";
        }
    }
}