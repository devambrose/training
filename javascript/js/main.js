const amount=document.getElementById("amount");

const percent=document.getElementById("percent");

const discount=document.getElementById("discount");

const btn=document.getElementById("calculateBtn");

const reset=document.getElementById("reset");
// mouseup mousedown keyup keydown

// devambrose 
btn.addEventListener("click",function(){
    console.log("amount",amount.value);

    console.log("percent",percent.value);

    let flPercent=parseFloat(percent.value);
    //add if condition to check percent < 100

    //DRY Dont repeat yourself

    if(flPercent >= 100){

        alert("hey the percent should be less than 100");
        return;
    }

    let disc=parseFloat(amount.value) * 
            (flPercent/100);

    console.log("discount",disc);

    discount.value=disc;

});



