function Account(name, email, password) {
  this.name = name;
  this.email = email;
  this.password = password;
}

$(document).ready(function() {
  let accounts = [
    new Account('Mike', 'mike@gmail.com', '12345'),
    new Account('Mary', 'mary@gmail.com', '12345')
  ];

  let loginFormElement = $('#login-form');
  
  loginFormElement.submit(function(e) {
    let email = $('#login-form #email').val();
    let password = $('#login-form #pwd').val();

    let account = accounts.find(x => x.email === email && x.password === password);
    if (account === undefined) {
      let errorElement = $('#login-form #error');
      errorElement.text('Wrong email/password!');
      errorElement.show();
    }
    else {
      let alertHTML = 
      `<div class="alert alert-success alert-dismissible fade show" role="alert">
        <strong>Hello ${account.name}!</strong>
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>`;
      $('#alerts').append(alertHTML);
    }
    e.preventDefault();
  });
});