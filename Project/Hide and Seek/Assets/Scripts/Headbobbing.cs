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
  private float timer = 0.0;
  public float bobbingSpeed = 0.18f;
  public float bobbingAmount = 0.2f;
  public float midpoint = 2.0f;

  void Update(){
    float waveslice = 0.0;

    if(Mathf.Abs(Input.GetAxis("Horizontal")) == 0 && Mathf.Abs(Input.GetAxis("Vertical")) == 0)
      timer = 0.0; //reset timer character is not moving
    else{
      waveslice = Mathf.Sin(timer);
      timer += bobbingSpeed;
      if(timer > Mathf.PI * 2){ //if timer has managed to do a full sin wave then reset the timer back to the beginning of the sin wave
        time -= (Mathf.PI * 2);
      }

      if(waveslice != 0){
        //Local Variables
        float translateChange = waveslice * bobbingAmount;
        float totalAxes = Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"));
        float totalAxes = Mathf.Clamp(totalAxes, 0.0, 1.0);
        translateChange *= totalAxes;
        transform.loaclPosition.y = midpoint + translateChange;
      }

    }
  }
}
