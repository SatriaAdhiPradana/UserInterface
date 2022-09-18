
function addStudent() {
    let firstName = document.getElementById("fname").value
    let lastName = document.getElementById("lname").value;
    let gender = document.getElementById("gender").value;
    let email = document.getElementById("email").value;
    let grade = document.getElementById("grade").value;
    // form validation


    let text1 = document.getElementById("text1");
    let text2 = document.getElementById("text2");
    let text3 = document.getElementById("text3");
    let text4 = document.getElementById("text4");
    let text5 = document.getElementById("text5");

    const student = {
        firstName: firstName,
        lastName: lastName,
        gender: gender,
        email: email,
        grade: grade,
    }

    function validate(StudentInformation) {
        if (null || StudentInformation.trim().length === 0) {
            return true;
        }
        else return false

    }

    //Email validation
    function validateEmail() {
        const mail = /^([a-zA-Z0-9\._]+)@([a-zA-Z0-9])+.([a-z]+)(.[a-z]+)?$/;

        if (mail.test(email)) {
            return true;
        } else {
            return false;
        }
    }

    if (validate(firstName)) {
        text1.style.color = "red";
        text1.innerHTML = "First name is required";
    }
    else if (validate(lastName)) {
        text2.style.color = "red";
        text2.innerHTML = "Last name box can not be empty";
    }
    else if (validate(gender)) {
        text3.style.color = "red";
        text3.innerHTML = "Gender is required";
    }
    else if (!validateEmail()) {
        text4.style.color = "red";
        text4.innerHTML = "Invalid email or no email provided";
    }
    else if (validate(grade)) {
        text5.style.color = "red";
        text5.innerHTML = "class is required";
    }
    else {
        fetch('http://localhost:8000/students', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },

            body: JSON.stringify(student)
        })
            .then(response => response.text())
            .then(json => {
                const result = document.getElementById("result");
                result.innerHTML = json;
            })
            .catch(err => console.log(err));
    }
}


const loopTroughStudents = (listOfStudents) => {
    for (let i = 0; i < listOfStudents.length; i++) {
        let studentId = document.getElementById("studentId")
        let Pid = document.createElement("p");
        Pid.innerHTML = listOfStudents[i].id;
        document.body.appendChild(Pid);
        studentId.appendChild(Pid);

        let fnames = document.getElementById("fnames");
        let Pfname = document.createElement("p");
        Pfname.innerHTML = listOfStudents[i].firstName;
        document.body.appendChild(Pfname);
        fnames.appendChild(Pfname);

        let lnames = document.getElementById("lnames");
        let Plname = document.createElement("p");
        Plname.innerHTML = listOfStudents[i].lastName;
        document.body.appendChild(Plname);
        lnames.appendChild(Plname);

        let Pemail = document.createElement("p");
        let emails = document.getElementById("emails");
        Pemail.innerHTML = listOfStudents[i].email;
        document.body.appendChild(Pemail);
        emails.appendChild(Pemail)

        let Pgender = document.createElement("p");
        const sex = document.getElementById("genders");
        Pgender.innerHTML = listOfStudents[i].gender;
        document.body.appendChild(Pgender);
        sex.appendChild(Pgender)

        let Pgrade = document.createElement("p");
        const studentGrade = document.getElementById("studentgrade")
        Pgrade.innerHTML = listOfStudents[i].grade;
        document.body.appendChild(Pgrade);
        studentGrade.appendChild(Pgrade)

    }
}
function displayStudents() {

    fetch('http://localhost:8000/students')
        .then((response) => response.json())
        .then((data) => loopTroughStudents(data))
        .catch(err => console.log(err));
}

const removeStudent = () => {
    const id = prompt("enter id of student to delete")
    fetch(`http://localhost:8000/students/${id}`, {
        method: "DELETE",
        headers: {
            "content-type": "application/json"
        }
    })
        .then(response => response.text())
        .then(data => {
            const result2 = document.getElementById("result2");
            result2.innerHTML = data;
        })
        .catch(error => console.log(error))
}
Satria Adhi Pradana 2022
