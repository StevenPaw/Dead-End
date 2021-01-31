using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartVideoOnTrigger : MonoBehaviour
{
    public VideoPlayer vp;
    public MeshRenderer mr;

    private void OnTriggerEnter(Collider other)
    {
        mr.enabled = true;
        vp.Play();
        Destroy(gameObject);
    }
}
