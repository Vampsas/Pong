using UnityEngine;

public class GameSetup : MonoBehaviour
{

    public Camera mainCam;

    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player01;
    public Transform player02;

   
    // Update is called once per frame
    void Update()
    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0, 0)).x, 1f);
        topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
        
        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        player01.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, player01.transform.position.y, 0f);
        player02.transform.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, player02.transform.position.y, 0f);

    }
}
