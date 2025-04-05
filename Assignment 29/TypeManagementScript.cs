using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Cat cat = new();
            Animal animal = new();
            animal.MakeSound();
            animal.Move();

            cat.MakeSound();
            cat.Move();

            (animal as Cat)?.MakeSound();
            (animal as Cat)?.Move();

            List<ICanFight> characters = new() {new Cat(), new Warrior()};

            foreach (var character in characters)
            {
                character.Attack();

                if(character is Cat)
                    Debug.Log("The object is a Cat.");
                if(character is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }
}

