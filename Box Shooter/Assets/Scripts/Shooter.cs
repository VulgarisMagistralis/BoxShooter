using UnityEngine;
public class Shooter : MonoBehaviour {
	public GameObject projectile;
	public Camera playerCamera;
	public float power = 10.0f;
	public AudioClip shootSFX;
	void Update () {
		// Detect if fire button is pressed
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")){	
			// if projectile is specified
			if(projectile){
				// Instantiante projectile at the camera + 1 meter forward with camera rotation
				GameObject newProjectile = Instantiate(projectile, playerCamera.transform.position + playerCamera.transform.forward, playerCamera.transform.rotation) as GameObject;
				newProjectile.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * power, ForceMode.VelocityChange);
				if(shootSFX) AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);				
			}
		}
	}
}