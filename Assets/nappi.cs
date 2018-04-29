using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nappi : MonoBehaviour {

    public GameObject panel;
    private bool state = false;

    public void ShowHide()
    {
        state = !state;
        panel.SetActive(state);
    }
}
