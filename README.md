# OUYA-inputmanager-for-unity
this is a very bares bone inputmanager for OUYA (old unity) 


//this is for the horizontal axis of the left/main stick
## public static float LeftStick_X()
		
//this is for the vertical axis of the left/main stick
## public static float LeftStick_Y()

//this returns a 2d vector (x, y);
## public static Vector2 MainStick_2D()
		
//this returns a 3d vector (x, 0, y);
## public static Vector3 MainStick_3D()
		
//this is for the horizontal axis of the right/second stick
## public static float RightStick_X()
		
//this is for the vertical axis of the right/second stick
## public static float RightStick_Y()
		
//this returns a 2d vector (x, y);
## public static Vector2 SecondStick_2D()
		
//this returns a 3d vector (x, 0, y);
## public static Vector3 SecondStick_3D()
		
//this is dpad axis (yes the ouya has dpad axis)
## public static float DpadHorizontal()
		
//this is dpad axis (ouya "only" supports axis on dpads)
## public static float DpadVertical()
       
//these are the button fuctions you are going to use
## public static bool ButtonDown(Button button)

## public static bool ButtonUP(Button button)

## public static bool ButtonHold(Button button)

//this is to check for any input except the ones
//you put on the ignore array
## public static bool AnyButton(Button[] ignore = null)

//check if the left stick moved
## public static bool AnyLeftAxis()

//check if the right stick moved
## public static bool AnyRightAxis()
	
