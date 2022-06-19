using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULengthUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddle;

    // Trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddle.ActivatePULengthUp();
            manager.RemovePowerUp(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
