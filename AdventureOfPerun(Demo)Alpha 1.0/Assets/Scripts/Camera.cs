using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform playerTransform;
    public Transform cameraTransform;
    	
	// Update is called once per frame
	void Update () {

        cameraTransform.position = Vector3.Lerp(
            cameraTransform.position,
            new Vector3(playerTransform.position.x, cameraTransform.position.y, cameraTransform.position.z), 1f);		
	}
}
