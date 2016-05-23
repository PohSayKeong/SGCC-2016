using UnityEngine;
using System.Collections;

public class chargerScript : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;
    public float smoothOutTime;
    public bool chargerInPlay = false;
    private bool movingInPlace = false;
    private bool movingOut = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingInPlace)
        {
            Vector3 targetPos = (new Vector3(13.2f, -19f, -178f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
            chargerInPlay = true;
        }

        if (movingOut)
        {
            Vector3 targetPos = (new Vector3(250f, -1.1f, -191.1f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothOutTime);
            if (transform.position.x > 220f)
            {
                transform.localScale = new Vector3(0.1f, 0f, 0f);
            }
        }

    }

    public void chargerLive()
    {
        movingInPlace = true;
    }

    public void chargerDie()
    {
        movingOut = true;
    }
}
