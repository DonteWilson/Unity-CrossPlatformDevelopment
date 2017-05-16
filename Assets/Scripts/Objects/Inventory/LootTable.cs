using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LootTable")]
public class LootTable : ScriptableObject
{

    public List<DropItem> EnemyDrop = new List<DropItem>();
    public int Percentage;
    public GameObject _object;

    public DropItem ItemDrop()
    {

        SortbyPercentage();
        return null;
    }


    public void SortbyPercentage()
    {
        EnemyDrop = EnemyDrop.OrderBy(i => i.DropPercentage).ToList();
    }
}




#if UNITY_EDITOR


#endif
