using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour {

    public Canvas start;
    public Button exit;

	public void doQuit(){
        Debug.Log("Has quit");
        Application.Quit();
    }
}
