using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    //static gör så att allt e detsamma för alla
    public static int Score;
    public int amount = 1;
    public float spinspeed = 180;

    // de här gör så att mynten snurrar.
    private void Update()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {// detta gör så att när spelaren vidrör ett mynt så förstörs det och din score går upp med 1.
        if (collision.tag == "Player")
        {
            Coin.Score += amount;
            Destroy(gameObject);
        }
    }
}
