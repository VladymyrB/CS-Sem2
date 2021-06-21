function GetColumnAmount(ColumnAmount){
    ShowAllColumnsBefore(ColumnAmount);
    HideAllColumnsAfter(ColumnAmount);
}

function ShowAllColumnsBefore(Column){
    for(var i=Column;i>2;i--){
        var ColumnToShow = document.getElementsByClassName(`matr-col-${i}`);
        for(var j=0;j<ColumnToShow.length;j++){
            ColumnToShow[j].style.display = "inline";
        }
    }
}
function HideAllColumnsAfter(Column){
    for(var i=7;i>Column;i--){
        var ColumnToHide = document.getElementsByClassName(`matr-col-${i}`);
        for(var j=0;j<ColumnToHide.length;j++){
            ColumnToHide[j].style.display = "none";
        }
    }
}