using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] private AudioSource Walk1;
    [SerializeField] private AudioSource Walk2;

    private void FixedUpdate ()
    {
        if (Input.GetKey(KeyOne))
        {
              GetComponent<Rigidbody>().velocity += moveDirection;  
        }
        if (Input.GetKey(KeyOne))
            Walk1.Play();
        
        else if (Input.GetKey(KeyOne))
        Walk1.Stop(); 
        
        if (Input.GetKey(KeyTwo))
              GetComponent<Rigidbody>().velocity -= moveDirection;

        if (Input.GetKey(KeyTwo))
            Walk2.Play();
        
        else if (Input.GetKey(KeyTwo))
        Walk2.Stop(); 

        if (Input.GetKey(KeyCode.R))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        //if (Input.GetKey(KeyCode.Q))
        //{
        //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //}
        if (Input.GetKey(KeyCode.W))
        {
          SceneManager.LoadScene("MainMenu");
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
         if (this.CompareTag("Player") && other.CompareTag("FinishS"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
        }
        if (this.CompareTag("Player") && other.CompareTag("FinEdu"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 17);
        }
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(activator button in FindObjectsOfType<activator>())
            {
                button.canPush = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
       if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(activator button in FindObjectsOfType<activator>())
            {
                button.canPush = true;
            }
        } 
    }
}
