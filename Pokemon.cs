using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WillPart3
{
    public class Pokemon:IClassModel
    {
        public int Id { get; set; }
        public string DexNumber { get; set; }    
        public string Name { get; set; }    
        public string Form { get; set; }
        public string Type { get; set; }    
        public string Type2 { get; set; }   
        public int Total { get; set; }   // dont forget this and everything under it is ints and needs to be converted 
        public int HP { get; set; }  
        public int Attack { get; set; }  
        public int Defense { get; set; } 
        public int SpecialAttack { get; set; }   
        public int SpecialDefense { get; set;}
        public int Speed { get; set; }   
        public int Generation { get; set; }

    }
}
