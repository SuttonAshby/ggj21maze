using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set; }

	private void Awake () {
        //Initiate singleton
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
	}
    public Camera camera1;
    public Camera camera2;
    public bool charOneActive = true;
    public float charSpeed = 0.025f;
    public Text scoreText;
    public int score;
    public bool collided = false;

    void Start() {
        scoreText.text = "Score: 0";
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update() {
        scoreText.text = "Score: " + score.ToString();

        if (Input.GetKeyUp(KeyCode.Space)) {
            swapCamera();
            charOneActive = !charOneActive;   
        } else if (Input.GetKeyUp(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    void swapCamera(){
        camera1.enabled = !camera1.enabled;
        camera2.enabled = !camera2.enabled; 
        camera1.GetComponent<AudioListener>().enabled = !camera1.GetComponent<AudioListener>().enabled;
        camera2.GetComponent<AudioListener>().enabled = !camera2.GetComponent<AudioListener>().enabled;
    }
}
