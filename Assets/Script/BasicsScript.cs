using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {


        void Start()
        {
            var x = 7;
            var y = "ahmad";
            var z = true;
            string num = (x % 2 == 0) ? "even" : "odd";
            string message = $"The number {x} is {num}.";
            Debug.Log(message);
            Debug.Log($" Date: {System.DateTime.Now.ToString("yyyy-MM-dd")}");
            Debug.Log($" Time: {System.DateTime.Now.ToString("HH:mm:ss")}");
            Debug.Log($" Day: {System.DateTime.Now.DayOfWeek}");

        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}