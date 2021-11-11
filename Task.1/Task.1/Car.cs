using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList
{
    class Car
    {
        public string _brand;
        public string _model;
        public int _doorCount;
        public Car(string brand, string model, int doorCount)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
        }

        public string FullInfo() {
            return $"Brand : {_brand}, Model : {_model}, Doorcount : {_doorCount}";
        }
    }
}
