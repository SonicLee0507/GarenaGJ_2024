using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    // Update is called once per frame
    public void Load(string scene)
    {
        Debug.Log("load scene");
        SceneManager.LoadScene(scene);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("End_1");
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("End_2");
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene("End_3");
        }
              
        if (Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene("End_4");
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene("End_5");
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            SceneManager.LoadScene("End_6");
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
            SceneManager.LoadScene("End_7");
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            SceneManager.LoadScene("End_8");
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            SceneManager.LoadScene("End_9");
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            SceneManager.LoadScene("End_10");
        }

    }
}
