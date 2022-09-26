using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        Destroy(target.gameObject);
    }
}
