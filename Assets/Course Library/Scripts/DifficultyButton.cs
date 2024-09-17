using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public int difficulty;

    private Button Button;

    private GameManager gameManager;

    private void Start()
    {
        Button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Button.onClick.AddListener(SetDifficulty);
    }

    private void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
