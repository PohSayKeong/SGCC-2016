using UnityEngine;
using System.Collections;

public class bikeScript : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;
    public float smoothOutTime;
    public bool bikeInPlay = false;
    private bool movingInPlace = false;
    private bool movingOut = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (movingInPlace)
        {
            Vector3 targetPos = (new Vector3(-12.4f, -5f, -189.5f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
            bikeInPlay = true;
        }
        
        if (movingOut)
        {
            Vector3 targetPos = (new Vector3(250f, -1.1f, -191.1f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothOutTime);
            if (transform.position.x > 220f)
            {
                transform.localScale = new Vector3(0.1f, 0f, 0f);
                bikeInPlay = false;
            }
        }

    }

    public void bikeLive(){
        movingInPlace = true;
    }

    public void bikeDie()
    {
        movingOut = true;
    }
}
