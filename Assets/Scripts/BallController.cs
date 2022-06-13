using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Ball speed
    public Vector2 speed;

    // Rigidbody2D
    private Rigidbody2D rig;

    // Reset ball position
    public Vector2 resetPosition;
    public void ResetBall()
    {
        transform.position = new Vector3 (resetPosition.x, resetPosition.y, 2);
    }

    // PU Speed up
    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
