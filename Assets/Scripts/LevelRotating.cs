using UnityEngine;

public class LevelRotating : MonoBehaviour
{
    Vector3 tilt;
    [SerializeField] float rotSpeed = .5f;
    [SerializeField] float tiltDamping = .2f;

    

    void FixedUpdate()
    {

        tilt = Input.acceleration;


    //    if (Input.GetAxis("Horizontal") > 0) //pc input for testing
       if(Input.acceleration.x> tiltDamping)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(-45, Vector3.forward), rotSpeed * .1f);
      //    else if (Input.GetAxis("Horizontal") < 0)
        if (Input.acceleration.x < -tiltDamping)

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(45, Vector3.forward), rotSpeed * .1f);

    }
    public void ResetRotation()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, .1f);
    }
}
