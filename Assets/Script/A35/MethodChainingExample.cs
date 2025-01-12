using UnityEngine;
namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
        }

        public MethodChainingExample SetPosition(Vector3 position)
        {
            transform.position = position;
            return this;
        }
        public MethodChainingExample SetRotation(Vector3 rotaion)
        {
            transform.rotation = Quaternion.Euler(rotaion);
            return this;
        }
        public MethodChainingExample SetScale(Vector3 scale)
        {
            transform.localScale = scale;
            return this;
        }


    }
}