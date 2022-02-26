/* Manipulating the select DOM using JS */
var select = document.getElementById("subject-list");
var optionList = ["Please Select", "Order / Shipping Status", "Billing Questions", "Multiple Credit Card Authorisations", "International Shipping", "Digital Products / Downloads", "Exchanges & Returns", "Pre-Order Questions", "Account / Sign-in Issue", "Cancel / Change Order Request", "Other"];

for (var i = 0; i < optionList.length; i++) {
    var options = optionList[i];
    var element = document.createElement("option");
    element.textContent = options;
    element.value = options;
    select.appendChild(element);
}