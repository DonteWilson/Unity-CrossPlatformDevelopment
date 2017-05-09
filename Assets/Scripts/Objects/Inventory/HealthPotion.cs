using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potions/HealthPotion")]
public class HealthPotion : Potion  
{
    public override void Execute()
    {
        Consume(_owner);
    }

    public override void Consume(GameObject owner)
    {
        owner.GetComponent<PlayerBehaviour>();
    }

    public override void Initialize(GameObject obj)
    {
        _owner = obj;
    }
}
