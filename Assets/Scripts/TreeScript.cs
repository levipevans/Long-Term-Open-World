using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public Transform tree;
    public int damage = 10;
    public Object loot;
    public Animator anim;


    private void Start()
    {
        tree = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    void TakeDamage()
    {
        if (Input.GetButtonDown("Interact"))
        {
            damage -= 1;
            Debug.Log(damage);
        }
        
        if (damage == 0)
        {
            SelfDestruct();
        }
    }

    void SelfDestruct()
    {
        anim.SetBool("SelfDestruct", true);
    }


}
