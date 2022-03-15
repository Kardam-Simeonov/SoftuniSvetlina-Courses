function progressBar() {
    let bar = document.getElementById("bar");

    let temp = 0;
    setInterval(() => {
        temp += 3.3;
        bar.style.width = temp + '%';
    }, 1000);

}