using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool isSignedIn) =>
        {
            if (isSignedIn)
            {
                Debug.Log("Se logueo correctamente");
                
                UnlockTrophy();
            }
            else
            {
                Debug.Log("Ocurrió un error");
            }
        });
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(233076, (trophyResult) =>
        {
            SceneManager.LoadScene("SampleScene");
        });
    }
}
