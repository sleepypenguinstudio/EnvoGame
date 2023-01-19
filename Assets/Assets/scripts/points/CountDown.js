var timerInSecond = 0;
private var levelTimer = 0.0;
private var updateTimer = false;
 
function Start()
{
	//var timerInSecond = PlayerPrefs.GetInt("Time In Second");
   updateTimer = true;
   levelTimer = 0.0;
}
 
function Update()
{
   if (updateTimer)  
      levelTimer += Time.deltaTime*1;
 
 
 /// float to int
 timerInSecond = Mathf.Round (levelTimer);
}
 
function LevelEnded()
{
   updateTimer = false;
 
   ///Save Time
   PlayerPrefs.SetInt("Time In Second", timerInSecond );
}