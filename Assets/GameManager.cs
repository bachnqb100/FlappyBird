using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameOver gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Fish.Alived)
        {
            scoreText.text = "Score: " + Fish.score.ToString();
        } else
        {
            gameOver.gameObject.SetActive(true);
        }


    }

}
