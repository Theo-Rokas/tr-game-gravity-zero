using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject crystalBlue, crystalGold, crystalGreen, crystalIcy, crystalPurple, crystalRed,
                      spaceShip,
                      spawner;

    private float minY = -3f, maxY = 3f;

    private bool executing = false;

    void Update()
    {
        if (ScoreScript.died)
        {
            StopCoroutine("RandomSpawn");
        }

        if (executing == false)
        {
            StartCoroutine("RandomSpawn");
        }
    }

    IEnumerator RandomSpawn()
    {
        executing = true;

        yield return new WaitForSeconds(2f);

        int random = Random.Range(0, 6);

        Vector3 pos = transform.position;

        GameObject newSpawn = null;

        if (spawner.tag == "SpawnerDown")
        {
            if (random == 0)
                newSpawn = Instantiate(crystalBlue, pos, Quaternion.identity);
            else if (random == 1)
                newSpawn = Instantiate(crystalGold, pos, Quaternion.identity);
            else if (random == 2)
                newSpawn = Instantiate(crystalGreen, pos, Quaternion.identity);
            else if (random == 3)
                newSpawn = Instantiate(crystalIcy, pos, Quaternion.identity);
            else if (random == 4)
                newSpawn = Instantiate(crystalPurple, pos, Quaternion.identity);
            else if (random == 5)
                newSpawn = Instantiate(crystalRed, pos, Quaternion.identity);            
        }
        else if (spawner.tag == "SpawnerUp")
        {
            if (random == 0)
            { 
                newSpawn = Instantiate(crystalBlue, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
            else if (random == 1)
            {
                newSpawn = Instantiate(crystalGold, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
            else if (random == 2)
            {
                newSpawn = Instantiate(crystalGreen, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
            else if (random == 3)
            {
                newSpawn = Instantiate(crystalIcy, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
            else if (random == 4)
            {
                newSpawn = Instantiate(crystalPurple, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
            else if (random == 5)
            {
                newSpawn = Instantiate(crystalRed, pos, Quaternion.identity);
                newSpawn.transform.Rotate(pos.x, pos.y, pos.z + 180);
            }
        }
        else if(spawner.tag == "SpaceshipSpawner")
        {
            SoundScript.instance.SpaceshipSound();

            pos.y = Random.Range(minY, maxY);

            newSpawn = Instantiate(spaceShip, pos, Quaternion.identity);
        }

        if (newSpawn)
            newSpawn.transform.parent = transform;

        executing = false;
    }    
}
