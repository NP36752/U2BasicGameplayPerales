using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAngryAnimals : MonoBehaviour
{   public float spawnRangeZ = 20;
    public float spawnPosX = -23;
    private float startDelay = 3;
    private float spawnInterval = 10f;
    public GameObject[] angryAnimalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAngryAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAngryAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeZ, spawnRangeZ), 0, spawnPosX);
        int animalIndex = Random.Range(0, angryAnimalPrefabs.Length);
        Instantiate(angryAnimalPrefabs[animalIndex], spawnPos,
            angryAnimalPrefabs[animalIndex].transform.rotation);
    }




}
