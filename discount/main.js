//getElementById
//getElementsByTagsName("p")("div")("li")("ul")
//getElementsByClassName

//OOP programming 
/**
 * come up with an object from our day to day life and show examples using JS classes
 * 
 * Html -template
 * Css -Style template
 * JS - Give's you interactivity
 * JSON -> 
 * 
 * 
 */


class Car{
  title
  make
  model 
  year
}

let mazdaDemio = {
  title:"Mazda Demio",
  make:" Mazda",
  year:2023,
  model:"Mazda"
};

let cars=[
  mazdaDemio,
  {title:"Axela 1",make:'Mazda',year:1967,model:"mazda"},
  {title:"Axela 2",make:'Mazda',year:1967,model:"mazda"},
  {title:"Axela 3",make:'Mazda',year:1967,model:"mazda"},
];

function showCarsTable(){
  const tblCars= document.getElementById("tblCars");

  let tblString="";

  for(let x=0;x< cars.length;x++){
    tblString =tblString+ `<tr>
                    <th scope="row">${x+1}</th>
                    <td>${cars[x].title}</td>
                    <td>${cars[x].make}</td>
                    <td>${cars[x].year}</td>
                    <td>${cars[x].model}</td>
                  </tr>`;   
  }
  // .value
  tblCars.innerHTML=tblString;  
}

showCarsTable();


const make=document.getElementById('make');

const color=document.getElementById('color');

const title=document.getElementById('title');

const year=document.getElementById('year');

function clearFormElements(){
  make.value="";
  color.value="";
  title.value="";
  year.value="";
}

document.getElementById('btnSaveChanges').addEventListener('click',function(){

  let newCar={
    title:title.value,
    make:make.value,
    year:year.value,
    model:color.value
  };
  cars.push(newCar);

  showCarsTable();

  clearFormElements();
})