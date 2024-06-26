﻿var modal = document.getElementById("modal");
var modal_date = document.getElementById("modal_date");
var modal_time = document.getElementById("modal_time");
var close_btn = document.getElementById("closebtn");
var record_item = document.getElementsByClassName("record__item");
var record_id = document.getElementById("recordid");
var event_name = document.getElementById("event_name");
var modal_event_name = document.getElementById("modal_event_name");

for (let i = 0; i < record_item.length; i++) {

    for (var j = 0; j < record_item[i].children[1].children.length; j++) {
        const time_btn_collection = record_item[i].children[1].children[j].children

        time_btn_collection[0].onclick = function () {
            modal.style.display = "flex";
            document.body.style.overflow = "hidden";
            modal_event_name.innerHTML = event_name.innerHTML;
            modal_time.innerHTML = time_btn_collection[0].innerHTML;

            const target_date = record_item[i].children[0];
            modal_date.innerHTML = target_date.innerHTML;
            record_id.value = time_btn_collection[0].value;
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