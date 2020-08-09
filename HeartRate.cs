//This code is being used for a Virtual Reality Unity Game that is currently still in progress
//It will help collect the heart rate of our users in order to create an immersive experience while playing, based on their BPM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRate : MonoBehaviour
{

    public float alphaLevel = 0.2f;
    public float redLevel = 1f;
    public float greenLevel = 1f;
    public float blueLevel = 1f;

    bool changeBool = true;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (changeBool == true) {
            StartCoroutine(HeartRateChange());

            float Achange = Random.Range(-0.0002f, 0.002f);
            float Rchange = Random.Range(-0.01f, 0.01f);
            float Gchange = Random.Range(-0.01f, 0.01f);
            float Bchange = Random.Range(-0.01f, 0.01f);


            alphaLevel = alphaLevel + Achange;
            redLevel = redLevel + Rchange;
            greenLevel = greenLevel + Gchange;
            blueLevel = blueLevel + Bchange;

            GetComponent<MeshRenderer>().material.color = new Color(redLevel, greenLevel, blueLevel, alphaLevel);
        }
    }

    IEnumerator HeartRateChange()
    {
        changeBool = false;
        yield return new WaitForSeconds(0.01f);
        changeBool = true;

    }
