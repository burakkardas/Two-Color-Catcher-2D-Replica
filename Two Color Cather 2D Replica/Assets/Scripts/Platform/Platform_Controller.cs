using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Controller : MonoBehaviour
{
    void Update()
    {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
        ));

        _mousePos.x = Mathf.Clamp(_mousePos.x, -2.05f, 2.05f);

        transform.position = new Vector3(
            _mousePos.x,
            -3.5f,
            0f
        );
    }
}
