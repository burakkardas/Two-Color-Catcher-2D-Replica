using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Piece : MonoBehaviour
{
    private Game_Manager game_Manager;
    [SerializeField] private string _currentColor;
    void Start()
    {
        game_Manager = GameObject.FindObjectOfType<Game_Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == _currentColor) {
            game_Manager._score++;
            Destroy(other.gameObject);
        }
        else {
            game_Manager.GameOver();
        }
    }
}
