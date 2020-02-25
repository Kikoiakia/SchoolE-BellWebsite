function upvote() {
    this.item.Rating++;
    $("Rating").val(this.item.Rating);
    $("Rating").html(this.item.Rating);
}

function downvote() {
    this.item.Rating--;
    $("Rating").val(this.item.Rating);
    $("Rating").html(this.item.Rating);
}

