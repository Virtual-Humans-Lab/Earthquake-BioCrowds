using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public GameObject textoflotante;
    // Start is called before the first frame update
    void Start()
    {
        if (textoflotante)
        {
            MostrarTextoFlotante();
        }
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {


        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
    public void MostrarTextoFlotante()
    {

        GameObject texto = Instantiate(textoflotante);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x,
            this.gameObject.transform.position.y,
            this.gameObject.transform.position.z);
        texto.transform.SetParent(this.transform);
    }
}