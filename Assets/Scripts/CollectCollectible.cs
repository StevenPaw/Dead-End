using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectible : MonoBehaviour
{
    [Header("Activate/Destroy objects on Contact")]
    [SerializeField]
    private GameObject[] objectsToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < objectsToDestroy.Length; i++)
        {
            GameObject.Destroy(objectsToDestroy[i]);
        }
        
        Destroy(gameObject);
    }
}
