using UnityEngine;
using System.Collections;

public class brushScript : MonoBehaviour {

    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;
    private bool movingInPlace = false;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (movingInPlace)
        {
            Vector3 targetPos = (new Vector3(300f, -1.1f, -191.1f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
            if (transform.position.x > 230f)
            {
                transform.localScale = new Vector3(0.1f, 0f, 0f);
            }
        }
    }

    public void brushDie()
    {
        movingInPlace = true;
    }
}
