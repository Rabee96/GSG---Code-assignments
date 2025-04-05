using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObject 
    {
        int _id;
        string _name;

        public CustomObject(int id, string name)
        {
            _id = id;
            _name = name;
        }


        public override string ToString()
        {
            return $"Object [ID: {_id}, Name: {_name}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CustomObject other = (CustomObject)obj;
            return _id == other._id && _name == other._name;
        }

            public static bool operator == (CustomObject customObject1,CustomObject customObject2){
                return customObject1.Equals(customObject2);
            } 
            public static bool operator != (CustomObject customObject1,CustomObject customObject2){
                return !(customObject1 == customObject2);
            }
    }
}