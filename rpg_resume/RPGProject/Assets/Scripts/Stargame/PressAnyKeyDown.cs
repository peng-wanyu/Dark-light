using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyKeyDown : MonoBehaviour {
    private bool isAnyKeyDown = false;
    public GameObject buttonContainer;
	// Use this for initialization
	void Start () {
        buttonContainer = this.transform.parent.Find("buttonContainer").gameObject;
	}
	void Update() {
        if (isAnyKeyDown == false) {
            if (Input.anyKey)
            {
                ShowButton();
            }
        }
    }
    void ShowButton() {
        buttonContainer.SetActive(true); 
        this.gameObject.SetActive(false);
        isAnyKeyDown = true;
    }
}
