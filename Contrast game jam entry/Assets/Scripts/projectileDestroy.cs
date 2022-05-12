using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject.FindWithTag("projectile"));
    }
}
