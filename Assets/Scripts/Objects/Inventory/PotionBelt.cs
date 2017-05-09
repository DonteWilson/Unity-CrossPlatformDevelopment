using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBelt : MonoBehaviour
{

    public List<Potion> INSPECTOR_Potions;
    public List<Potion> RUNTIME_Potions;
    
    void Start()
    {
        foreach(var p in INSPECTOR_Potions)
        {
            var instantiatedPot = Instantiate(p);
            RUNTIME_Potions.Add(instantiatedPot);

            
        }


        //INSPECTOR_Potions.ForEach(p => RUNTIME_Potions.Add(Instantiate(p)) 
        RUNTIME_Potions.ForEach(rp => rp.Initialize(this.gameObject));
    }

    //public void Initialize(GameObject obj)
    //{
       
    //}

    
}
