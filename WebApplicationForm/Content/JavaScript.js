function Confirm() {
    var confirm_value = document.createElement("INPUT");

    confirm_value.type = "hidden";
    confirm_value.name = "confirm_value";

    if (confirm("Are You Sure You Want To Remove This Meeting Note?")) {
        confirm_value.value = "Yes";
    }
    else {
        confirm_value.value = "No";
    }

    document.forms[0].appendChild(confirm_value);
}