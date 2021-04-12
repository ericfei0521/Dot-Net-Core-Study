using System;

namespace MyApplication
{
    class Car :Vehicle //inherite the propterties from Vehicle
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }
}