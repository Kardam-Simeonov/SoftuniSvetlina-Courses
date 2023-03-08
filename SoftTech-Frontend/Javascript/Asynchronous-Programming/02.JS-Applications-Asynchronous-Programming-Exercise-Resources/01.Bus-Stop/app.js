async function getInfo() {
    let stopId = document.querySelector('#stopId').value;
    let stopName = document.querySelector('#stopName');
    let buses = document.querySelector('#buses');

    try {
        let response = await (await fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopId}`)).json();
        stopName.textContent = response.name;
        for (const [bus, time] of Object.entries(response.buses)) {
            let li = document.createElement('li');
            li.textContent = `Bus ${bus} arrives in ${time} minutes`;
            buses.appendChild(li);
        }
    }
    catch {
        stopName.textContent = 'Error';
        buses.innerHTML = '';
    }
}