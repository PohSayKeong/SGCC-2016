using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clipboardscript : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void tabClick() {
        Vector3 targetPos = (new Vector3(-153f, -117f, 0f));
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }

    public void startGame()
    {

        SceneManager.LoadScene("Main");
    }
}
