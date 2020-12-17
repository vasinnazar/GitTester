using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public float sec2 = 0.4f;
    [SerializeField]
    public GameObject pref;
    [SerializeField]
    public GameObject findparent;
    [SerializeField]
    public GameObject findchild;
    [SerializeField]
    public int children = 0;
    [SerializeField]
    public bool nul = false;
    [SerializeField]
    public GameObject dies;
    [SerializeField]
    public Sprite door;
    [SerializeField]
    public int drop;
    [SerializeField]
    public Sprite closed;
    [SerializeField]
    public Sprite opened;
    [SerializeField]
    public GameObject hook;
    [SerializeField]
    public int made = 0;
    [SerializeField]
    public ProgressBar pb = new ProgressBar();
    // Start is called before the first frame update
    void Start()
    {   
        findparent = GameObject.Find("Parent");
        GameObject go = Instantiate(pref) as GameObject;
        go.transform.parent = this.transform;
        made++;
        hook.GetComponent<SpriteRenderer>().sprite = closed;
    }

    // Update is called once per frame
    void Update()
    {
        findchild = GameObject.Find("Parent/Child(Clone)");
        dies = GameObject.Find("Parent") as GameObject;
        door = dies.gameObject.GetComponent<Selector>().image;
      
        if (nul == false)
        {
            findchild.transform.position = this.transform.position;
            findchild.transform.rotation = this.transform.rotation;
            findchild.GetComponent<SpriteRenderer>().sprite = door;
        }
    }
    public void Call()
    {

        if(findchild != null)
        {
            nul = true;
            findchild.GetComponent<Kid>().Forward();
            hook.GetComponent<SpriteRenderer>().sprite = opened;
            Clone();
        }
    }
    public void Clone()
    {
        if(made < pb.forbck)
        StartCoroutine(Coroutine2());
    }
    private IEnumerator Coroutine2()
    {
        yield return new WaitForSeconds(sec2);
            print("niet");
        GameObject go = Instantiate(pref) as GameObject;
        go.transform.parent = this.transform;
        go.GetComponent<Kid>().ID = made;
        made++;
        hook.GetComponent<SpriteRenderer>().sprite = closed;
        nul = false;
    }
}
