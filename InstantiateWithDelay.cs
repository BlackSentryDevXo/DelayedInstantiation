using UnityEngine.Events;
using UnityEngine;
using System;
using System.Collections.Generic;

public class InstantiateWithDelay : MonoBehaviour
{
    // Number of objects to spawn
    public int numberOfObjects = 1;
    // Number of seconds between each spawn
    public float SpawnDelay = .1f;
    // reference to keep prefabs (this is a basic reference, change it to fit your game needs)
    public GameObject[] prefabs;
 
    void Start() {
        StartCoroutine(SpawnObjects(numberOfObjects, SpawnDelay));
    }
 
    IEnumerator SpawnObjects(int count, float delay) {
        for (int i = 0; i < count; i++) {

            var prefab = enemyPrefabs[count];
            Instantiate(prefab, GenerateSpawnPosition(), prefab.transorm.rotation);
            yield return new WaitForSeconds(delay);
            
        }
    }
}