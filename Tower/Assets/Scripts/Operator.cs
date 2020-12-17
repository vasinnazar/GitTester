using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    [SerializeField]
    public bool[] forsorted;
    [SerializeField]
    public bool[] forlined;
    [SerializeField]
    public GameObject forSelector;
    [SerializeField]
    public GameObject forAdding;
    bool sortedResult;
    bool linedResult;
    int _levelid;
    // Update is called once per frame
    void Update()
    {
        forSelector = GameObject.Find("Parent");
        forAdding = GameObject.Find("Anchor");
        _levelid = forSelector.GetComponent<Selector>().levelID;
        sortedResult = forsorted[_levelid];
        linedResult = forlined[_levelid];
        forSelector.GetComponent<Selector>().assorted = sortedResult;
        forAdding.GetComponent<AddingSelector>().lined = linedResult;
    }
}
