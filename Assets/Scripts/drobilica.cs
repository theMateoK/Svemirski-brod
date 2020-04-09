using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drobilica : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colision)
    {
        Destroy(colision.gameObject);
    }
}
