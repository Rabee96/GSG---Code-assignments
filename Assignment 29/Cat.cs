
using UnityEngine;

namespace Assignment29
{
    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow");
        }

        new public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }
}
