using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ARSceneSwitch : MonoBehaviour
{
        public string arSceneName = "AR_Vuforia"; // Name deiner AR-Szene

        public void SwitchToARScene()
        {
            // Vuforia aktivieren
            VuforiaBehaviour.Instance.enabled = true; 

            // AR-Szene laden
            SceneManager.LoadScene(arSceneName); 
        }
}
