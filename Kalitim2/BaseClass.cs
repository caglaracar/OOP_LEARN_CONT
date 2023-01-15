using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim2
{
    internal class BaseClass
    {
        public static int counterID = 0;
        
        public BaseClass()
        {
            counterID++;
            _id = counterID;
        }
        private int _id;
        public int Id
        { 
            get 
            {
                return _id; 
            } 
             set 
            {
                
            } 
        } //*
        public string Barcode { get; set; }//*
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UpdaterUser { get; set; }
        public bool Deleted { get; set; }

      


    }
}
