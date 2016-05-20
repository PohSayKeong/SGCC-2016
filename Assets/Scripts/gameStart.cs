using UnityEngine;
using System.Collections;

public class gameStart : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPos = (new Vector3(12.7f,-1.1f,-191.1f ));
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

    }
}
