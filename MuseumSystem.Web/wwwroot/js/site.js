var modal = document.getElementById("modal");
var modal_date = document.getElementById("modal_date");
var modal_time = document.getElementById("modal_time");
var close_btn = document.getElementById("closebtn");
var record_item = document.getElementsByClassName("record__item");


for (let i = 0; i < record_item.length; i++) {
    const time_btn_collection = record_item[i].children[1].children
    for (let j = 0; j < time_btn_collection.length; j++) {
        time_btn_collection[j].onclick = function () {
            modal.style.display = "flex";
            document.body.style.overflow = "hidden";

            modal_time.innerHTML = time_btn_collection[j].innerHTML;

            const target_date = record_item[i].children[0];
            modal_date.innerHTML = target_date.innerHTML;
        }
    }
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