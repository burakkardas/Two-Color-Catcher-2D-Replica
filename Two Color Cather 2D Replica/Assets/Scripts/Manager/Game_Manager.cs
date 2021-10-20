using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TMP_Text _scoreText;

    [Header("Gameplay")]
    public int _score = 0;
    public bool _isDead = false;
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        _scoreText.text = _score.ToString("00");
    }

    public void GameOver() {
        _isDead = true;
        Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
