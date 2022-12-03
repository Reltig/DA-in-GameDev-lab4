using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCube : MonoBehaviour
{
    Pedestal firstPedestal,secondPedestal;
    Perceptron perceptron;

    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        var pedestalObjects = GameObject.FindGameObjectsWithTag("Pedestal");
        firstPedestal = (Pedestal)pedestalObjects[0].GetComponent(typeof(Pedestal));
        secondPedestal = (Pedestal)pedestalObjects[1].GetComponent(typeof(Pedestal));
        perceptron = (Perceptron)GameObject.FindGameObjectsWithTag("Perceptron")[0].GetComponent(typeof(Perceptron));
        render = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var output = perceptron.CalcOutput(firstPedestal.State, secondPedestal.State);
        if(output == 0)
            render.material.color = Color.white;
        else
            render.material.color = Color.black;

    }
}
