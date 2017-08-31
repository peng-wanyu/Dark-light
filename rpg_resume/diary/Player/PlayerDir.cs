using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDir : MonoBehaviour {
    public GameObject effect_click_prefab;
    public Vector3 targetPosition = Vector3.zero;
    private bool isMoving = false;
    // Update is called once per frame
    void Start() {
        targetPosition = transform.position;
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            bool isCollider = Physics.Raycast(ray, out hitInfo);
            if (isCollider && hitInfo.collider.tag == Tags.ground) {
                isMoving = true;
                ShowClickEffect(hitInfo.point);
                LookAtTarget(hitInfo.point);
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            isMoving = false;
        }
        if (isMoving) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            bool isCollider = Physics.Raycast(ray, out hitInfo);
            if (isCollider && hitInfo.collider.tag == Tags.ground) {
                LookAtTarget(hitInfo.point);
            }
        }
    }
    void ShowClickEffect(Vector3 hitPoint){
        hitPoint = new Vector3(hitPoint.x, hitPoint.y + 0.1f, hitPoint.z);
        GameObject.Instantiate(effect_click_prefab, hitPoint, Quaternion.identity);
    }
    void LookAtTarget(Vector3 hitPoint) {
        targetPosition = hitPoint;
        targetPosition = new Vector3(targetPosition.x,transform.position.y, targetPosition.z);
        this.transform.LookAt(targetPosition);
    }
}
