using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectible : MonoBehaviour
{
    [Header("Activate/Destroy objects on Contact")]
    [SerializeField]
    private GameObject[] objectsToDestroy;

    public GameObject pointToTeleportTo;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < objectsToDestroy.Length; i++)
        {
            GameObject.Destroy(objectsToDestroy[i]);
        }

        if (pointToTeleportTo != null)
        {
            other.GetComponent<Transform>().position = pointToTeleportTo.GetComponent<Transform>().position;
        }
        
        Destroy(gameObject);
    }
}
