using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{

    public GameObject wheelA, wheelB, bikePedals, bikeGear, theGround;
    float speed = 0.33f;
    float wheelRotation = 0;
    Vector3 angles;

   Material groundmat;

    // Start is called before the first frame update
    void Start() 
    {
         groundmat = theGround.GetComponent<Renderer>().material;
         Debug.Log("werkt");
    } 

    // Update is called once per frame
    void Update()
    {

        if  (  Input.GetKeyDown("w") ||  Input.GetKeyDown("a") ||  Input.GetKeyDown("d") ||  Input.GetKeyDown("s") || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.LeftShift) )  {
            Debug.Log("Toets w ingedrukt");
            speed = 0.05f;
        }
        if ( Input.anyKey == false ) {
            speed = 0.33f;
        }


        wheelRotation += speed;
        angles = new Vector3( wheelRotation, 0, 0  );
                //  Debug.Log(groundmat.mainTextureOffset);

        wheelA.transform.rotation =  Quaternion.Euler( angles );
        wheelB.transform.rotation =  Quaternion.Euler( angles );
        bikePedals.transform.rotation =  Quaternion.Euler( angles );
        bikeGear.transform.rotation =  Quaternion.Euler( angles );
        groundmat.mainTextureOffset = new Vector2(0, wheelRotation*0.002f);
        
    }  
}
