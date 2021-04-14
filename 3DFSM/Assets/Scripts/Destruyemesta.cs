using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruyemesta : MonoBehaviour
{
    //Referencias
    public GameObject rota;
    private void OnMouseDown()
    {
        //Spawnear la caja rota
        Instantiate(rota, transform.position, transform.rotation);
        //Desruirme (caja entera)
        Destroy(gameObject);
    }
}
