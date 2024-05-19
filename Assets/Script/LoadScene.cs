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
}
