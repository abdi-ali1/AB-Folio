

$("#btnGet").click(function () {

    if (CheckForLetters(GetElement("cryptoAmount").value))
    {
        alert("only insert numbers not characters");
    }

    $.ajax(
    {
        type: "POST", //HTTP POST Method
        url: "GetResult", // Controller/ GetResult 
        data: 
        { 

            //Passing data
            id: $("#cryptoId").val(), 
            amount: $("#cryptoAmount").val()
        },
            success: function(d)
            {
                GetElement("valueContainer").style.display = "flex";
                GetElement("textValueCrypto").innerHTML =  d;
            
            }
    });
});
    

function GetElement(id)
{
    return document.getElementById(id);
}


function CheckForLetters(value)
{
  
     return /[a-zA-Z]/.test(value);
    
}

function RemoveQoutes(value)
{
    let withoutQuotes = value.replaceAll('"', '');
    return withoutQuotes
}


