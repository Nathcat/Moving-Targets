using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider slider;
    public TargetSpawner[] targetSpawners;
    
    public void OnStartButtonClicked() {
        foreach (TargetSpawner spawner in targetSpawners) {
            spawner.moveSpeed *= slider.value;
            spawner.StartSpawner();
        }

        gameObject.SetActive(false);
    }
}
