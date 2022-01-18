using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] objects;
    public float Wait;
    public float LessWait;
    public float MostWait;
    public float startWait;
    private bool stop = true;
    int randObjects;




    void Start()
    {
        StartCoroutine(objectSpawner());

    }


    void Update()
    {

        Wait = Random.Range(LessWait, MostWait);

    }

    IEnumerator objectSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (stop)
        {
            randObjects = Random.Range(0, objects.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-1.60f, 3), 0, 0);
            Instantiate(objects[randObjects], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(Wait);
        }
    }
}
