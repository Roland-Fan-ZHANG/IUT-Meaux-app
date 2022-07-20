using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject currentSphere;
    public GameObject nextSphere;

    public GameObject currentMap;
    public GameObject nextMap;

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
    

