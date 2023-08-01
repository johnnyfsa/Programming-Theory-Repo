using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDog : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            print("clicked :" + gameObject.name);
            GameManager.Instance.SelectedDogBreed = gameObject.name;
            string dog = GameManager.Instance.SelectedDogBreed;
            for (int i = 0; i < GameManager.Instance.Dogs.Count; i++)
            {
                if (dog == GameManager.Instance.Dogs[i].name)
                { 
                    GameManager.Instance.SelectedDog = GameManager.Instance.Dogs[i];
                }
            }
            SceneManager.LoadScene(0);
        }
    }
}
