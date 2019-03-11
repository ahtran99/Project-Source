using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBlow : MonoBehaviour {

    public int EnemyHealth = 5;
    public GameObject TheBarrel;
    public GameObject FakeBarrel;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

	void Update () {
		if (EnemyHealth <= 0)
        {
            TheBarrel.SetActive(false);
            FakeBarrel.SetActive(true);
        }
	}
}
