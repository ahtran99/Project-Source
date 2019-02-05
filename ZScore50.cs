using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore50 : MonoBehaviour
{
    public GameObject ObjectiveComplete;

    void DeductPoints(int DamageAmount)
    {
        GlobalScore.CurrentScore += 50;
        ObjectiveComplete.SetActive(true);
    }
}
