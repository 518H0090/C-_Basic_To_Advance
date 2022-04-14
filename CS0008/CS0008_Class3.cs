using System;

namespace CS0008_Class3
{
    public class TestGetSet
    {
        // get set with field / variable 
        public string nameValue { set; get; }

        // get set with default attribute

        public int ageValue { set; get; }

        public TestGetSet(string name = "", int age = 20)
        {
            nameValue = name;
            ageValue = age;
        }
    }
}