using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDog : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            print("clicked :" + gameObject.name);
            GameManager.Instance.SelectedDogBreed = gameObject.name;
        }
    }
}
