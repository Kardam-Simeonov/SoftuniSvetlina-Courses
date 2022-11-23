function attachEventsListeners() {
    let buttons = document.querySelectorAll('input[type="button"]');
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    for (let button of buttons) {
        button.addEventListener('click', function () {
            let input = button.previousElementSibling;
            let value = Number(input.value);
            switch (input.id) {
                case 'days':
                    hours.value = value * 24;
                    minutes.value = value * 1440;
                    seconds.value = value * 86400;
                    break;
                case 'hours':
                    days.value = value / 24;
                    minutes.value = value * 60;
                    seconds.value = value * 3600;
                    break;
                case 'minutes':
                    days.value = value / 1440;
                    hours.value = value / 60;
                    seconds.value = value * 60;
                    break;
                case 'seconds':
                    days.value = value / 86400;
                    hours.value = value / 3600;
                    minutes.value = value / 60;
                    break;
            }
        });
    }
}