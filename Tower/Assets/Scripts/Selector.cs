using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{

    [SerializeField]
    public int[] games;
    [SerializeField]
    public Sprite[] blockIma;
    [SerializeField]
    public Sprite[] roofIma;
    [SerializeField]
    public Sprite[] doorIma;
    [SerializeField]
    public int levelblocks;
    [SerializeField]
    public Sprite blo;
    [SerializeField]
    public Sprite roo;
    [SerializeField]
    public Sprite doo;
    [SerializeField]
    public Sprite image;
    [SerializeField]
    public int levelID = 0;
    [SerializeField]
    public int gamesElement;
    [SerializeField]
    public GameObject chip;
    [SerializeField]
    public bool assorted;
    [SerializeField]
    public GameObject adder;
    [SerializeField]
    Selector provider;
    void Awake()
    {
        levelID = PlayerPrefs.GetInt("L");
        provider = GetComponent<Selector>();
        for (int i = 0; i <= games.Length; i++)
        {
            if (levelID == i)
            {
                levelblocks = games[i];
                gamesElement = games[i];
                blo = blockIma[i];
                roo = roofIma[i];
                doo = doorIma[i];
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        adder = GameObject.Find("Anchor");
        chip = GameObject.Find("Parent/Child(Clone)");
      if(levelblocks == gamesElement)
        {
            image = doo;
        } 
         if(levelblocks == 1)
        {
            image = roo;
            levelblocks--;
        }
        adder.GetComponent<AddingSelector>().gamesElement = gamesElement;
    }
    public void Assigner()
    {
      
            if (assorted == true)
            {
                image = adder.GetComponent<AddingSelector>().imag;
            }
            else if (assorted == false)
            {
                image = blo;
            }
            levelblocks--;
            adder.GetComponent<AddingSelector>().tosend++;
    }
}
