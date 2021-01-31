using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
    public bool isCharOne = false;
    void Update() {
        if(isCharOne && GameManager.Instance.charOneActive) {
            if (Input.GetKeyUp(KeyCode.D)) {   
                var angle = gameObject.transform.eulerAngles.y + 90;
                gameObject.transform.eulerAngles = new Vector3(0,angle,0);
            } else if(Input.GetKeyUp(KeyCode.A) ) {
                var angle = gameObject.transform.eulerAngles.y - 90;
                gameObject.transform.eulerAngles = new Vector3(0,angle,0);
            }
        } else if(!isCharOne && !GameManager.Instance.charOneActive) {
            if (Input.GetKeyUp(KeyCode.D)) {   
                var angle = gameObject.transform.eulerAngles.y + 90;
                gameObject.transform.eulerAngles = new Vector3(0,angle,0);
            } else if(Input.GetKeyUp(KeyCode.A) ) {
                var angle = gameObject.transform.eulerAngles.y - 90;
                gameObject.transform.eulerAngles = new Vector3(0,angle,0);
            }
        }
    }

    void FixedUpdate() {
        float horizontal = 0f;//Input.GetAxis("Horizontal");
        float vertical = 1f;//Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontal, 0f, vertical);
        

        gameObject.transform.Translate(Vector3.forward * GameManager.Instance.charSpeed);
        
    }
}
