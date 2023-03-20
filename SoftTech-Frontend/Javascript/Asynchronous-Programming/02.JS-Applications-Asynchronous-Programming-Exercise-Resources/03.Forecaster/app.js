function attachEvents() {
    let locationInput = document.getElementById('location');
    let submitButton = document.getElementById('submit');
    let currentDiv = document.getElementById('current');
    let upcomingDiv = document.getElementById('upcoming');
    let forecastDiv = document.getElementById('forecast');

    submitButton.addEventListener('click', () => {
        let locationName = locationInput.value;
        let locationCode = '';
        let locationsArray = fetch('http://localhost:3030/jsonstore/forecaster/locations');
        locationsArray.then(response => response.json())
            .then(locations => {
                for (const location of locations) {
                    if (location.name == locationName){
                        locationCode = location.code;
                        break;
                    }
                }

                if (locationCode == ''){
                    forecastDiv.style.display = 'block';
                    currentDiv.innerHTML = '<div class="label">Error</div>';
                    upcomingDiv.innerHTML = '';
                    return;
                }

                let currentConditions = fetch(`http://localhost:3030/jsonstore/forecaster/today/${locationCode}`);
                currentConditions.then(response => response.json())
                    .then(current => {
                        let symbol = '';
                        if (current.forecast.condition == 'Sunny'){
                            symbol = '☀';
                        } else if (current.forecast.condition == 'Partly sunny'){
                            symbol = '⛅';
                        } else if (current.forecast.condition == 'Overcast'){
                            symbol = '☁';
                        } else if (current.forecast.condition == 'Rain'){
                            symbol = '☂';
                        }

                        currentDiv.innerHTML = `<div class="label">Current conditions</div>
                        <span class="condition symbol">${symbol}</span>
                        <span class="condition">
                            <span class="forecast-data">${current.name}</span>
                            <span class="forecast-data">${current.forecast.low}°/${current.forecast.high}°</span>
                            <span class="forecast-data">${current.forecast.condition}</span>
                        </span>`;

                        let upcomingConditions = fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${locationCode}`);
                        upcomingConditions.then(response => response.json())
                            .then(upcoming => {
                                let upcomingForecast = upcoming.forecast;
                                let upcomingSpan = document.createElement('div');
                                upcomingSpan.classList.add('forecast-data');

                                for (const forecast of upcomingForecast) {
                                    let symbol = '';
                                    if (forecast.condition == 'Sunny'){
                                        symbol = '☀';
                                    } else if (forecast.condition == 'Partly sunny'){
                                        symbol = '⛅';
                                    } else if (forecast.condition == 'Overcast'){
                                        symbol = '☁';
                                    } else if (forecast.condition == 'Rain'){
                                        symbol = '☂';
                                    }

                                    let span = document.createElement('span');
                                    span.classList.add('upcoming');

                                    span.innerHTML = `<span class="symbol">${symbol}</span>
                                    <span class="forecast-data">${forecast.low}°/${forecast.high}°</span>
                                    <span class="forecast-data">${forecast.condition}</span>`;

                                    upcomingSpan.appendChild(span);
                                }

                                upcomingDiv.innerHTML = `<div class="label">Three-day forecast</div>`;
                                upcomingDiv.appendChild(upcomingSpan);
                            })
                            .catch(() => {
                                forecastDiv.style.display = 'block';
                                currentDiv.innerHTML = '<div class="label">Error</div>';
                                upcomingDiv.innerHTML = '';
                                return;
                            });
                })
                .catch(() => {
                    forecastDiv.style.display = 'block';
                    currentDiv.innerHTML = '<div class="label">Error</div>';
                    upcomingDiv.innerHTML = '';
                    return;
                });
        })
        .catch(() => {
            forecastDiv.style.display = 'block';
            currentDiv.innerHTML = '<div class="label">Error</div>';
            upcomingDiv.innerHTML = '';
            return;
        });
    });
}
attachEvents();