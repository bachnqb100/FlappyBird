using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {        
        scoreText.text = Fish.score.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
        
    public void Menu()
    {
        //TODO: load Menu game
        SceneManager.LoadScene("Menu");
    }
}
