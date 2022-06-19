using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Decide right paddle
    public bool isRight;

    // adjust speed
    public int speed;

    // input keys
    public KeyCode upKey;
    public KeyCode downKey;

    // rigidbody
    private Rigidbody2D rig;

    // Add paddle game object
    public GameObject pedalKanan;
    public GameObject pedalKiri;
    public GameObject bola;

    // Timer var
    private float timeRemainingLength = 5;
    private float timeRemainingSpeed = 5;

    // Check length up
    private bool lengthUpKananIsActive = false;
    private bool lengthUpKiriIsActive = false;

    // Check speed up
    private bool speedUpKananIsActive = false;
    private bool speedUpKiriIsActive = false;


    //PU speed up
    public void ActivatePUPaddleSpeedUp()
    {
        // PU speed up pedal kanan
        if (speedUpKananIsActive == false && bola.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            speedUpKananIsActive = true;
        }
        else if (speedUpKananIsActive == true && bola.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            timeRemainingSpeed = 5;
        }
        // PU speed up pedal kiri
        if (speedUpKiriIsActive == false && bola.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            speedUpKiriIsActive = true;
        }
        else if (speedUpKiriIsActive == true && bola.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            timeRemainingSpeed = 5;
        }
    }

    // PU length Up
    public void ActivatePULengthUp()
    {
        // PU length up pedal kanan
        if (lengthUpKananIsActive == false && bola.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            pedalKanan.transform.localScale += new Vector3(0, pedalKanan.transform.localScale.y, 0);
            lengthUpKananIsActive = true;
        }
        if (lengthUpKananIsActive == true && bola.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            timeRemainingLength = 5;
        }
        // PU length up pedal kiri
        if (lengthUpKiriIsActive == false && bola.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            pedalKiri.transform.localScale += new Vector3(0, pedalKiri.transform.localScale.y, 0);
            lengthUpKiriIsActive = true;
        }
        if (lengthUpKiriIsActive == true && bola.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            timeRemainingLength = 5;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the paddle
        MoveObject(GetInput());
        // Timer for PU length up
        if (lengthUpKananIsActive == true)
        {
            if (timeRemainingLength > 0)
            {
                timeRemainingLength -= Time.deltaTime;
            }
            else
            {
                float kananShort = pedalKanan.transform.localScale.y / 2;
                pedalKanan.transform.localScale -= new Vector3(0, kananShort, 0);
                timeRemainingLength = 5;
                lengthUpKananIsActive = false;
            }
        }
        if (lengthUpKiriIsActive == true)
        {
            if (timeRemainingLength > 0)
            {
                timeRemainingLength -= Time.deltaTime;
            }
            else
            {
                float kiriShort = pedalKiri.transform.localScale.y / 2;
                pedalKiri.transform.localScale -= new Vector3(0, kiriShort, 0);
                timeRemainingLength = 5;
                lengthUpKiriIsActive = false;
            }
        }
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    // Debug velocity
    private void MoveObject(Vector2 movement)
    {
        
        rig.velocity = movement;
        // Apply speed up to right paddle
        if (speedUpKananIsActive == true && isRight == true)
        {
            rig.velocity *= 2;
            // Timer
            if (timeRemainingSpeed > 0)
            {
                timeRemainingSpeed -= Time.deltaTime;
            }
            else
            {
                rig.velocity /= 2;
                timeRemainingSpeed = 5;
                speedUpKananIsActive = false;
            }
        }
        // Apply speed up to left paddle
        if (speedUpKiriIsActive == true && isRight == false)
        {
            rig.velocity *= 2;
            // Timer
            if (timeRemainingSpeed > 0)
            {
                timeRemainingSpeed -= Time.deltaTime;
            }
            else
            {
                rig.velocity /= 2;
                timeRemainingSpeed = 5;
                speedUpKiriIsActive = false;
            }
        }
        Debug.Log("TEST: " + movement);
    }
}
