//Function to show or hide the interested checkbox depending on whether the door answered check box has been selected
function doorAnswered() {
    if (document.getElementById('chkDoorAnswered').checked) {
        $("#checkInterested").show();
    } else {
        $("#checkInterested").hide();
    }
};

//Function to show or hide the interested checkbox depending on whether the door answered check box has been selected
function interested() {
    if (document.getElementById('chkInterested').checked) {
        $("#chkFollowUp").show();
    } else {
        $("#chkFollowUp").hide();
    }
};
document.getElementById('checkInterested').style.display = "none";
document.getElementById('chkFollowUp').style.display = "none";


