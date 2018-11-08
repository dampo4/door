using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float maxDistance = 7;
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;
    public GameObject final;
    public GameObject door;
    Animator anim1;
    Animator anim2;
    Animator anim3;
    Animator anim4;
    Animator anim5;
    Animator anim6;
    Animator anim7;
    // Use this for initialization
    void Start () {
        anim1 = first.GetComponent<Animator>();
        anim2 = second.GetComponent<Animator>();
        anim3 = third.GetComponent<Animator>();
        anim4 = fourth.GetComponent<Animator>();
        anim5 = fifth.GetComponent<Animator>();
        anim6 = final.GetComponent<Animator>();
        anim7 = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                if (hit.collider.name == "Door")
                {
                    first.GetComponent<Animator>().enabled = true;
                    second.GetComponent<Animator>().enabled = true;
                    third.GetComponent<Animator>().enabled = true;
                    fourth.GetComponent<Animator>().enabled = true;
                    fifth.GetComponent<Animator>().enabled = true;
                    final.GetComponent<Animator>().enabled = true;
                    door.GetComponent<Animator>().enabled = true;
                }
            }
        }
    }
}
