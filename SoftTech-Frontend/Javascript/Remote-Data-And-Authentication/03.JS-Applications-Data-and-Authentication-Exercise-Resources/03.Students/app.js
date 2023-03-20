function attachEvents(){
    let tableBody = document.querySelector('#results tbody');
    let firstName = document.querySelector('input[name="firstName"]');
    let lastName = document.querySelector('input[name="lastName"]');
    let facultyNumber = document.querySelector('input[name="facultyNumber"]');
    let grade = document.querySelector('input[name="grade"]');
    
    let submitBtn = document.querySelector('#submit');
    let notification = document.querySelector('.notification');

    submitBtn.addEventListener('click', async (e) => {
        e.preventDefault();
        if(firstName.value !== '' && lastName.value !== '' && facultyNumber.value !== '' && grade.value !== ''){
            let student = {
                firstName: firstName.value,
                lastName: lastName.value,
                facultyNumber: facultyNumber.value,
                grade: grade.value
            };
            let response = await fetch('http://localhost:3030/jsonstore/collections/students', {
                method: 'POST',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(student)
            });
            if(response.ok){
                firstName.value = '';
                lastName.value = '';
                facultyNumber.value = '';
                grade.value = '';
            }

            notification.textContent = 'Student added successfully!';
            loadStudents();
        }
        else{
            notification.textContent = 'All fields are required!';
        }
    });

    async function loadStudents(){
        tableBody.innerHTML = '';
        try {
            let students = await fetch('http://localhost:3030/jsonstore/collections/students');
            students = await students.json();

            for(let student of Object.values(students)){
                let tr = document.createElement('tr');
                tr.innerHTML = `<td>${student.firstName}</td><td>${student.lastName}</td><td>${student.facultyNumber}</td><td>${student.grade}</td>`;
                tableBody.appendChild(tr);
            };
        } catch (error) {
            notification.textContent = 'Error: ' + error;
        }
    }

    loadStudents();
}

attachEvents();