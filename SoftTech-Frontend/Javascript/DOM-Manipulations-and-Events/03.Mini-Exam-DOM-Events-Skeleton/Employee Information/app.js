function deleteByID() {
    let idToDelete = document.querySelector("input").value;
    let tableIds = document.querySelectorAll("td:nth-child(3)");
    let result = document.querySelector("#result");
    let beenDeleted = false;

    for (const id of tableIds) {
        if (id.textContent == idToDelete) {
            id.parentElement.remove();
            result.textContent = "Deleted.";
            beenDeleted = true;
        }
    }

    if (!beenDeleted){
        result.textContent = "Not found.";
    }
}