
function GetResult(result){
    // document.getElementById("here").innerHTML = document.getElementsByClassName(`matr-input-cell-1`)[1].value;
    var operation = document.getElementById("SumSubOperations").value;
    if(operation == "+"){
        for(var i=1;i<40;i++){
            var elements = document.getElementsByClassName(`matr-input-cell-${i}`);
            var sum = 0;
            for(var j=0;j<elements.length;j++){
                sum += Number(elements[j].value);
            }
            document.getElementById(`matr-res-cell-${i}`).value = sum;
        }
        
    }   

    else if(operation == "-"){

        for(var i=1;i<40;i++){

            var elements = document.getElementsByClassName(`matr-input-cell-${i}`);
            var sum = 0;

            for(var j = 0; j < elements.length - 1; j++ ){

                sum += Number(elements[j].value) - Number(elements[j + 1].value);
                
            }

            document.getElementById(`matr-res-cell-${i}`).value = sum;
        }
    }

}