using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEmpat : MonoBehaviour {

    public GameObject bendaSatu, bendaDua, bendaTiga, bendaEmpat , bendaSatuBlack, bendaDuaBlack, bendaTigaBlack, bendaEmpatBlack,blockPanel;


    Vector3 initialbendaSatuPosition, initialbendaDuaPosition, initialbendaTigaPosition, initialbendaEmpatPosition;

    bool bendaSatuBool, bendaDuaBool, bendaTigaBool, bendaEmpatBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;



    public GameObject PausePanel;
    public static bool gameIsPaused;

    void Start()
    {
        initialbendaSatuPosition = bendaSatu.transform.position;
        initialbendaDuaPosition = bendaDua.transform.position;
        initialbendaTigaPosition = bendaTiga.transform.position;
        initialbendaEmpatPosition = bendaEmpat.transform.position;
        // initialPosition = .transform.position;

    }


 


    public void DragbendaSatu()
    {

        
        bendaSatu.transform.position = Input.mousePosition;

    }


    public void DragbendaDua()
    {

       
        bendaDua.transform.position = Input.mousePosition;

    }

    public void DragbendaTiga()
    {

       
        bendaTiga.transform.position = Input.mousePosition;

    }
 
    public void DragbendaEmpat()
    {

       
        bendaEmpat.transform.position = Input.mousePosition;

    }

    // public void Drag()
    // {
       
    //     .transform.position = Input.mousePosition;
        
    // }





    


    public void DropbendaSatu()
    {

        float distance = Vector3.Distance(bendaSatu.transform.position, bendaSatuBlack.transform.position);
        if (distance < 50)
        {
            bendaSatu.transform.position = bendaSatuBlack.transform.position;
            bendaSatuBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            
        }
        else

        {
            bendaSatu.transform.position = initialbendaSatuPosition;
            source.clip = incorrect;
            source.Play();
        }




    }

    public void DropbendaDua()
    {

        float distance = Vector3.Distance(bendaDua.transform.position, bendaDuaBlack.transform.position);
        if (distance < 50)
        {
            bendaDua.transform.position = bendaDuaBlack.transform.position;
            bendaDuaBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            bendaDua.transform.position = initialbendaDuaPosition;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropbendaTiga()
    {

        float distance = Vector3.Distance(bendaTiga.transform.position, bendaTigaBlack.transform.position);
        if (distance < 50)
        {
            bendaTiga.transform.position = bendaTigaBlack.transform.position;
            bendaTigaBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            bendaTiga.transform.position = initialbendaTigaPosition;
            source.clip = incorrect;
            source.Play();
        }

    }


    public void DropbendaEmpat()
    {

        float distance = Vector3.Distance(bendaEmpat.transform.position, bendaEmpatBlack.transform.position);
        if (distance < 50)
        {
            bendaEmpat.transform.position = bendaEmpatBlack.transform.position;
            bendaEmpat.transform.localScale = bendaEmpatBlack.transform.localScale;
            bendaEmpatBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            bendaEmpat.transform.position = initialbendaEmpatPosition;
            source.clip = incorrect;
            source.Play();
        }



    }

     void Update()
    {
        if(bendaSatuBool && bendaDuaBool && bendaTigaBool && bendaEmpatBool )
        {

            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        blockPanel.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    // public void Setting()
    // {
    //     if (gameIsPaused)
    //     {
    //         Resume();
    //     }
    //     else
    //     {
    //         Pause();
    //     }


    // }

    // public void Resume()
    // {
    //     PausePanel.SetActive(false);
    //     Time.timeScale = 1f;
    //     gameIsPaused = false;
    // }
    // public void Pause()
    // {
    //     PausePanel.SetActive(true);
    //     Time.timeScale = 0f;
    //     gameIsPaused = true;
    // }

    public void Exit()
    {
        Application.Quit();
    }
}
