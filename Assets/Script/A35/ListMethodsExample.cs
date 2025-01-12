using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<int> Nmber = new List<int> { 3, 1, 4, 1, 5, 9 };
            List<int> number2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            Nmber.Sort((x, y) => y.CompareTo(x));//تعرض الارقام من الكبير الى الصغير
            string sortedList = string.Join(", ", Nmber);//تضيف القيم جاخل هذا السترينق
            Debug.Log(sortedList);//يطبع القيم 

            List<int> filteredNumbers = number2.FindAll(x => x % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}