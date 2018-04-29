using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nappi : MonoBehaviour {

    public GameObject panel;
    int counter;

    public void ShowHide()
    {
        counter++;
        if (counter % 2 == 0)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);

        }
    }
}
