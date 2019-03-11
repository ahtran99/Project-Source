using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreakyDoorOpen : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject TheDoor;
    public AudioSource CreakSound;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerPrefs.GetFloat("TheCasting");
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.GetComponent<Text>().text = "Open Door";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                GetComponent<BoxCollider>().enabled = true;
                ActionDisplay.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("OpenDoorAnim");
                CreakSound.Play();
            }
        }
    }

    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
    }
}
