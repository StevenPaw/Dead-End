using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEndEvent : MonoBehaviour
{
    public double time;
    public double currentTime;
    // Use this for initialization
    void Start () {
 
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
    }
 
   
    // Update is called once per frame
    void Update () {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if (currentTime >= time -0.5) {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            Debug.Log("End Game");
        }
    }
}
