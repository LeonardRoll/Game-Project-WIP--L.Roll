using UnityEngine;
using System.Collections;
/*
  Script: Headbobbing
  Description: This is a headbobbing script that is made, based on a youtube videos' script. This script is just
  used to make the characters movement look just a little more realistic. In time I may implement some way
  to alter the headbobbing so that it speeds up due to stress.
*/
public class Headbobbing : MonoBehaviour{
  //Variables
  public bool Headbob_enable = true;
  private float timer = 0.0f;
  public float bobbingSpeed = 0.1f;
  public float bobbingAmount = 0.05f;
  public float midpoint = 0.75f;

  void Update(){
    float waveslice = 0.0f;

    if(Mathf.Abs(Input.GetAxis("Horizontal")) == 0 && Mathf.Abs(Input.GetAxis("Vertical")) == 0)
      timer = 0.0f; //reset timer character is not moving
    else{
      waveslice = Mathf.Sin(timer);
      timer += bobbingSpeed;
      if(timer > Mathf.PI * 2){ //if timer has managed to do a full sin wave then reset the timer back to the beginning of the sin wave
        timer -= (Mathf.PI * 2);
      }

      if(waveslice != 0){
        //Local Variables
        float translateChange = waveslice * bobbingAmount;
        float totalAxes = Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"));
        totalAxes = Mathf.Clamp(totalAxes, 0.0f, 1.0f);
        translateChange *= totalAxes;
        transform.localPosition = new Vector3(0,midpoint + translateChange,0);
      }

    }
  }
}
