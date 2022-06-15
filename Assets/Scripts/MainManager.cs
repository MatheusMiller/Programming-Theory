using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dog dog = gameObject.AddComponent<Dog>();
        Cat cat = gameObject.AddComponent<Cat>();   
        dog.SpecialMoviment();
        cat.SpecialMoviment();
    }
}
