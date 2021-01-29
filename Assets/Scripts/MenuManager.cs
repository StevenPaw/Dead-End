using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void onStart()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void onQuit()
    {
        Application.Quit();
        Debug.Log("Application is now quitting");
    }
}
