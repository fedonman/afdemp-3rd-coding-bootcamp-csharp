// These functions represent my Model
function Product(name, price) {
  this.name = name;
  this.price = price;
}

function CartItem(product, quantity = 1) {
  this.product = product;
  this.quantity = quantity;
}

function Cart() {
  this.items = [];
  this.calculateTotalCost = function() {
    let cost = 0;
    for (let item of this.items) {
      cost += item.product.price * item.quantity;
    }
    return cost;
  }
}

// runs after DOM is loaded
window.onload = function() { 
  function renderInventory(inventory, inventoryListElement) {
    inventoryListElement.innerHTML = '';
    inventory.forEach(x => {
      inventoryListElement.innerHTML += `<li>${x.name} - ${x.price} <button id="${x.name}">Add</button></li>`;
    });
  }
  
  function renderCart(cart, cartListElement) {
    cartListElement.innerHTML = '';
    cart.items.forEach(x => {
        cartListElement.innerHTML += `<li>${x.product.name} - ${x.quantity}</li>`;
    });
  }

  function renderTotalCost(cost, totalCostElement) {
    totalCostElement.innerHTML = `Total cost: $${cost}`;
  }

  /* normally fetch this from server */
  let inventory = [
    new Product('Product X', 4.5),
    new Product('Product Y', 3),
    new Product('Product Z', 5),
    new Product('Product K', 6)
  ];
  let cart = new Cart();

  let inventoryListElement = document.getElementById("inventory-list");
  let cartListElement = document.getElementById("cart-list");
  let totalCostElement = document.getElementById("total-cost");

  renderInventory(inventory, inventoryListElement);

  let addButtons = inventoryListElement.getElementsByTagName('button');
  Array.from(addButtons).map(x => {
    let id = x.getAttribute('id');
    x.onclick = function(e) {
      let index = cart.items.findIndex(x => x.product.name === id);
      if (index === -1) {
        let product = inventory.find(x => x.name === id);
        cart.items.push(new CartItem(product, 1));
      }
      else {
        cart.items[index].quantity += 1;
      }
      renderCart(cart, cartListElement);
      renderTotalCost(cart.calculateTotalCost(), totalCostElement);
    }
  });
}