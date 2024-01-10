using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public TextMeshProUGUI scoreText;

    [SerializeField] private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
        
        // If the Instance var is empty
        if (Instance == null)
        {
            Instance = this;
        } else {

            Debug.LogWarning("There cannot be more than one instance of GameManager!");
            Destroy(gameObject);
        }
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

}
