using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour {
    public GameObject[] characterPrefabs;
    public UIInput nameInput;
    private GameObject[] characterGameObjects;
    private int selectedIndex = 0;
    private int length;
	// Use this for initialization
	void Start () {
        length = characterPrefabs.Length;
        characterGameObjects = new GameObject[length];
        for (int i = 0; i < length; i++) {
            characterGameObjects[i] = GameObject.Instantiate(characterPrefabs[i], transform.position, transform.rotation) as GameObject;
        }
        UpdateCharacterShow();
	}
	
	// Update is called once per frame
	void UpdateCharacterShow () {
        characterGameObjects[selectedIndex].SetActive(true);
        for (int i = 0; i < length; i++) {
            if (i != selectedIndex) {
                characterGameObjects[i].SetActive(false);
            }
        }
	}
    public void OnNetButtonClick() {
        selectedIndex++;
        selectedIndex %= length;
        UpdateCharacterShow();
    }
    public void OnPrevButtonClick() {
        selectedIndex--;
        if (selectedIndex == -1) {
            selectedIndex = length - 1;
        }
        UpdateCharacterShow();
    }
    public void OnOkButtonClick() {
        PlayerPrefs.SetInt("SelectdeCharacterIndex", selectedIndex);
        PlayerPrefs.SetString("name", nameInput.value);
        Application.LoadLevel(2);
        
    }
}
