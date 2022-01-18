using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetwewnSpawn;
    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        maxX = 3.5f;
        minX = 3f;
        maxY = 2.5f;
        minY = -0.1f;
        timeBetwewnSpawn = 2.5f; //digunakan untuk memanggil obstacle setiap 2.5 detik
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetwewnSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
