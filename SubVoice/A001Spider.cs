using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A001Spider : MonoBehaviour
{
    public GameObject theSubs;
    public AudioSource spiderVoice;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(SpiderSub());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator SpiderSub()
    {
        spiderVoice.Play();
        theSubs.GetComponent<Text>().text = "Oh crap, looks like there are some spiders over there!";
        yield return new WaitForSeconds(2);
        theSubs.GetComponent<Text>().text = "";
    }
}
