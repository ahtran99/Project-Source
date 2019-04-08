using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A002Door : MonoBehaviour
{
    public GameObject theSubs;
    public AudioSource doorVoice;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(SpiderSub());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator SpiderSub()
    {
        doorVoice.Play();
        theSubs.GetComponent<Text>().text = "I'll need a gun before I go in here.";
        yield return new WaitForSeconds(2);
        theSubs.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
