using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] string selectedDogBreed;
    [SerializeField] List<GameObject> dogs;
    [SerializeField] GameObject selectedDog;

    public GameObject SelectedDog 
    {
        get { return selectedDog; }
        set { selectedDog = value; }
    }

    public List<GameObject> Dogs 
    {
        get { return dogs; }
        set { dogs = value; }
    }

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
