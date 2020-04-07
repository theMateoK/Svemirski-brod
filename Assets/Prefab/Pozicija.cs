using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozicija : MonoBehaviour
{
    // Start is called before the first frame update
    void onDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 1);
    }
   
}
