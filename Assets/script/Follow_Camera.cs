using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Camera : MonoBehaviour
{
    public Transform playertransform;
    public float offset;
    
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = playertransform.position.z + offset;
        transform.position = camerapos;
    }
}
