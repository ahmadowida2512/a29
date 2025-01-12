using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        delegate void MathOperation();
        void Start()
        {
            Action logMessage = () => Debug.Log("the is Action");
            logMessage();
            Func<int, int> Square = (Number) => Number * Number;
            Debug.Log($"Square of 5:{Square(5)}");
            Predicate<int> isEven = (number) => number % 2 == 0;
            Debug.Log($"Is 10 even? {isEven(10)}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}