using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject tarprefab;
    public float zspawn=0;
    public float tileLength = 122f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile()
    {
        Instantiate(tarprefab, transform.forward * zspawn, transform.rotation);
        zspawn = zspawn + tileLength;
    }
}
