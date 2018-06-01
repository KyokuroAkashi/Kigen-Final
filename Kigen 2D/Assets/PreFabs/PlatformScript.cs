using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public float velocidade = 30;
    public float angles = 1;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * velocidade * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-Vector3.forward * velocidade * Time.deltaTime);
        }


    }
}
