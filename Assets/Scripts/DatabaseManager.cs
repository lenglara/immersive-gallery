using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DatabaseManager : MonoBehaviour
{
    public string API_URL = "https://wizard-world-api.herokuapp.com/Elixirs";
    
    void Start()
    {
        // asynchrone Aktivierung der Methode
        StartCoroutine(GetDataFromAPI());
    }

    private IEnumerator GetDataFromAPI()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(API_URL);
        yield return webRequest.SendWebRequest();
        
        // if successful
        if (webRequest.result == UnityWebRequest.Result.Success)
        {
            string resultJSON = webRequest.downloadHandler.text;
            ParseJSON(resultJSON);
        }
        else
        {
            Debug.Log(": Error: " + webRequest.error);
        }
    }

    private void ParseJSON(string result)
    {
        DatabaseWizards database = JsonUtility.FromJson<DatabaseWizards>(result);
        Debug.Log(": Result: " + database.name);
    }
}

