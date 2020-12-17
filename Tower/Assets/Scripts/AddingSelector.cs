using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingSelector : MonoBehaviour
{
    [SerializeField]
    public Sprite[] blockIma;
    [SerializeField]
    public Sprite[] sprites;
    [SerializeField]
    public int gamesElement;
    [SerializeField]
    public Sprite imag;
    [SerializeField]
    public Sprite randomimage;
    [SerializeField]
    public int min;
    [SerializeField]
    public int max;
    [SerializeField]
    public int ran;
    [SerializeField]
    public int tosend;
    [SerializeField]
    public List<Sprite> list = new List<Sprite>();
    [SerializeField]
    public bool lined;
    [SerializeField]
    public int inner = 0;
    void Start()
    {
        Sort();
    }
    public void Sort()
    {
        ran = Random.Range(min, max);
        if(lined == false)
        randomimage = blockIma[Random.Range(0, blockIma.Length)];
        if(lined == true)
        randomimage = sprites[inner];
        int i = 0;
        do {
            i++;
            list.Add(randomimage);
        } while ( i < ran);
        inner++;
    }
    void Update()
    {
        
        if (ran > 0 && list.Count <= gamesElement)
        {
            Sort();
        }

        imag = list[tosend];
    }
}
