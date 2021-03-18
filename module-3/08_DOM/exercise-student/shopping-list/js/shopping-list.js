// add pageTitle

let pageTitle = "My Shopping List";

// add groceries

let groceries = ["milk", "cheese", "eggs", "butter", "beans", "apples", "bread", "bagels", "wine", "strawberry lemonade"];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
    let titleElement = document.getElementById("title");
    titleElement.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let groceriesElement = document.getElementById("groceries");
  for (let index = 0; index < groceries.length; index++) {
    const element = groceries[index];
    let newListItem = document.createElement("li");
    newListItem.innerText = element;

    groceriesElement.insertAdjacentElement("afterbegin", newListItem);
  }

}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let allListItems = document.querySelectorAll("li");
  for (let index = 0; index < allListItems.length; index++) {
    const element = allListItems[index];
    element.classList.add("completed");
  }
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
