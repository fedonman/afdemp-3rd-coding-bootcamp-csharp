// runs after DOM is loaded
window.onload = function() {
  function Book(title, haveRead) {
    this.title = title,
    this.haveRead = haveRead
  }

  function addBookElement(book) {
    // create DOM element
    let bookElement = document.createElement("li");
    
    // set properties
    bookElement.innerHTML = book.title;
    bookElement.classList = book.haveRead ? "read" : "not-read";
    
    // set event handler
    bookElement.onclick = function(e) {
      if (bookElement.classList.contains("read")) {
        bookElement.classList = "not-read";
      }
      else {
        bookElement.classList = "read";
      }
    }

    // append it to DOM
    bookListElement.appendChild(bookElement);
  }

  let books = [
    new Book('William Wegman: Being Human', false),
    new Book('The Autobiography of Gucci Mane', false),
    new Book('Harry Potter and the Sorcerer\'s Stone', false),
    new Book('Only the Rain', false)
  ];

  let bookListElement = document.getElementById("book-list");
  let bookFormElement = document.getElementById("book-form");

  for (let book of books) {
    addBookElement(book);
  }

  bookFormElement.onsubmit = function(e) {
    // get input element
    let inputElement = document.getElementById("title-input");
    // create a Book object
    let book = new Book(inputElement.value, false);
    // update app's state
    books.push(book);
    
    // update the DOM
    addBookElement(book);

    inputElement.value = '';
    e.preventDefault();
  }
  
}