using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class checkListScript : MonoBehaviour {

    public Image checkList;
    public Sprite change;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ChangeImage();

    }

    public void ChangeImage()
    {
        if (GameObject.Find("Toothbrush").GetComponent<gameStart>().brushInPlay)
        {
            change = Resources.Load<Sprite>("checkLists/toothbrushCheckList");
        }

        else if (GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeInPlay)
        {
            change = Resources.Load<Sprite>("checkLists/bicycleCheckList");
        }

        else if (GameObject.Find("Charger").GetComponent<chargerScript>().chargerInPlay)
        {
            change = Resources.Load<Sprite>("checkLists/chargerCheckList");
        }

        checkList.sprite = change;
    }

}
