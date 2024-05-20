//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
fun main() {

    val hondaFit : Car = Car("Honda","Fit",2023)

    val hondaStream :Honda = Honda("Stream")

    hondaStream.speeding(60)

    hondaStream.speeding()

   // hondaStream.decelerating()

    hondaStream.toString()

    hondaStream.setSeats(10)

    println(hondaStream.toString())

    var fielder:Car =Toyota("Fielder Hybrid")

    fielder.speeding()

    fielder.setSeats(5)

}

/**
 * interfaces
 */

interface ICar{
    fun speeding()
    fun decelerating()
    fun showSpeed()
}

class Hyundai():ICar{
    override fun speeding() {

    }

    override fun decelerating() {
        TODO("Not yet implemented")
    }

    override fun showSpeed() {
        TODO("Not yet implemented")
    }
}

open class Car(val model:String, val title: String, val yearOfMake :Int=2023){

    var speed:Int =0

    private var seats:Int =7

    override fun toString(): String {

        return "title : $model $title  year:$yearOfMake seats : $seats Speed : $speed";
    }

    fun speeding(lclSpeed:Int=0){

        if(lclSpeed !=0)
            speed=lclSpeed
        else
            speed ++
    }


    fun decelerating(){
        speed --
    }



    fun getSeats():Int{
        return seats
    }

    fun setSeats(seat:Int){
        seats=seat
    }
}

class Honda ( title: String, yearOfMake :Int=2023):Car("Honda",title,yearOfMake),ICar {
    override fun speeding() {
        TODO("Not yet implemented")
    }

    override fun showSpeed() {
        TODO("Not yet implemented")
    }
}

class Toyota(title: String):Car("toyota",title,1996)