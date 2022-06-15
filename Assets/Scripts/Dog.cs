using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    public override void Jump() //POLYMORPHISM
    {
        Debug.Log("The dog jump 10 units upwards");
    }

    public override void SpecialMoviment() //POLYMORPHISM
    {
        //ABSTRACTION
        Roll();
        Jump();
        Talk();
        EatTreat();
    }

    public override void Talk() //POLYMORPHISM
    {
        Debug.Log("Au Au!");
    }

    public override void Walk() //POLYMORPHISM
    {
        Debug.Log("The dog walks");
    }

    public void Roll()
    {
        Debug.Log("The dog is rolling");
    }

    public void EatTreat()
    {
        Debug.Log("The dog is eating the treat");
    }
}
