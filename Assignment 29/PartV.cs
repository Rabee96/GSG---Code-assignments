using System;
using UnityEngine;

public class PartV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerScore = 100;
        int divider = 0;

        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore/divider;
            Debug.Log("The new player score is : " + totalScore);
        }
        catch (DivideByZeroException error)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            throw new DivideByZeroException("Error division by zero",error);
        }finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }
}
