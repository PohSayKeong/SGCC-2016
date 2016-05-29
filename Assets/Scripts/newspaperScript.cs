using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newspaperScript : MonoBehaviour {

    public Image Newspaper;
    public Sprite change;
    public bool multiple;
    public Text text;

	// Use this for initialization
	void Start () {

        if (acceptScript.brushAccept && acceptScript.chargerAccept)
        {
            change = Resources.Load<Sprite>("newspaper/toothbrush");
            multiple = true;
        }
        else if (acceptScript.brushAccept)
        {
            change = Resources.Load<Sprite>("newspaper/toothbrush");
            text.text = "Replay";
        }

        else if (acceptScript.chargerAccept)
        {
            change = Resources.Load<Sprite>("newspaper/charger");
            text.text = "Replay";
        }
        Newspaper.sprite = change;
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void Multiple()
    {
        if (multiple)
        {
            change = Resources.Load<Sprite>("newspaper/charger");
            text.text = "Replay";
            Newspaper.sprite = change;
            multiple = false;
        }

        else
        {
            SceneManager.LoadScene("Start");
        }
    }
}
