using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loser : MonoBehaviour
{
    [SerializeField]
    public int catches;
    [SerializeField]
    public GameObject lossPanel;
    [SerializeField]
    public bool bulean;
    [SerializeField]
    public int catchedID;
    [SerializeField]
    public GameObject tapButton;
    [SerializeField]
    public void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Block"||col.gameObject.tag == "Post")
        {
            catchedID = col.gameObject.GetComponent<Kid>().ID;
            if (catchedID >= 1)
            {
                lossPanel.SetActive(true);
                tapButton.SetActive(false);
            }
        }
    }
    public void Lose()
    {
        Application.LoadLevel(0);
    }
}
