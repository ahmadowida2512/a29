using UnityEngine;
namespace Assignment29
{
    public class Test : MonoBehaviour
    {
      
        void Start()
        {
CustomObject obj1 = new CustomObject(1, "Ahmad");
  print(obj1);
    CustomObject obj2 = new CustomObject(2, "abd");
        print($"Are obj1 and obj2 equal? {obj1 == obj2}");
        print($"Are obj1 and obj2 not equal? {obj1 != obj2}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}