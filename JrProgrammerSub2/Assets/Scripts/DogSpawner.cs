using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.SelectedDog) 
        {
            Instantiate(GameManager.Instance.SelectedDog, new Vector3(-0.119999997f, 0, -2.8000002f), Quaternion.Euler(0, 180, 0));
        }
       
    }

}
