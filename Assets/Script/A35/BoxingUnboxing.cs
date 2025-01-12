using UnityEngine;
namespace Assignment35
{
  public class BoxingUnboxing : MonoBehaviour
  {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      int health = 25;
      object Uhealth = health;
      int UNhealth = (int)Uhealth;
      UNhealth = UNhealth - 12;
      Debug.Log($"The original int value. {health}");
      Debug.Log($"The boxed value. {Uhealth}");
      Debug.Log($"The unboxed and modified value. {UNhealth}");
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}