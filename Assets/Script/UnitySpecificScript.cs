using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    private GameObject targetObject;
    private GameObject jokerObject;
    private Light lightObject;

    void OnEnable()
    {
        
        Debug.Log("GameObject Enabled");
    }

    [System.Obsolete]
    void Start()
    {
     
        Debug.Log("Game started!");

        
        targetObject = GameObject.Find("TargetObject");
        if (targetObject != null)
        {
            Debug.Log($"Found object by name: {targetObject.name}");
        }
        else
        {
            Debug.Log("No TargetObject found.");
        }

        
        jokerObject = GameObject.FindGameObjectWithTag("Joker");
        if (jokerObject != null)
        {
            Debug.Log($"Found object by tag: {jokerObject.name}");
        }
        else
        {
            Debug.Log("No Joker object found.");
        }

        lightObject = GameObject.FindObjectOfType<Light>();
        if (lightObject != null)
        {
            Debug.Log($"Found object of type Light: {lightObject.name}");
        }
        else
        {
            Debug.Log("No Light object found.");
        }
    }

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.D) && targetObject != null)
        {
            targetObject.SetActive(false);
            Debug.Log("TargetObject deactivated!");
        }
    }

    void OnDisable()
    {
        
        Debug.Log("GameObject Disabled");
    }
}
