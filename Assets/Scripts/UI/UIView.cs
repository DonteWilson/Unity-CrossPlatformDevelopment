﻿using System.Collections.Generic;
using UnityEngine;

public class UIView : MonoBehaviour
{
    public GameObject Dimmer;

    public GameObject HealthBar;

    public GameObject Info;
    public GameObject Inventory;

    public GameObject InventoryGrid;

    public GameObject NPC;

    public GameObject PlayerChoices;

    public GameObject Root;

    private List<GameObject> ui_items;

    private void Awake()
    {
        if (ui_items == null) return;
        if (ui_items.Count > 0) ui_items.ForEach(go => go.SetActive(false));
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }
}