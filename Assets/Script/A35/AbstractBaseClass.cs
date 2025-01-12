using UnityEngine;
namespace Assignment35
{
    public abstract class AbstractBaseClass : MonoBehaviour
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }

        public class DerivedClassExample : AbstractBaseClass
        {
            // Start is called once before the first execution of Update after the MonoBehaviour is created
            void Start()
            {
                PerformAction();
                PrintInfo();
            }

            public override void PerformAction()
            {
                Debug.Log("PerformAction is implemented in the derived class.");
            }

        }

    }
}