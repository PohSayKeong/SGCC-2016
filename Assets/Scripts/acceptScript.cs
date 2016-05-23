using UnityEngine;
using System.Collections;

public class acceptScript : MonoBehaviour {

    [HideInInspector]public static bool brushAccept;
    [HideInInspector]public static bool bikeAccept;
    [HideInInspector]public static bool chargerAccept;

    public void Check()
    {
        GameObject.Find("Timer").GetComponent<timerScript>().resetTime();
        if (GameObject.Find("Toothbrush").GetComponent<gameStart>().brushInPlay) {
            brushAccept = true;
            GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeLive();
            GameObject.Find("Toothbrush").GetComponent<brushScript>().brushDie();
            
        } 

        if (GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeInPlay)
        {
            bikeAccept = true;
            GameObject.Find("Charger").GetComponent<chargerScript>().chargerLive();
            GameObject.Find("Bicycle").GetComponent<bikeScript>().bikeDie();
        }

        if (GameObject.Find("Charger").GetComponent<chargerScript>().chargerInPlay)
        {
            chargerAccept = true;
            GameObject.Find("EventSystem").GetComponent<screenSwitch>().endGame();
        }
    }
    
}
