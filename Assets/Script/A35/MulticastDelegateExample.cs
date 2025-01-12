using UnityEngine;
namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        delegate void MathOperation(int number);
        void Start()
        {
            MathOperation O = null;
            O += Duble;
            O += Squar;
            O += Cube;
            int samp = 5;
            O(samp);
        }

        void Duble(int number) => Debug.Log($" Duble of {number} is {number * 2}");
        void Squar(int number) => Debug.Log($" Squar of {number} is {number * number}");
        void Cube(int number) => Debug.Log($" Cube of {number} is {number * number * number}");
    }
}