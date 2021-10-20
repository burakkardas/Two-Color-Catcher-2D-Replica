using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private GameObject[] _balls;
    [SerializeField] private float _minX, _maxX;
    [SerializeField] private float _time;
    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

    private IEnumerator Spawn() {
        while(game_Manager._isDead == false) {
            yield return new WaitForSeconds(_time);
            GameObject _newBall = Instantiate(_balls[Random.Range(0, _balls.Length)]);
            
            _newBall.transform.position = new Vector2(
                Random.Range(_minX, _maxX),
                transform.position.y
            );
            _newBall.transform.SetParent(transform);
        }
    }
}
