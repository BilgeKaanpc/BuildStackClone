using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        score = -1;
        text = GetComponent<TMPro.TextMeshProUGUI>();
        GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;
        
    }
    private void OnDestroy()
    {
        GameManager.OnCubeSpawned -= GameManager_OnCubeSpawned;
    }
    private void GameManager_OnCubeSpawned (){

        score++;
        text.text = "Score: " + score;
    }
}
