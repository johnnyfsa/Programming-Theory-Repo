using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkBtn : MonoBehaviour
{
    private Dog dogBehaviour;
    [SerializeField] GameUiHandler gameUiHandler;

    public void TalkPressed()
    {
        if (GameManager.Instance.SelectedDog)
        {
            dogBehaviour = GameManager.Instance.SelectedDog.GetComponent<Dog>();

            gameUiHandler.Dogspeech = dogBehaviour.Talk();
        }

    }
}
