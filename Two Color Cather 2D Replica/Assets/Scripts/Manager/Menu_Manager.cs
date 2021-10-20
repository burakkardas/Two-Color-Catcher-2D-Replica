using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu_Manager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void PlayGame() {
        SceneManager.LoadScene(1);
    }
}
