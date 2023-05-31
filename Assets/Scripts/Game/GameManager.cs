using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnInterval = 5.0f;
    public GameObject targetPrefab;
    public Vector3 spawnLocation;

    void Start() {
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine() {
        while (true) {
            yield return new WaitForSeconds(spawnInterval);

            Instantiate(targetPrefab, spawnLocation, new Quaternion(0, 0, 0, 0));
        }
    }
}
