using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "projectile")
        {
            Destroy(other);
        }
    }
}
