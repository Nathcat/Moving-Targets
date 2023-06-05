using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval;
    public float moveSpeed;
    public Vector3 spawnScale;
    public float startDelay;

    public void StartSpawner() {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop() {
        yield return new WaitForSeconds(startDelay);

        while (true) {
            yield return new WaitForSeconds(spawnInterval);

            GameObject obj = Instantiate(targetPrefab, transform.position, transform.rotation);
            obj.transform.localScale = spawnScale;
            obj.GetComponent<MovingTarget>().moveSpeed = moveSpeed;
        }
    }
}
