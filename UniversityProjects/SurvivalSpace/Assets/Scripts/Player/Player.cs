﻿using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine.TestTools;

/// <summary>
/// Script created by: Matthew Burke, Andrew Viney
/// </summary>
public class Player : MonoBehaviourPunCallbacks, IPunObservable
{
    /// <summary>
    /// This is a reference to the name of the player
    /// </summary>
    private string playerName;
    private string userName;
    
    

    /// <summary>
    /// This is the maximum health the player can have, can be upgraded layer
    /// </summary>
    [SerializeField] private float maxHealth = 10;

    [SerializeField] private float shootSpeed = 0.2f;
    private float shootTimer = 0.2f;
   
    /// <summary>
    /// This is the speed the player is currently moving at
    /// </summary>
    private float movementSpeed = 10f;

    /// <summary>
	/// the player money
	/// </summary> 
    private int currency;

	/// <summary>
    /// This is the health the player currently has
    /// </summary>
    private float playerHealth = 10;

    /// <summary>
    /// The below variables reflect the players stats in game
    /// </summary>
    private float exp;
    private int level;
    private int killCount;
    private int deaths;
    private int killStreak;
    private int killsThisGame;
    public bool canShoot = true;  
    private bool leaderboardOpen;


    /// <summary>
    /// This is a reference to the camera object so it can be modified later
    /// </summary>
    private Camera camera;

    /// <summary>
    /// This is a list of all the guns currently attached to the player
    /// </summary>
    [SerializeField] private List<Gun> guns = new List<Gun>();
    [SerializeField] private Transform crosshair;

    /// <summary>
    /// check if the user can use mines
    /// </summary>
    private bool minesEnabled=false;

    /// <summary>
    /// The below variables are references to all the UI components for the player
    /// </summary>
    private Text levelText;
    private Text healthText;
    private Text joinText;
    private Text pingText;

    private Slider healthSlider;
    private Slider expSlider;
    private Slider cooldownSlider;

    private GameObject levelUpNotification;

    /// <summary>
    /// A boolean showing if we have displayed the killstreak text or not
    /// </summary>
    bool displayedKillstreakText = false;

    /// <summary>
    /// The below variables are references to all the particle effects we want in the game
    /// </summary>
    [SerializeField] private GameObject explosionParticle;
    [SerializeField] private GameObject levelUpEffect;
    [SerializeField] private GameObject hitParticle;
    [SerializeField] private GameObject explosiveParticle;
    [SerializeField] private GameObject boostTrail;

  /// <summary>
  /// set starting varables and get refrences for other objects
  /// </summary>
    private Shop shop;
    private LeaveButton leaveButton;
    private ControlsPage controlsPage;
    Leaderboard leaderboard;
    GameManager manager;
    public bool canMove;
    private int speedIncrease = 1;
   
    private GameObject pauseMenu;
    private CanvasGroup pauseMenuGroup;
    private TMP_Text currencyText;
    private bool manualCool = false;
    private Text overHeatText;
    private Text mapText;

    private int shots = 0;
    private int maxShots = 12;
    private float weaponCool = 2f;
    private bool weaponCooling = false;

    public bool isDead = false;

    private GameObject respawnScreen;
    private GameObject lobbyScreen;
    public GameObject coinPickup;

    public bool isReady = false;
    public bool masterClient = false;
    
    public ParticleSystem[] trails;
    private int trailInt;
    [SerializeField] private TMP_Text nameText;
    private int trailCustom;
    [SerializeField] private GameObject trail;

    private LineRenderer lineRenderer;

    /// <summary>
	/// key bindings
	/// </summary>
    KeyCode kcForward = KeyCode.W;
    KeyCode kcLeft = KeyCode.A;
    KeyCode kcRight = KeyCode.D;
    KeyCode kcBack = KeyCode.S;
    KeyCode kcShop = KeyCode.I;
    KeyCode kcCool = KeyCode.T;
    KeyCode kcMine = KeyCode.F;
    KeyCode kcScore = KeyCode.Tab;
    KeyCode kcUp = KeyCode.Q;
    KeyCode kcDown = KeyCode.E;
    KeyCode kcBoost = KeyCode.Space;
    KeyCode kcClosest = KeyCode.LeftControl;
    KeyCode kcShowBoat = KeyCode.X;
    KeyCode kcShoot = KeyCode.Mouse0;

    //taunt varables
    private bool showBoat = false;
    private float rotZ=0;

    public GameManager.GameStates currentState;
    private bool gameOver = false;
    /// <summary>
	/// reset the player when connecting
	/// </summary>
    [PunRPC]
    public void ResetPlayer() { 
        gameOver = true;
        canMove = false;
        canShoot = false;

        foreach(MeshRenderer r in FindObjectsOfType<MeshRenderer>())
        {
            r.enabled = false;
        }
        foreach (ParticleSystem r in FindObjectsOfType<ParticleSystem>())
        {
            Destroy(r.gameObject);
        }

        Invoke("Disconnect", 5f);
    }
    /// <summary>
	/// move from game to lobby
	/// </summary>
    [PunRPC]
    public void SetToLobby()
    {
        currentState = GameManager.GameStates.LOBBY;
    }
    /// <summary>
	/// move from lobby to game
	/// </summary>
    [PunRPC]
    public void SetToGame()
    {
        currentState = GameManager.GameStates.GAME;
        lobbyScreen.GetComponent<CanvasGroup>().alpha = 0; //remove for testing
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    /// <summary>
	/// set to ready for use in lobby
	/// </summary>
    [PunRPC]
    public void ReadyUp()
    {
        isReady = true;
    }

    /// <summary>
    /// This is the method for syncing all of the players variables to the other clients on the server.
    /// This is called multiple times per second to ensure proper synchronisation between players
    /// </summary>
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(playerHealth);
            stream.SendNext(canShoot);
            stream.SendNext(level);
            stream.SendNext(killCount);
            stream.SendNext(killsThisGame);
            stream.SendNext(playerName);
            stream.SendNext(isReady);
            stream.SendNext(currentState);
            stream.SendNext(masterClient);
        }
        else if (stream.IsReading) 
        {
            playerHealth = (float)stream.ReceiveNext();
            canShoot = (bool)stream.ReceiveNext();
            level = (int)stream.ReceiveNext();
            killCount = (int)stream.ReceiveNext();
            killsThisGame = (int)stream.ReceiveNext();
            playerName = (string)stream.ReceiveNext();
            isReady = (bool)stream.ReceiveNext();
            currentState = (GameManager.GameStates)stream.ReceiveNext();
            masterClient = (bool)stream.ReceiveNext();
        }
    }

    /// <summary>
    /// This method is called as soon as the player enters the main scene. 
    /// It is responsible for setting up all of the required variables that cannot be set in the editor.
    /// </summary>
    void Start()
    {
        lineRenderer = GameObject.Find("Line").GetComponent<LineRenderer>();

        if (photonView.IsMine)
        {
            userName = PlayerPrefs.GetString("Name"); 
            playerName = userName;
            nameText.gameObject.SetActive(false);
        }

        nameText.text = playerName;

        if(PhotonNetwork.IsMasterClient)
        {
            masterClient = true;
            FindObjectOfType<LobbyManager>().isHost = true;
        }

        lobbyScreen = GameObject.Find("Lobby");

        if(FindObjectsOfType<Player>().Length < 2)
        {
            currentState = GameManager.GameStates.LOBBY;
            lobbyScreen.GetComponent<CanvasGroup>().alpha = 1;
        }

        foreach(Player player in FindObjectsOfType<Player>())
        {
            if(player.currentState == GameManager.GameStates.LOBBY)
            {
                currentState = GameManager.GameStates.LOBBY;
                lobbyScreen.GetComponent<CanvasGroup>().alpha = 1;
            }
            else
            {
                currentState = GameManager.GameStates.GAME;
                lobbyScreen.GetComponent<CanvasGroup>().alpha = 0;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        respawnScreen = GameObject.Find("Respawn Screen");

        levelUpNotification = GameObject.Find("Level Up");

        currency = 100;
        currencyText = GameObject.Find("Currency Text").GetComponent<TMP_Text>();
        currencyText.text = "Currency: " + currency;

        shop = FindObjectOfType<Shop>();
        shop.gameObject.SetActive(false);
        leaveButton = FindObjectOfType<LeaveButton>();
        leaveButton.gameObject.SetActive(false);
        controlsPage = FindObjectOfType<ControlsPage>();
        controlsPage.gameObject.SetActive(false);
        overHeatText = GameObject.Find("OverHeatText").GetComponent<Text>();
        overHeatText.text = "";
        mapText = GameObject.Find("MapText").GetComponent<Text>();
        mapText.text = "";
     
       
        leaderboard = FindObjectOfType<Leaderboard>();
        leaderboard.player = this;
        manager = FindObjectOfType<GameManager>();
        pauseMenu = GameObject.Find("Menu");
        pauseMenuGroup = pauseMenu.GetComponent<CanvasGroup>();

        canMove = true;
        
        healthText = GameObject.Find("Health Text").GetComponent<Text>(); 
        healthSlider = GameObject.Find("Health Background").GetComponent<Slider>();
        levelText = GameObject.Find("Level Text").GetComponent<Text>();
        expSlider = FindObjectOfType<Slider>();
        cooldownSlider = GameObject.Find("Weapon Cooldown Bar Background").GetComponent<Slider>(); 

        playerHealth = maxHealth; 
        UpdateHealthBar();

        level = PlayerPrefs.GetInt("Level"); 
        levelText.text = "Level: " + level; 

        exp = PlayerPrefs.GetFloat("Exp");
        expSlider.value = exp / 100; 

        pingText = GameObject.Find("Ping Text").GetComponent<Text>();

        camera = GetComponentInChildren<Camera>();

        foreach (ParticleSystem p in trails)
        {
            p.Pause();
        }

        transform.forward = camera.transform.forward;

        if (!photonView.IsMine)
        {
            Destroy(GetComponentInChildren<Camera>().gameObject);
            crosshair.gameObject.SetActive(false);
        }
    }
    /// <summary>
	/// find the next closest player will draw a line from the player to the next closest player item
	/// </summary>
    private void FindClosestPlayer()
    {
        if (FindObjectsOfType<Player>().Length >= 2)
        {
            Transform min = null;
            float minDis = Mathf.Infinity;
            Vector3 currentPosition = transform.position;

            foreach (Player p in FindObjectsOfType<Player>())
            {
                if (!p.photonView.IsMine)
                {
                    float dist = Vector3.Distance(p.transform.position, currentPosition);
                    if (dist < minDis)
                    {
                        min = p.transform;
                        minDis = dist;
                    }
                }
            }
            lineRenderer.SetPosition(1, min.position);
        }
    }

    /// <summary>
    /// This method is called once per frame, framerate dependent.
    /// Movement related commands are not recommended to go in here.
    /// </summary> //
    void Update()
    {
        if (!photonView.IsMine)
        {
            return; 
        }

        lineRenderer.SetPosition(0, transform.position);

        if (PhotonNetwork.IsMasterClient)
        {
            masterClient = true;
        }

        if(weaponCooling)
        {
            cooldownSlider.value -= Time.deltaTime * (shots / 2);
        }

        if(cooldownSlider.value == 0)
        {
            cooldownSlider.GetComponent<CanvasGroup>().alpha = 0;
        }
        else
        {
            cooldownSlider.GetComponent<CanvasGroup>().alpha = 1;
        }

        if (currentState != GameManager.GameStates.LOBBY)
        {
            if (Input.GetKeyDown(kcBoost))//boost on
            {
              

                    FindObjectOfType<AudioManager>().Play("BoostNoise");
                photonView.RPC("StartTrail",RpcTarget.All, PlayerPrefs.GetInt("custom"));
            }
            
            if(Input.GetKeyUp(kcBoost))//boost off
            {
                FindObjectOfType<AudioManager>().Stop("BoostNoise");
                photonView.RPC("StopTrail", RpcTarget.All);
            }

            transform.forward = Vector3.Lerp(transform.forward, -GetComponentInChildren<Camera>().transform.forward, Time.deltaTime * 16f);

            if (Input.GetKey(kcShoot) && Time.time > shootTimer && canShoot && !shop.shopEnabled)//shooting 
            {
                if (shots < maxShots)
                {
                    photonView.RPC("Shoot", RpcTarget.All, PlayerPrefs.GetInt("bulletCustom"));
                    shots++;
                    cooldownSlider.value = shots;
                    shootTimer = Time.time + shootSpeed;
                }
                else
                { 
                  if (!manualCool)//over heating 
                    {
                        weaponOverheat("Weapon Reloading");
                    }
					else
					{
                        weaponOverheat("Weapon Reloading");
                    }
                } 
            }

			if (Input.GetKeyDown(kcCool) && !manualCool)//reload
			{
                manualCool = true;
                shots = maxShots + 1;
                weaponOverheat("Weapon Reloading");
            }

            if (Input.GetKeyDown(kcMine) && (minesEnabled))//mine
            {
                photonView.RPC("DropMine", RpcTarget.All);
            }

            if(Input.GetKey(kcClosest))//closes player
            {
                FindClosestPlayer();
                lineRenderer.SetWidth(0.05f, 0.05f);
            }
            else
            {
                lineRenderer.SetWidth(0, 0);
            }

			if (Input.GetKey(kcLeft) && !Input.GetKey(kcRight) && !Input.GetMouseButton(1))//move left
			{
                float z = Input.GetAxis("Horizontal") * 10.0f;
                Vector3 euler = transform.localEulerAngles;
                euler.z = Mathf.Lerp(euler.z, z, 25.0f * Time.deltaTime);
                transform.localEulerAngles = euler;
            }

            if (Input.GetKey(kcRight) && !Input.GetKey(kcLeft)&&!Input.GetMouseButton(1))//move right
                {
                float z = Input.GetAxis("Horizontal") * 10.0f;
                Vector3 euler = transform.localEulerAngles;
                euler.z = Mathf.Lerp(euler.z, z, 25.0f * Time.deltaTime);
                transform.localEulerAngles = euler;
            }

			if (Input.GetKey(kcShowBoat) && !Input.GetKey(kcLeft) && !Input.GetKey(kcRight) && !Input.GetKey(kcUp) && !Input.GetKey(kcDown) )//flip
            {
                showBoat = true;
            }

			if (showBoat && !Input.GetMouseButton(1))//flip
			{
                rotZ = rotZ+1f;
                transform.Rotate(0, 0, rotZ);
                if (rotZ > 360)
				{
                    rotZ = 0;
                    showBoat = false;
                    transform.Rotate(0, 0, rotZ * Time.deltaTime);
                }
			}

            if (Input.GetKeyDown(kcShop))//open in game shop
            {
                shop.setEnabled();

                if (shop.shopEnabled)
                {
                    shop.gameObject.SetActive(true);
                    shop.updateText(currency);
                }
                else
                {
                    shop.gameObject.SetActive(false);
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
            if (shop.shopEnabled || leaveButton.leaveEnabled)//temp bug fix untill i can find reall solution
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            if (Input.GetKeyDown(kcScore))
            {
                if (!leaderboardOpen)
                {
                    leaderboard.ShowLeaderBoard();
                    leaderboardOpen = true;
                }
                else
                {
                    leaderboard.HideLeaderboard();
                    leaderboardOpen = false;
                }
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))//ready up
            {
                isReady = !isReady;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) )//exit and menue
        {
            ToggleMenu();//show menue

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            leaveButton.setEnabled();
            controlsPage.setEnabled();
            if (leaveButton.leaveEnabled)//set so they can be seen
            {
                leaveButton.gameObject.SetActive(true);
                controlsPage.gameObject.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                leaveButton.gameObject.SetActive(false);
                controlsPage.gameObject.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.P) && (leaveButton.leaveEnabled))//leave game 
        {
            Disconnect();
        }

        if (gameOver)//end game
		{
            isDead = true;
            canShoot = false;
        }

        pingText.text = "Latency: " + PhotonNetwork.GetPing(); //show ping
    }
    /// <summary>
	/// start the player trail so all players can see
	/// </summary>
	/// <param name="customValue">the value for trail colour to be show</param>
    [PunRPC]
    private void StartTrail(int customValue)
    {
        
        foreach (ParticleSystem p in trails)
        {
            if (customValue == 10)
            {
                p.startColor = new Color(1, 0, 1, .5f);
            }
            else if (customValue == 15)
            {
                p.startColor = new Color(0 , 0.8f , 1,.5f);
            }
            else if (customValue == 20)
            {
                p.startColor = new Color(0, 1, 0, .5f);
            }
            p.Play();
        }
    }

    [PunRPC]
    private void StopTrail()
    {
        foreach (ParticleSystem p in trails)
        {
            p.Stop();
        }
    }

    /// <summary>
    /// This Update method is framerate independent. Movement commands should go in here
    /// </summary>
    private void FixedUpdate()
    {
        if (!photonView.IsMine)
        {
            return;
        }

        if (currentState != GameManager.GameStates.LOBBY)
        {
            HandleInput();
        }
    }

    /// <summary>
    /// This method handles the player movement based on keyboard input.
    /// </summary>
    void HandleInput()
    {
        if (canMove && !isDead)
        {
            CheckOutOfBounds();
            if (Input.GetKey(kcForward)|| Input.GetKey(kcBoost))
            {
                transform.position += -transform.forward * (speedIncrease *movementSpeed) * Time.deltaTime;
                camera.fieldOfView += Time.deltaTime * 6;

                if (Input.GetKey(kcBoost))
                {
                    movementSpeed = 11f;
                    camera.GetComponent<CameraMovement>().SetMaxFOV(95f);
                }
                else
                {
                    movementSpeed = 5f;
                    camera.GetComponent<CameraMovement>().SetMaxFOV(90f);
                }
            }
            if(Input.GetMouseButtonDown(1))
            {
                camera.GetComponent<CameraMovement>().SetMaxFOV(80f);
            }
            else
            {
                camera.fieldOfView -= Time.deltaTime * 6;
            }

            if (Input.GetKey(kcLeft) && !Input.GetKey(kcRight) )
            {
                transform.position += transform.right * (speedIncrease * movementSpeed) * Time.deltaTime;
            }
            
            if (Input.GetKey(kcBack))
            {
                transform.position += transform.forward * (speedIncrease * movementSpeed) * Time.deltaTime;
            }

            if (Input.GetKey(kcRight) && !Input.GetKey(kcLeft))
            {
                transform.position += -transform.right * (speedIncrease * movementSpeed) * Time.deltaTime;
            }

            if (Input.GetKey(kcDown))
            {
                transform.position += -transform.up * (speedIncrease * movementSpeed) * Time.deltaTime;
            }

            if (Input.GetKey(kcUp))
            {
                transform.position += transform.up * (speedIncrease * movementSpeed) * Time.deltaTime;
            }
        }
    }

    private void ToggleMenu()
    {
        if(pauseMenuGroup.alpha == 0)
        {
            pauseMenuGroup.alpha = 1;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if(pauseMenuGroup.alpha == 1)
        {
            pauseMenuGroup.alpha = 0;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void LeaveSession()
    {
        manager.LeaveRoom();
    }

    /// <summary>
    /// This RPC function allows the player to shoot.
    /// <param name="custom">the value for shot colour to be show</param>
    /// </summary>
    [PunRPC]
    void Shoot(int custom)
    {
        
        foreach (Gun g in guns)
        {
            Vector3 startPos = g.getGunPosition().position;
            FindObjectOfType<AudioManager>().Play("LaserSound1", startPos);
            Vector3 endPos = -transform.forward * 100f;
            Trail t = Instantiate(trail, g.getGunPosition()).GetComponent<Trail>();
            t.Init(startPos, g.getGunPosition().transform.forward);
            if (custom == 1)//get colours
            {
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(1,0,0));
            }
            else if(custom ==2)
			{
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.7f , 1, 0));
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(1, 0, 1));
            }
            else if (custom == 3)
            {
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(0f, 1, 1));

            }
            else if (custom == 4)
            {
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.5f, 0.0f, 0.2f));

            }
            else
			{
                t.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.7f, 1, 0));
            }
            RaycastHit hit;
            if(Physics.Raycast(startPos, endPos, out hit))
            {
                RpcCreateHitParticle(hit.point);
                if(hit.transform.tag == "Player")
                {
                    hit.transform.GetComponent<Player>().hitDetected(1, this);
                }
                else if(hit.transform.tag == "Obstacle")
                {
                    hit.transform.GetComponent<Obstacles>().reduceHealth(1);
                }
                else if (hit.transform.tag == "Mine")
                {
                    hit.transform.GetComponent<Mine>().hit();
                }
            }
        }
    }

    /// <summary>
    /// This RPC function allows the player to drop mines.
    /// </summary>
    [PunRPC]
    private void DropMine()
    {
        Gun g = guns[0];
        GameObject mine = Instantiate(g.getMine(), g.getGunPosition().position, transform.rotation);
        mine.GetComponent<Mine>().InitializeMine(gameObject); 
        Destroy(mine, 10f);
    }

    [PunRPC]
    public void NetworkAddKill()
    {
        killCount += 1;
        if(photonView.IsMine) //remove for Testing
        {//remove for Testing
            PlayerPrefs.SetInt("Kills", PlayerPrefs.GetInt("Kills") + 1);
            AddExperience(10);
            addCurrency();
       }//remove for Testing
    }

    [PunRPC]
    public void NetworkAddDeath()
    {
        deaths += 1;
    }

    /// <summary>
    /// If we want to apply damage to a player. We call this method.
    /// </summary>
    /// <param name="damage"> The amount of damage we want to apply to the player.</param>
    public void hitDetected(int damage, Player who)
    {
        
        if (photonView.IsMine)//remove for testing
        {//remove for testing
            playerHealth = playerHealth - damage;
            UpdateHealthBar();      //remove for testing
            if (playerHealth <= 0)
            {
                 photonView.RPC("dropPack", RpcTarget.All);//remove for testing
                   photonView.RPC("Despawn", RpcTarget.All);//remove for testing
                    who.photonView.RPC("NetworkAddKill", RpcTarget.AllBuffered);//remove for testing
        }
         }//remove for testing
    }

    /// <summary>
    /// We call this method after we modify the players health. This allows the healthbar to sync up.
    /// </summary>
    public void UpdateHealthBar()
    {
        if (photonView.IsMine)
        {
            healthSlider.value = playerHealth / maxHealth; 
            healthText.text = playerHealth + "/" + maxHealth; 
        }
    }

    public Shop getShop()
	{
        return shop;
	}

    /// <summary>
    /// This method begins the death process.
    /// It is responsible for deactivating all of the necessary components to hide the player and prevent other players from interacting with it.
    /// </summary>
    [PunRPC]
    public void Despawn()
    {
        isDead = true;
        canShoot = false;
        canMove = false;

        GameObject p = Instantiate(explosionParticle, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("PlayerExplode", transform.position);//remove For Test
        Destroy(p, 5f);//remove For Test
              if (photonView.IsMine)//remove For Test
        {//remove For Test
         photonView.RPC("NetworkAddDeath", RpcTarget.AllBuffered);//remove For Test
            PlayerPrefs.SetInt("Deaths", PlayerPrefs.GetInt("Deaths")+1);//remove For Test
        killStreak = 0;
            displayedKillstreakText = false;
        }//remove For Test

        foreach (Transform child in transform)
        {
            if (child.GetComponent<MeshRenderer>())
            {
                child.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        GetComponent<BoxCollider>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;

       if (photonView.IsMine)//remove For Test
       {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
       }

        StartCoroutine(RespawnTimer());
    }

    public void RespawnButton()
    {
        Invoke("Respawn", 3f);
    }

    private IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(5f);
        Respawn();
    }

    /// <summary>
    /// This RPC is called when we want the player to respawn. 
    /// It is responsible for reactivating all the necessary components to get the player back into the action.
    /// </summary>
    public void Respawn()
    {
        if (photonView.IsMine) //remove For Test
        {//remove For Test
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }//remove For Test

        isDead = false;
      transform.position = manager.spawnPoints[UnityEngine.Random.Range(0, manager.spawnPoints.Count)].position;//remove For Test
        playerHealth = maxHealth; 
       UpdateHealthBar();//remove For Test
        maxShots = 12;
        foreach (Transform child in transform) 
        {
            if (child.GetComponent<MeshRenderer>())
            {
                child.GetComponent<MeshRenderer>().enabled = true;
            }
        }

        GetComponent<BoxCollider>().enabled = true;
        GetComponent<CapsuleCollider>().enabled = true;
        canShoot = true;
        canMove = true;
       
    }

    /// <summary>
    /// When we want to add experience to the player, we call this method.
    /// </summary>
    /// <param name="amt">The amount of experience we want to give the player</param> 
    public void AddExperience(float amt)
    {
        exp += amt;
            expSlider.value = exp / 100;//remove for Testing

        if (exp >= 100) 
        {
            photonView.RPC("RpcCreateLevelUpParticle", RpcTarget.All); //remove for Testing
            level += 1;
            StartCoroutine(levelUpPopup());
               FindObjectOfType<AudioManager>().Play("LevelUp"); //remove for Testing
               levelText.text = "Level: " + level;//remove for Testing
            exp = 0;
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1); 
            expSlider.value = 0; 
        }

        PlayerPrefs.SetFloat("Exp", exp); 
    }

    private IEnumerator levelUpPopup()
    {
        levelUpNotification.GetComponent<CanvasGroup>().alpha = 1;
        levelUpNotification.GetComponent<LevelUpNotification>().SetText("Rank: " + level);
        yield return new WaitForSeconds(2f);
        levelUpNotification.GetComponent<CanvasGroup>().alpha = 0;
    }

    /// <summary>
    /// We call this method if we want to know if the player is on a killstreak
    /// </summary>
    public bool onKillStreak()
    {
        return killStreak >= GameManager.killstreakForEffect; 
    }

    public IEnumerator killstreakText()
    {
        GameObject.Find("KillstreakText").GetComponent<CanvasGroup>().alpha = 1;
        yield return new WaitForSeconds(3f);
        GameObject.Find("KillstreakText").GetComponent<CanvasGroup>().alpha = 0;
    }

    //////////////Instantiating particles///////////////////

    //Hit particle
    public void RpcCreateHitParticle(Vector3 position)
    {
        GameObject p = Instantiate(hitParticle, position, Quaternion.identity);
        Destroy(p, 5f);
    }

    //Level up particle
    [PunRPC]
    public void RpcCreateLevelUpParticle()
    {
        GameObject p = Instantiate(levelUpEffect, transform.position, Quaternion.identity);
        Destroy(p, 5f);
    }

    //Hit particle
    [PunRPC]
    public void RpcExplosiveParticle(Vector3 position)
    {
        GameObject p = Instantiate(explosiveParticle, position, Quaternion.identity);
        Destroy(p, 5f);
    }

    /// <summary>
    /// We call this method if we want to get the players current health
    /// </summary>
    /// <returns>the players current health</returns> 
    public float getHealth()
    {
        return playerHealth;
    }

    /// <summary>
    /// We call this method if we want to get the players maximum health
    /// </summary>
    /// <returns>the players maxiumum health</returns> 
    public float getMaxHealth()
    {
        return maxHealth;
    }

    /// <summary>
    /// We call this method if we want to grab the PhotonView component attached to this object.
    /// </summary>
    /// <returns></returns>
    public PhotonView GetPhotonView()
    {
        return photonView;
    }

    /// <summary>
    /// add funds
    /// </summary>
    private void addCurrency()
    {
        currency = currency + 20;
        currencyText.text = "Currency: " + currency;//remove for Testing
    }
    /// <summary>
    //get the amount of points the player has
    /// </summary>
    public int getCurrency()
	{
        return currency;
	}
    /// <summary>
    //take points for a purchase
    /// </summary>
    public void purchaseMade(int price)
	{
        currency = currency - price;
        currencyText.text = "Currency: " + currency;//remove for testing
	}
    /// <summary>
    //increase player health
    /// </summary>
    public void upgradePurchasedHealth()
	{
        maxHealth = 20;
        playerHealth = maxHealth;   
        //this may need to be change as will heal player if they purchase upgrade
        UpdateHealthBar();
    }
    /// <summary>
    //speed the player up
    /// </summary>
    public void upgradePurchasedSpeed()
    {
        speedIncrease=2 ;
    }
    /// <summary>
    //allow mines to be used
    /// </summary>
    public void unlockMines()
	{
        minesEnabled = true;
	}
    /// <summary>
    //reduce the cool down
    /// </summary>
    public void cooldownUpgrade()
	{
        weaponCool = weaponCool / 2;
        //half the cooldown
	}
    public float getCoolDown()
	{
        return weaponCool;
	}

    /// <summary>
    ///set up text and start timer for cool down 
    /// </summary>
    [PunRPC]
    private void weaponOverheat(String messageText)
	{
        overHeatText.color = new Color(255, 0, 0, 1); //set text colour to red
        overHeatText.text = messageText; //set warning message
        StartCoroutine("CoolDownTimer"); //run timmer
        FindObjectOfType<AudioManager>().Play("Overheat", transform.position);
    }

    /// <summary>
    ///reset the weapon so that it can fire again
    /// </summary>
    [PunRPC]
    private void weaponCoolDown()
	{
        overHeatText.text = ""; //make the text invisible
        shots = 0; //reset the number of shots
        cooldownSlider.value = 0;
        manualCool = false;
        weaponCooling = false;
    }

    /// <summary>
    ///runs while the weapon is unable to fire
    /// </summary>
    private IEnumerator CoolDownTimer()
    {
        weaponCooling = true;
        yield return new WaitForSeconds(2f);
        weaponCoolDown();
    }

    public void HealthBoost(int boost)
	{
        if (playerHealth <= maxHealth-5)
        {
            playerHealth = playerHealth + boost;
		}
		else
		{
            playerHealth = maxHealth;
		}
        UpdateHealthBar();
	}

    [PunRPC]
    private void dropPack()
	{
        Gun g = guns[0];
        GameObject pack = Instantiate(g.getHealthPack(), g.getGunPosition().position, transform.rotation);
        pack.GetComponent<HealthPack>().InitializePack(5);
        Destroy(pack,20f);
    }
    /// <summary>
	/// 
	/// check if the player has moved out of bounds and shift them back into play if they have
	/// </summary>
    public void CheckOutOfBounds()
	{
        mapText.text = "";
        if (transform.position.z <= -170) {
            mapText.text = "   Leaving Battlfield";
            if (transform.position.z <= -180)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -170);
            }

        }
        else if (transform.position.z >= 280)
        {
            mapText.text = "   Leaving Battlefield";
            if (transform.position.z >= 300)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 280);
            }
        }
        if (transform.position.y <= -160)
        {
            mapText.text = "   Leaving Battlefield";
            if (transform.position.y <= -180)
            {
                transform.position = new Vector3(transform.position.x, -160, transform.position.z);
            }
        }
        else if (transform.position.y >= 280)
        {
            mapText.text = "   Leaving Battlefield";
            if (transform.position.y >= 300)
            {
                transform.position = new Vector3(transform.position.x, 280, transform.position.z);
            }
        }
        if (transform.position.x >= 280)
        {
            mapText.text = "   Leaving Battlefield";
            if (transform.position.x >= 300)
            {
                transform.position = new Vector3(280, transform.position.y, transform.position.z);
            }
        }

        else if (transform.position.x <= -160)
        {
            mapText.text = "   Leaving Battlefield";
            if (transform.position.x <= -180)
            {
                transform.position = new Vector3(-160, transform.position.y, transform.position.z);
            }
        }
    }

    public void Disconnect()
	{
        PhotonNetwork.LeaveRoom();
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetKills()
    {
        return killCount;
    }

    public int GetDeaths()
    {
        return deaths;
    }


    public KeyCode getKeySet()
	{
        return kcForward;
	}


    public void setCustom(int customValue)
	{
        trailInt = customValue;
        Debug.Log("Called");
	}

    /// <summary>
	/// set the player controls for this round
	/// </summary>
	/// <param name="key">the key to change to</param>
	/// <param name="keySet">the key that wants to be changed</param>
	public void setControl(KeyCode key, string keySet)
	{
        if (keySet.Equals("foward"))
		{
            kcForward = key;
        }
       else if (keySet.Equals("flip"))
        {
            kcShowBoat = key;
        }
        else if (keySet.Equals("backward"))
        {
            kcBack = key;
        }
        else if (keySet.Equals("left"))
        {
            kcLeft = key;
        }
        else if (keySet.Equals("right"))
        {
            kcRight = key;
        }
        else if (keySet.Equals("up"))
        {
            kcUp = key;
        }
        else if (keySet.Equals("down"))
        {
            kcDown = key;
        }
        else if (keySet.Equals("shoot"))
        {
            kcShoot = key;
        }
        else if (keySet.Equals("boost"))
        {
            kcBoost = key;
        }
        else if (keySet.Equals("score"))
        {
            kcScore = key;
        }
        else if (keySet.Equals("shop"))
        {
            kcShop = key;
        }
        else if (keySet.Equals("mine"))
        {
            kcMine = key;
        }
        else if (keySet.Equals("find"))
        {
            kcClosest = key;
        }
        
    }
}

[Serializable]//create gun to fire weapons.
public class Gun
{
    [SerializeField] private Transform gunTransform;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject mine;
    [SerializeField] private GameObject healthPack;

    public Transform getGunPosition()
    {
        return gunTransform;
    }

    public GameObject getBullet()
    {
        return bullet;
    }
    public GameObject getMine()
    {
        return mine;
    }
    public GameObject getHealthPack()
    {
        return healthPack;
    }
}


