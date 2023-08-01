using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] string selectedDogBreed;
    public string SelectedDogBreed 
    { 
        get { return selectedDogBreed; } 
        set { selectedDogBreed = value; } 
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance) 
        { 
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
