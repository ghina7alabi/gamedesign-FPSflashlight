using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    public float battery = 7f;
    public float batteryRecharge = 5f;
    float randomNumber;

     void Start()
    {
        randomNumber = Random.Range(2, 5);
    }



    void FixedUpdate()
    {


        if (Input.GetMouseButtonDown(1))
        {
            
            this.gameObject.GetComponent<Light>().enabled = !this.gameObject.GetComponent<Light>().enabled;
            GetComponent<Light>().intensity = 2;
            battery = 7f;

        }
        

        if (this.gameObject.GetComponent<Light>().enabled)
        {

            battery -= Time.deltaTime;
            Debug.Log(battery);

            if (battery <= 4.5)
            {
                GetComponent<Light>().intensity = 2;
            }

            if (battery <= 4.25)
            {
                GetComponent<Light>().intensity = 1;
            }

            if (battery <= 4)
            {
                GetComponent<Light>().intensity = 2;
            }


            if (battery <= 1)
            {
                GetComponent<Light>().intensity = 1;
            }

            if (battery <= 0.80)
            {
                GetComponent<Light>().intensity = 2;
            }

            if (battery <= 0.60)
            {
                GetComponent<Light>().intensity = 1;
            }

            if (battery <= 0.40)
            {
                GetComponent<Light>().intensity = 2;
            }

            if (battery <= 0.15)
            {
                GetComponent<Light>().intensity = 1;
            }


            if (battery <= 0f)
            {
                battery = 0f;
                disabledLight();
                dontAllowUserInput();
                ActivationRoutine();

            }

        }
        

    }
    

    void disabledLight()
    {
        this.gameObject.GetComponent<Light>().enabled = false;
    }

    


    void dontAllowUserInput()
    {
        if (Input.GetMouseButtonDown(1))
        {
            this.gameObject.GetComponent<Light>().enabled = false;


        }
    }
    


    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(batteryRecharge);
        Debug.Log("seconds wait called");
    }

    




}