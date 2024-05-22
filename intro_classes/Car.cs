using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_classes
{
    public class Car
    {
      
        public int id;
       
        private string name;
       
        public string description;

        protected int speed;

        public Car()
        { //
             
        }

        public Car(string name) { 
            this.name = name;
        }

        public Car(int id,string name,string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public void setName(string name)//setter
        {
            this.name =name;
        }

        public string getName() //getter 
        {
            return this.name;
        }

        public int getSpeed()
        {
            return this.speed;
        }

        
    }
}
