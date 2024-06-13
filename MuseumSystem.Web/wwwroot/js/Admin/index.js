var event_info = document.getElementById("event_info");
var client_info_table = document.getElementById("client_info_table");
var main = document.getElementById("main");
var current_event_id = document.getElementById("current_event_id");
var td_list = client_info_table.children[1].children;
var td_id = 0;
var temp_td_id = -1;

for (let i = 0; i < td_list.length; i++) {
    td_list[i].onclick = function () {
        {
            td_id = td_list[i].children[0].innerHTML;
            console.log(temp_td_id);
            console.log(td_id);

            if (temp_td_id == td_id && event_info.style.display == "block") {
                event_info.style.display = "none";
                main.style.gridTemplateColumns = "auto"
            }
            else {
                event_info.style.display = "block";
                main.style.gridTemplateColumns = "auto 350px"
                temp_td_id = td_id;
            }
            current_event_id.innerHTML = td_id
        };
    }
}