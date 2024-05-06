let items=[10,20,30,40];

items.reverse();

[40,30,20,10];
let sum =0 ;

for(let i=0;i<items.length;i++){

    sum += items[i];

    console.log("element "+i,items[i])
}

class Car{
    model;
    make;
    year;
    name;
    isDriving=false;

    constructor(name){
        this.name=name;
    }

    driving() {
        
        console.log(this.name,"this is driving")

        this.driving=true;

        setInterval(function(){
            if(this.isDriving){
                console.log("this is working")
            }
            
        },1000);
    }

    stopDriving(){
        this.driving=false;
    }
    toString(){
        return this.name+" "+this.model+" "+this.year;
    }
}

let mazdaDemio= new Car("Mazda Demio");

mazdaDemio.year="2022";

mazdaDemio.model="Mazda";

console.log(mazdaDemio.toString());


let jeepCheroke= new Car("Jeep Cherokeee");

console.log("the sum : ",sum);

// Vannila JS,
// React JS, Angular Js , Vue JS  


//arrays =[]

// forEach(),
// length , 
// pop , 
// reverse