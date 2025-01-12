using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    List<GameObject> messagesList = new List<GameObject>();
    void Start()
    {
        foreach (GameObject message in messagesList)
        {
            messagesList.Add(message);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
