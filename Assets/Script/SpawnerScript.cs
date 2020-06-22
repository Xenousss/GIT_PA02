using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] spawnobject;

    float PositionX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        PositionX = Random.Range(4, -4f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        Instantiate(spawnobject[Random.Range(0, 4)], transform.position, transform.rotation);
    }
}
