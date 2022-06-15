using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour //ABSTRACTION
{
    public string Name //ENCAPSULATION
    {
        get { return Name; }
        protected set 
        {
            if (value.Length < 2 | value.Length > 10)
            {
                Debug.Log("The name is too long or too short.");
            }
            else
            {
                Name = value;
            }
        }
    }
    public abstract void Jump();
    public abstract void Talk();
    public abstract void Walk();
    public abstract void SpecialMoviment();
}
