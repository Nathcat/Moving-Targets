using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval;
    public float moveSpeed;
    public float startDelay;

    public void StartSpawner() {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop() {
        yield return new WaitForSeconds(startDelay);

        while (true) {
            yield return new WaitForSeconds(spawnInterval);

            GameObject obj = Instantiate(targetPrefab, transform.position, transform.rotation);
            obj.GetComponent<MovingTarget>().moveSpeed = moveSpeed;
        }
    }
}
