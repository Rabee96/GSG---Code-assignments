using UnityEngine;

namespace Assignment29
{
    public class Animal
    {
        virtual public void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public void Move()
        {
            Debug.Log("Animal is moving");
        }
    }
}

