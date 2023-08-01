using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUiHandler : MonoBehaviour
{
    [SerializeField] Text dogSpeech;
    public string Dogspeech
    {
        //ENCAPSULATION
        get { return dogSpeech.text; }
        set { dogSpeech.text = value; }
    }

    public void PreviousScene() 
    {
        SceneManager.LoadScene(1);
    }
   
}
