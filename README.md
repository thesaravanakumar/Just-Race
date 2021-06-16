# Just Race - A 2D Micro Racing Game
<p align="center">
<a href="https://thesaravanakumar.itch.io/just-race">
  <img align="center"  src="https://user-images.githubusercontent.com/59575502/122107833-20949c00-ce39-11eb-9a64-d3061b00e807.png"/>
</a>
</p>
<p align="center">
A 2D-Top Down Micro Racing Game with 2 stage settings and a choice of 9 different cars, pursued by an AI Car but also an AI Chopper to chase you down. Car explosions, whirling chopper blades, exhaust fumes, and a trail left by a car are among the new animations. The game's different scenes include AI success, player win, loading, the main menu, and 18 distinct tracks for the two stages, all with sound effects.
</p>

<p align="center"><b> Click <a href = "https://thesaravanakumar.itch.io/just-race">here </a>to downl📀ad the Game 🐱‍👤</b>
<br/>
<a href="http://makeapullrequest.com">
  <img align="center"  src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"/>
</a>
</p>

<details><summary><b>Content:</b></summary>
  
* [Screenshots](#Screenshots)
* [UnityScene](#UnityScene)
* [How to Download](#How to Download)
* [LayOut](#LayOut)
</details>

<a name="Screenshots"></a>
### **Screenshots**
![imgonline-com-ua-twotoone-SjPbpYmz0Xeoa2](https://github.com/thesaravanakumar/Just-Race/blob/main/UnityFolderScripts/gif.gif)
![imgonline-com-ua-twotoone-u8ZB0kAyBsmC](https://user-images.githubusercontent.com/59575502/122147586-d16d5c00-ce76-11eb-9756-df0aa75755d6.jpg)

<a name="UnityScene"></a>
### **UnityScene**
![imgonline-com-ua-twotoone-P0kSd4uE37KRjRw](https://user-images.githubusercontent.com/59575502/122150780-fe703d80-ce7b-11eb-903f-b1f0d7b1318c.jpg)
![imgonline-com-ua-twotoone-TAN49VJlnMd0](https://user-images.githubusercontent.com/59575502/122150783-00d29780-ce7c-11eb-955c-16bd36b9d89a.jpg)
![imgonline-com-ua-twotoone-dhNjL72iii0](https://user-images.githubusercontent.com/59575502/122151075-80606680-ce7c-11eb-8b1b-f1e486cbc0dd.jpg)
![imgonline-com-ua-twotoone-hYgQpv4eYE2wDRY](https://user-images.githubusercontent.com/59575502/122151095-8bb39200-ce7c-11eb-945f-0c0364b36ab9.jpg)

<a name="How to Download"></a>
### **How to Download**
- **For Windows**
  - <b> Click <a href = "https://thesaravanakumar.itch.io/just-race">here </a>to download the Game.</b>
  - Clone this repository by using `git clone https://github.com/thesaravanakumar/Just-Race.git` and Double click **Just Race** to load the Game.
- **For Linux**
  - Clone this repository by using `git clone https://github.com/thesaravanakumar/Just-Race.git`
  - Extract **Linux Build.rar**
- **For WebGL**
  - <b> Click <a href = "https://thesaravanakumar.itch.io/just-race">here </a>to download the Game.</b>
  - Clone this repository by using `git clone https://github.com/thesaravanakumar/Just-Race.git` and Extract **WebGL Build.rar**.
  - Now Double Click **index.html** to load the Game.
 
<a name="LayOut"></a>
### **LayOut**
- **Animations**
  - Car Explosion
  - Chopper ( Blades, Heli Lights )
  - Loadig Screen ( Dots, Car )
  - Cone hit
  - 321 Go
  - Exhaust Smoke
  - Smoke Trial
  - Confetti on Victory Screen (Star, Confetti )
- **Scenes**
  - Main Menu
  - Track Select and Car Select Screen
  - Loading Screen ( Stage 1 + Stage 2)
  - Track 1 + Track 2 ( 9 + 9 Car )
  - Pause Screen
  - AI Victory Screen
  - Player Victory Screen
- **Buttons**
  - Start, Quit ( Main Menu )
  - Resume, Menu, Quit (Pause Screen)
  - Back, 2*9 Car select ( Track Select and Car Select Screen )
  - W, S, A, D, Esc (In-Game)
- **Sound Fx**
  - Car Explosion
  - Chopper Blades
  - Pull Over
  - Car Engine
  - Tyre Skid
  - Cone Hit
  - Track 1 + Track 2
  - 321Go
  - Player Victory
  - AI Victory
  - Main Menu
- **Scripts** ( Click <a href = "https://github.com/thesaravanakumar/Just-Race/tree/main/UnityFolderScripts">here </a>to find the Scripts.</b> )
  - GameManager
  - Speedometer
  - MainMenu
  - LapTime
  - HalfwayTrigger
  - LapCompleteTrigger
  - DelayStart
  - DamagePlayer
  - ConesFall
  - CallOut
  - AIScripts
    - AICars
    - AIMovement
    - AIPathway
    - AIVictoryTrigger
    - AIHealthManager
    - AIDamage
  - PlayerScripts
    - WheelController
    - MainCar
    - PlayerVictoryTrigger
    - HealthManager
    - CameraFollow
