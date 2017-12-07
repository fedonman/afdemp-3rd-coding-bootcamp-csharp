document.onload = () => {
    let form = document.querySelector("form");
    let email = document.getElementById("email");
    let error = document.querySelector(".error");

    form.addEventListener("submit", function(e) {
        if (!email.validity.valid) {
            error.innerHTML("Not a valid email!");
            error.className = "error active";
            event.preventDefault();
        }
    }, false)
}

