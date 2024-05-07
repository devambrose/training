let units=[
    {unit:"SMA 102",mark:40,semester:1},
    {unit:"SMA 103",mark:56,semester:2},
];

const tblBodyData=document.getElementById("tblBodyData");



document.getElementById('unitSubmit').addEventListener('submit',function(e){
    e.preventDefault();

    var formEl = document.forms.unitSubmit;

    var formData = new FormData(formEl);

    var unit = formData.get('unit');

    var mark =formData.get('mark');

    var semester=formData.get('semester');

    console.log("before-add",units);

    units.push({unit,mark:mark,semester:semester});

    renderTable()

});

function renderTable(){
    let tableString='';

    for(let i=0;i<units.length;i++){
        tableString+=`<tr>
                            <td scope="row">${i+1}</td>
                            <td>${units[i].unit}</td>
                            <td>${units[i].mark}</td>
                            <td>${units[i].semester}</td>
                            <td> 
                            <small class='text-red text-underline delete' 
                            id='${i}' data-id='${i}' >delete
                            </small>
                            </td>
                        </tr>`;
        
    }

    tblBodyData.innerHTML=tableString;


    deleteInjector();

}



function deleteInjector(){
    let deleteUnit= document.getElementsByClassName("delete");

    for(let i=0;i<deleteUnit.length;i++){

        console.log("delete-rel",i);

        deleteUnit[i].addEventListener('click',function(){
            let index = deleteUnit[i].getAttribute("id")

            index=parseInt(index);

            units[index]="";

            let newArray=[];

            units.forEach(unit=>{

                if(unit !=""){
                    newArray.push(unit);
                }
            });

            units=newArray;

            renderTable()

        });
    }
}

renderTable();