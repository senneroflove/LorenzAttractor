using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    
    private const float rotateSpeed = 0.04f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 centerPos = Vector3.zero;
        transform.RotateAround(centerPos, Vector3.up, rotateSpeed);
    }
}
