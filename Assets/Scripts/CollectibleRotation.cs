using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRotation : MonoBehaviour
{
    [SerializeField] [Range(0f,5f)] private float rotateForce = 0;
    private Transform go;
    
    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        go.Rotate(new Vector3(0,rotateForce,0),Space.World);
    }
}
