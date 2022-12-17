using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciadorCarteles : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;
    public GameObject objeto6;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objeto1);
        Instantiate(objeto2);
        Instantiate(objeto3);
        Instantiate(objeto4);
        Instantiate(objeto5);
        Instantiate(objeto6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
} 
