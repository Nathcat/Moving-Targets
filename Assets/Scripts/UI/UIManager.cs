using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Slider speedSlider;
    public Slider scaleSlider;
    public TargetSpawner[] targetSpawners;
    public GameObject startMenu;
    
    public void OnStartButtonClicked() {
        foreach (TargetSpawner spawner in targetSpawners) {
            spawner.moveSpeed *= speedSlider.value;
            spawner.spawnScale = new Vector3(scaleSlider.value, scaleSlider.value, scaleSlider.value);
            spawner.StartSpawner();
        }

        startMenu.SetActive(false);
    }

    public void OnStopButtonClicked() {
        SceneManager.LoadScene("TargetScene");
    }
}
