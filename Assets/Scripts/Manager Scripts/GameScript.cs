using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private bool executing = false;

    void Start()
    {
        MoveScript.boost = 0f;
    }
       
    void Update()
    {
        if (ScoreScript.died)
        {
            StopCoroutine("SpaceshipFaster");
        }

        if (executing == false)
        {
            StartCoroutine("SpaceshipFaster");
        }
    }

    IEnumerator SpaceshipFaster()
    {
        executing = true;

        yield return new WaitForSeconds(2f);

        executing = false;

        MoveScript.boost += 0.2f;
    }
}
