using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptSpider : MonoBehaviour {

    public int EnemyHealth = 10;
    public GameObject TheSpider;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

	void Update () {
		if (EnemyHealth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            TheSpider.GetComponent<Animation>().Play("die");
            StartCoroutine(EndSpider());
            //EnemyHealth = 1;
        }
	}

    IEnumerator EndSpider()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
