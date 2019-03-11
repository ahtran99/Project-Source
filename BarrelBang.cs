using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBang : MonoBehaviour
{
    public AudioSource BangSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1)
        {
            BangSound.Play();
        }
    }
}
