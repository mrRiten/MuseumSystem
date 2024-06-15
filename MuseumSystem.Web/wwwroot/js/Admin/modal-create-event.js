var modal = document.getElementById("create_event");
var create_enent_btn = document.getElementById("create_enent_btn");
var close_btn = document.getElementById("create_event_close_btn");

create_enent_btn.onclick = function () {
    modal.style.display = "flex";
}

close_btn.onclick = function () {
    modal.style.display = "none";
    document.body.style.overflow = "auto";
}
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
        document.body.style.overflow = "auto";
    }
}