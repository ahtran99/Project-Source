using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int EnemyHealth = 10;
    public GameObject TheZombie;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

	void Update () {
		if (EnemyHealth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            TheZombie.GetComponent<Animation>().Play("Dying");
            EndZombie();
        }
	}

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
