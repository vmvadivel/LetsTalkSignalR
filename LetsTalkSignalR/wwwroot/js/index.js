

function showChatDialog() {
    var dialogEl = document.getElementById('chatDialog');
    dialogEl.style.display = 'block';
}

function ready() {
    setTimeout(showChatDialog, 750);
}


document.addEventListener('DOMContentLoaded', ready);