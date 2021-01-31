﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour {

    public string otherTag;
    public Vector3 startPostion;
    public Vector3 startRotation;

    void Start() {
        startPostion = gameObject.transform.position;
        startRotation = gameObject.transform.eulerAngles;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == otherTag) {
            GameManager.Instance.score++;
            ResetPosition();
        } else if (other.gameObject.tag == "Danger") {
            if(GameManager.Instance.score > 0){
                GameManager.Instance.score--;
            }
            ResetPosition();
        }
    }

    void ResetPosition() {
        gameObject.transform.position = startPostion;
        gameObject.transform.eulerAngles = startRotation;
        // GameManager.Instance.collided = false;
    }
}
