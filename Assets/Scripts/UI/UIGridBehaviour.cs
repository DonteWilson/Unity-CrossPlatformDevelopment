using System.Linq;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;

public class UIGridBehaviour : MonoBehaviour
{
    public Item item;
    private GameObject firstAvailable;
    public List<Transform> children = new List<Transform>();
    public int Capacity = 16;
    public int numItems = 0;

    public GameObject FirstAvailable
    {
        get
        {
            children.ForEach(child => Debug.Log("Child: " + child.name));
            firstAvailable = children.First(c => c.childCount <= 0 && c.parent == transform).gameObject;

            return firstAvailable;
        }
    }

    public void SetItem()
    {
        var newtotal = numItems + 1;

        if (newtotal >= Capacity)
            return;
        var parent = FirstAvailable;
        var itemgo = new GameObject("Item", typeof(Image));

        itemgo.transform.SetParent(FirstAvailable.transform);
        var source = itemgo.GetComponent<RectTransform>();
        source.Stretch();
        numItems++;

    }

}
public static void Stretch(this RectTransform source)
{
    source.anchorMin = new Vector2(0, 0);
    source.anchorMax = new Vector2(1, 1);
    source.pivot = new Vector2(.5f, .5f);
    source.offsetMax = Vector2.zero;
    source.offsetMin = Vector2.zero;
    source.localScale = new Vector3(1, 1, 1);
}


#if UNITY_EDITOR
[CustomEditor(typeof(UIGridBehaviour))]
public class InspectorUIGridBehaviour : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var mytarget = target as UIGridBehaviour;
        if(GUILayout.Button("Set Item"))
            mytarget.SetItem();
    }
}
#endif
