using System;
using UnityEngine;

namespace Assignment29
{
    public class BasicScript : MonoBehaviour
    {
    // Start is called before the first frame update
        void Start()
        {
            var myName = "John";
            var number = 25;
            var isMarried = false;    
            int[] numbers = {1, 2, 3, 4, 5};


            Debug.Log($"The number {number} " + (number%2 == 0 ? "is even" : "is odd"));
            Debug.Log("Date " + DateTime.Now);
            Debug.Log("Day " + DateTime.Now.Day);
            Debug.Log("Time " + DateTime.Now.TimeOfDay);

            CustomObject customObject1 = new (1, "John");
            CustomObject customObject2 = new (1, "John");
            CustomObject customObject3 = new (1, "Khader");
            
            print(customObject1.ToString());
            print($"Are the objects equal? (1,2) {customObject1.Equals(customObject2)}");
            print($"Are the objects equal? (1,3) {customObject1.Equals(customObject3)}");
            print($"Are the objects equal? (==) (1,2) {customObject1 == customObject2}");
            print($"Are the objects equal? (==) (1,3) {customObject1 == customObject3}");
            print($"Are the objects equal? (!=) (1,2) {customObject1 != customObject2}");
            print($"Are the objects equal? (!=) (1,3) {customObject1 != customObject3}");


            Debug.Log("Sum of [1,2,3,4,5] = " + Utilities.Add(1, 2, 3, 4, 5));
            Debug.Log("Hello".RepeatString(3));
        }
    }

}
