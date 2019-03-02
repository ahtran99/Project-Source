using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunReloading : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public GunFire GunComponent;

	// Use this for initialization
	void Start () {
        GunComponent = GetComponent<GunFire>();
	}
	
	// Update is called once per frame
	void Update () {
        ClipCount = GlobalAmmo.LoadedAmmo;
        ReserveCount = GlobalAmmo.CurrentAmmo;

        if (ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 10 - ClipCount;
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    GlobalAmmo.LoadedAmmo += ReserveCount;
                    GlobalAmmo.CurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.LoadedAmmo += ReloadAvailable;
                    GlobalAmmo.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());
        }
	}

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        GunComponent.enabled = true;
    }

    void ActionReload()
    {
        GunComponent.enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
        ReloadSound.Play();
        GetComponent<Animation>().Play("HandgunReload");
    }
}
