using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyKeyDown : MonoBehaviour {
    private bool isAnyKeyDown = false;//私有boo变量isAnyKeyDown
    public GameObject buttonContainer;//全局GameObject buttonContainer
                                      // Use this for initialization
    void Start () {
        buttonContainer = this.transform.parent.Find("buttonContainer").gameObject;//确认按钮
	}
	void Update() {
        if (isAnyKeyDown == false) {
            if (Input.anyKey)
            {
                ShowButton();//展现ShowButton
            }
        }
    }
    void ShowButton() {
        buttonContainer.SetActive(true); 
        this.gameObject.SetActive(false);
        isAnyKeyDown = true;//赋bool
    }
}
