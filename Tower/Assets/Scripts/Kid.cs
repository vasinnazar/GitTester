using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour
{
    [SerializeField]
    public float sec = 0.1f;
    [SerializeField]
    public GameObject father;
    [SerializeField]
    public bool boolean;
    [SerializeField]
    public float down = 1.5f;
    [SerializeField]
    public float gravitynumber;
    [SerializeField]
    public float xPos;
    [SerializeField]
    public float colxPos;
    [SerializeField]
    public float dopscale = 0.15f;
    [SerializeField]
    public float gravitByCollBad = 3;
    [SerializeField]
    public float gravitByCollGood = 0;
    [SerializeField]
    public bool redhood = true;
    [SerializeField]
    public int ID; 
    // Start is called before the first frame update
    void Start()
    {
        father = GameObject.Find("Parent");
        this.transform.position = father.transform.position;
        this.transform.rotation = father.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(boolean == true)
        {
            transform.Translate(Vector3.up * -down);
        }
        xPos = transform.position.x;
    }
    public void Forward()
    {
        StartCoroutine(Coroutine());
    }
    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Post")
        {
        if (gameObject.tag == "Block")
            father.GetComponent<Spawner>().children++;
            gameObject.tag = "Post";
            boolean = false;
            GetComponent<BoxCollider2D>().isTrigger = false;
            GetComponent<Rigidbody2D>().gravityScale = gravitynumber;
        }
    }
    public void OnCollisionStay2D(Collision2D coll)
    {
            redhood = false;
        colxPos = coll.transform.position.x;
        if (xPos >= (colxPos - dopscale))
        {
            if (xPos <= (colxPos + dopscale))
            {
                this.GetComponent<Rigidbody2D>().gravityScale = gravitByCollGood;
            }
        }
        else
        {
            this.GetComponent<Rigidbody2D>().gravityScale = gravitByCollBad;
        }
    }

    private IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(sec);
        this.transform.parent = null;
        boolean = true;
    }
}
