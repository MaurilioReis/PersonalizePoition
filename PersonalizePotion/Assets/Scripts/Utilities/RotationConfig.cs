using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationConfig : MonoBehaviour
{
    [Header("ConfigRotation")]
    public bool Active = true;
    public float speed;
    public Vector3 dirRotation;


    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            transform.Rotate(dirRotation * speed);
        }
    }
}
