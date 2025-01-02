using System;
using UnityEngine;

public class ExceptionHandlingScript : MonoBehaviour
{
    void Start()
    {
        // Declare variables
        int playerScore = 100;
        int D = 0; // Intentionally set to 0 to simulate division by zero

        try
        {
            // Log attempting message
            Debug.Log(" score multiplier");

            // Attempt division
            int totalScore = playerScore / D;

            // Log result (this line won't be reached if an exception occurs)
            Debug.Log($"Total Score: {totalScore}");
        }
        catch (DivideByZeroException)
        {
            // Log error message
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            // Log cleanup message
            Debug.Log("Score  complete. Cleaning up resources.");
        }
    }
}
