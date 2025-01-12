using UnityEngine;
namespace Assignment35 //مهممممممممممممم
{
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