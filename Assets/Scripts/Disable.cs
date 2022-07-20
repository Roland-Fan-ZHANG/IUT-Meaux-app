using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public GameObject[] boule;
    void Start()
    {
        boule = GameObject.FindGameObjectsWithTag("boule");
        for (int i = 0; i < boule.Length; i++)
        {
            boule[i].SetActive(false);
        } 
    }
}
