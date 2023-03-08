function solve() {
    let departBtn = document.getElementById('depart');
    let arriveBtn = document.getElementById('arrive');
    let info = document.querySelector('.info');

    let requestId = 'depot'
    let name = '';

    function depart() {
        let response = fetch(`http://localhost:3030/jsonstore/bus/schedule/${requestId}`).then(res => res.json());
        response.then(data => {
            info.textContent = `Next stop ${data.name}`;
            departBtn.disabled = true;
            arriveBtn.disabled = false;
            requestId = data.next;
            name = data.name;
        });
        response.catch(() => {
            info.textContent = 'Error';
            departBtn.disabled = true;
            arriveBtn.disabled = true;
        })
    }

    function arrive() {
        info.textContent = `Arriving at ${name}`;
        departBtn.disabled = false;
        arriveBtn.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();