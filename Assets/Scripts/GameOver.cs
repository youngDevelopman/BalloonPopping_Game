using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject gameOverMenu;
    
    private void Awake()
    {
        gameOverMenu.SetActive(false);
    }

    private void Update()
    {
        if (TextScript.IsGameOver)
        {
            gameOverMenu.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Collided");
        TextScript.IsGameOver = true;
        Destroy(other);
    }

    public void RestartGame()
    {
        TextScript.IsGameOver = false;
        TextScript.count = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
