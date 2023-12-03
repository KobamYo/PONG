using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSurface : MonoBehaviour
{
    public float bounceStrength;
    public AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        AudioSource audioSource = collision.gameObject.GetComponent<AudioSource>();
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;

            ball.AddForce(-normal * this.bounceStrength);

            ball.AudioSource();
        }
    }
}
