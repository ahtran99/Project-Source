using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene01 : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject TheUI;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(4.5f);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        yield return new WaitForSeconds(4.5f);
        ThePlayer.SetActive(true);
        TheUI.SetActive(true);
        Cam2.SetActive(false);
    }
}
