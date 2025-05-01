using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    public class Mammal
    {
        public string name = string.Empty;
        public string hairColor = string.Empty;
        public string eyeColor = string.Empty;
        int weight = 0;


        public Mammal()
        {

        }


        public Mammal(string mammalName)
        {
            name = mammalName;  
        }



    }


}
