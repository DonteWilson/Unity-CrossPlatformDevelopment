using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

    private BackPack backpack;

    private int index;

    private IExecutable currentItem;

    [SerializeField]
    private GameObject itemHolder;
    private void Start()
    {
        this.index = 0;

        if (this.backpack == null)
            this.backpack = FindObjectOfType<BackPack>();

        foreach (var item in this.backpack.ReferenceItems)
        {
            var instance = Instantiate(item);
            this.backpack.InventoryItems.Add(instance);
            item.Initialize(this.itemHolder);
        }

        if (this.currentItem == null)
            this.currentItem = this.backpack.InventoryItems[0];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.currentItem.Execute();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.PreviousItem();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.NextItem();
        }
    }

    private void NextItem()
    {
        this.index++;
        if (this.index == this.backpack.InventoryItems.Count)
            this.index = 0;

        this.currentItem = this.backpack.InventoryItems[this.index];
    }

    private void PreviousItem()
    {
        this.index--;
        if (this.index < 0)
            this.index = this.backpack.InventoryItems.Count - 1;

        this.currentItem = this.backpack.InventoryItems[this.index];
    }
}
