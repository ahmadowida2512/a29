using UnityEngine;

public class UtilitiesTester : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         int sum = Utilities.Add(1, 2, 3, 4, 5); // Example numbers
        Debug.Log($"The sum of the numbers is: {sum}");
        string rString = "Ahmad".RepeatString(3);
        Debug.Log($"Repeated string: {rString}");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
