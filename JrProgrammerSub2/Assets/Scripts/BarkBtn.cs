using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarkBtn : MonoBehaviour
{
    private Dog dogBehaviour;
    [SerializeField] GameUiHandler gameUiHandler;
    public void BarkPressed() 
    {
        if (GameManager.Instance.SelectedDog) 
        {
            dogBehaviour  = GameManager.Instance.SelectedDog.GetComponent<Dog>();
            //POLYMORPHISM
            gameUiHandler.Dogspeech = dogBehaviour.Bark();
        }
        
    }
}
