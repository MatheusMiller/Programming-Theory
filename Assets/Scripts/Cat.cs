using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{
    public override void Jump() //POLYMORPHISM
    {
        Debug.Log("The cat jump 20 units upwards");
    }

    public override void SpecialMoviment() //POLYMORPHISM
    {
        //ABSTRACTION
        Sneak();
        Jump();
        CatchBird();
        Talk();
    }

    public override void Talk() //POLYMORPHISM
    {
        Debug.Log("Meow!");
    }

    public override void Walk() //POLYMORPHISM
    {
        Debug.Log("The cat walks");
    }

    public void Sneak()
    {
        Debug.Log("The cat is sneaking");
    }

    public void CatchBird()
    {
        Debug.Log("The cat catched the bird");
    }

}
