using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController pedalKanan;
    public PaddleController pedalKiri;

    // Trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            pedalKanan.ActivatePUPaddleSpeedUp();
            pedalKiri.ActivatePUPaddleSpeedUp();
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
