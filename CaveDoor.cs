using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CaveDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public AudioSource creakSound;
    public GameObject fadeOutScreen;
    public int takenGun;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerPrefs.GetFloat("TheCasting");
        takenGun = PlayerPrefs.GetInt("TakeAGun");
    }

    private void OnMouseOver()
    {
        if (takenGun == 1)
        {
            if (TheDistance <= 3)
            {
                ActionDisplay.GetComponent<Text>().text = "Enter Cave";
                ActionDisplay.SetActive(true);
            }
            if (Input.GetButtonDown("Action"))
            {
                if (TheDistance <= 3)
                {
                    creakSound.Play();
                    fadeOutScreen.SetActive(true);
                    StartCoroutine(EnterTheCave());
                    GetComponent<BoxCollider>().enabled = true;
                    ActionDisplay.SetActive(false);
                }
            }
        }
    }

    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
    }

    IEnumerator EnterTheCave()
    {
        fadeOutScreen.GetComponent<Animation>().Play("FadeOutAnim");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(6);
    }
}
