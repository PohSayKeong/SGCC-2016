using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class tabScript : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;
    private bool inside;
    private bool outside;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (outside)
        {
            Vector3 targetPos = (new Vector3(43f, 7f, -99f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }

        if (inside)
        {
            Vector3 targetPos = (new Vector3(251.5f, 7f, -99f));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }

    public void tabClick () {
        if (transform.position.x >= 53)
        {
            outside = true;
            inside = false;
        }

        if (transform.position.x < 53)
        {
            inside = true;
            outside = false;
        }
    }

}
