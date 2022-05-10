using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public Vector3 RotateVal;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateVal * Time.deltaTime);
    }
}
