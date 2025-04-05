using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject targetObject;
        GameObject jokerObject;
        Light lightObject;

        void OnEnable()
        {
            print("GameObject Enabled");
            targetObject = GameObject.Find("TargetObject");
            jokerObject = GameObject.FindWithTag("Joker");
            lightObject = FindObjectOfType<Light>();

            if (targetObject == null)
            {
                print("No TargetObject found.");
            }else
            {
                print($"Found object by name: {targetObject.name}");
            }
            if (jokerObject == null)
            {
                print("No Joker object found.");
            }else
            {
                print($"Found object by tag: {jokerObject.name}");
            }
            if (lightObject == null)
            {
                print("No Light object found.");
            }else
            {
                print($"Found object of type Light:: {lightObject.name}");
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            print("Game started!");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }
    }
}

