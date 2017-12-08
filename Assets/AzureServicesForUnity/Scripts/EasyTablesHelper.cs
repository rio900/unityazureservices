using AzureServicesForUnity.AppService;
using AzureServicesForUnity.Shared;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTablesHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InsetClick()
    {
        Highscore score = new Highscore();
        score.playername = "dimitris";
        score.score = UnityEngine.Random.Range(10, 100);
        EasyTablesClient.Instance.Insert(score, insertResponse =>
        {
            if (insertResponse.Status == CallBackResult.Success)
            {
                string result = "Insert completed";
                if (Globals.DebugFlag) Debug.Log(result);
            }
            else
            {
            }
        });
    }
}
