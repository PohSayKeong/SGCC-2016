using UnityEngine;
using System.Collections;

public class rejectScript : MonoBehaviour {

    public void Check()
    {
        GameObject.Find("Timer").GetComponent<timerScript>().resetTime();
        if (GameObject.Find("Toothbrush").GetComponent<gameStart>().brushInPlay)
        {
            acceptScript.brushAccept = false;
            GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeLive();
            GameObject.Find("Toothbrush").GetComponent<brushScript>().brushDie();

        }

        if (GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeInPlay)
        {
            acceptScript.bikeAccept = false;
            GameObject.Find("Charger").GetComponent<chargerScript>().chargerLive();
            GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeDie();
        }

        if (GameObject.Find("Charger").GetComponent<chargerScript>().chargerInPlay)
        {
            acceptScript.chargerAccept = false;
            GameObject.Find("EventSystem").GetComponent<screenSwitch>().endGame();
        }
    }
}
