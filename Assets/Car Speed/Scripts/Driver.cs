using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.01f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float speedUp = 20f;
    [SerializeField] float slowDown = 10f;
    float steerAmount;
    float moveAmount;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmount);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = speedUp;
        }

    }
   
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowDown;
    }
}
