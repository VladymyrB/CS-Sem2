function GetRowAmount(RowAmount){
     ShowAllRowsBefore(RowAmount);
     HideAllRowsAfter(RowAmount);
}
function ShowAllRowsBefore(Row){
     
     for(var i=Row;i>2;i--){
          var RowsToShow = document.getElementsByClassName(`matr-row-${i}`);
          for(var j = 0;j< RowsToShow.length;j++){
               RowsToShow[j].style.display = "block";
          }
     }
}
function HideAllRowsAfter(Row){
     var RowsToHide = document.getElementsByClassName(`row-bigger-${Row}`);
     for(var i=0;i<RowsToHide.length;i++){
          RowsToHide[i].style.display = "none";
     }
}
