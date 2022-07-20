using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [Header("Sphère 360° actuelle")]
    [Tooltip("On désactive la sphère actuelle")]
    public GameObject currentSphere;
    [Header("Sphère 360° suivante")]
    [Tooltip("On active la sphère suivante")]
    public GameObject nextSphere;

    [Header("Sphère Mini-carte actuelle")]
    [Tooltip("On active la sphère actuelle")]
    public GameObject currentMap;
    [Header("Sphère Mini-carte suivante")]
    [Tooltip("On active la sphère suivante")]
    public GameObject nextMap;

    [Header("Vérification")]
    [Tooltip("On vérifie si le GameObject a été cliquer dessus")]
    public bool condition = true;

    private void OnMouseDown()
    {
        if (condition == true)
        {
            Hide();
            condition = false;
        }
        else
        {
            Show();
            condition = true;
        }
    }
        public void Hide()
        {
            currentMap.gameObject.SetActive(false);
            currentSphere.gameObject.SetActive(false);
            nextSphere.gameObject.SetActive(true);
            nextMap.gameObject.SetActive(true);

        }

        public void Show()
        {
            currentMap.gameObject.SetActive(true);
            currentSphere.gameObject.SetActive(true);
            nextSphere.gameObject.SetActive(false);
            nextMap.gameObject.SetActive(false);
    }
    }
    

