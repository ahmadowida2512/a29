using System;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float speed = 0.1f;
    public GameObject canvas;
    List<string> nameOfStudentsFolder = new List<string>();
    [SerializeField] private Sprite[] imgSprites;


    //[SerializeField] private RaycastHit hit;
    //bool checkClicked = false;
    void Start()
    {
        player = gameObject.transform;
        GetImageFilesName();
       
    }


    void Update()
    {
        DetectMouseClick();
        MovePlayer();

    }

    private void DetectMouseClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            try
            {
                bool checkClicked = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 1000f);

                if (checkClicked == true)
                {
                    foreach (string nameOfStudent in nameOfStudentsFolder)
                    {
                        if (hit.transform.gameObject.tag == nameOfStudent)
                        {
                            // Debug.Log($"Message of {nameOfStudent}");

                            canvas.GetComponentInChildren<Image>().sprite = imgSprites[0];
                            // Resources.Load<Sprite>(nameOfStudent);

                            canvas.SetActive(true);
                        }
                    }
                }
                else
                {
                    canvas.SetActive(false);
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.Translate(Vector3.right * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.Translate(Vector3.left * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.Translate(Vector3.forward * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.Translate(Vector3.back * speed, Space.Self);
        }
    }

    private void GetImageFilesName()
    {
        string path = Application.dataPath + "/Adventure Time Proto/Rozan/SharedImages/NameOfStudents";
        if (Directory.Exists(path))
        {
            // Get all files in the directory
            string[] files = Directory.GetFiles(path, "*.*");

            foreach (var file in files)
            {
                // Filter for .png and .jpeg files
                string extension = Path.GetExtension(file).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg") // Include .jpg for compatibility
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    nameOfStudentsFolder.Add(fileName);
                }
            }
        }
        else
        {
            Debug.LogError("Folder does not exist: " + path);
        }
    }


}