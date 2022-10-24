using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    [Header("List with tags 'boule'")]
    [Tooltip("On Liste les GameObjects qui ont pour tag 'boule' au lancement")]
    public GameObject[] hotspots;
    void Start()
    {
        Application.targetFrameRate = 30;

        hotspots = GameObject.FindGameObjectsWithTag("boule");
        for (int i = 0; i < hotspots.Length; i++)
        {
            hotspots[i].SetActive(false);
        } 
    }
}
