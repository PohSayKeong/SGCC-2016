using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerScript : MonoBehaviour {
    public float timeLeft;
    public Text timeText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeft = Mathf.Round(timeLeft * 100f) / 100f;
        timeText.text = "Time Left: " + timeLeft.ToString();
	
	}
}
