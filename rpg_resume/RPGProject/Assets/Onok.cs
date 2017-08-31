using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onok : MonoBehaviour {

    // Use this for initialization
    public void OnOK()
    {
        PlayerPrefs.SetInt("DataFromSave", 0);//加载进2.2
        Application.LoadLevel(2);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
