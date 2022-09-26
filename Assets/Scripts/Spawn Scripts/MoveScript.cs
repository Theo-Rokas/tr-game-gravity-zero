using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Transform pos;

    public static float boost;

    void Start()
    {
        pos = GetComponent<Transform>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (this.gameObject.tag == "Spaceship")
        {
            if (boost >= 5)
                boost = 5;

            transform.Translate(-Time.deltaTime * (15f + boost), 0, 0, pos);
        }
        else
            if (this.gameObject.transform.rotation.z == 0f)
            transform.Translate(-Time.deltaTime * 10f, 0, 0, pos);
        else
            transform.Translate(Time.deltaTime * 5f, 0, 0, pos);
    }
}
