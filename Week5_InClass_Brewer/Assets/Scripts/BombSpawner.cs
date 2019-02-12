using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bombPrefab;

    //Transform allows us to define the position of the spawn
    public Transform spawnLocation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //
            Instantiate(bombPrefab, spawnLocation.position, Quaternion.identity);
        }
    }
}
