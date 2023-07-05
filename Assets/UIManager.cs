using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public Label kansLabel;
    public dronemanager manager;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        kansLabel = root.Q<Label>("Chance");
    }

    // Update is called once per frame
    void Update()
    {
        kansLabel.text = "" + (manager.aantalTouwMis * 1f / (manager.aantalTouwRaak+ manager.aantalTouwMis) * 1f);
    }
}
