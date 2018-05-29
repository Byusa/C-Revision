//package pintest;
/*File Name: pinTest.java
Developers: <<Serge Jabo Byusa>>
Purpose: <<Test method in PinMain.java by checking if they provide correct results or not>>
Inputs: <<Calls methods in PinMain.java>> <<Check if they give the correct value or not>>
Outputs: <<string and Boolean Value>> <<Output boolean value saying true or false and words(String)>>
Modifications
==========
<<S.B.J>> <<17th Jan>> <<increased more test cases>>*/


import java.util. * ;

public class PinTest {
	
// Developers: <<Serge Jabo Byusa>>
// Purpose: <<Generates random strings of any length given>>
// Inputs: <<length of the string>> <<You input the length of string you want your pin to be>
// Outputs: <<a pin (String value)>> <<Outputs a random pin>>
// Side-effects: <<None>>
// Special Notes: <<None>>
	public static String generateRandomPassword(int len) {

		String CapitalCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		String SmallCharacters = "abcdefghijklmnopqrstuvwxyz";
		String symbols = "!@#$%^&*_=+-/.?<>)";
		String numbers = "0123456789";

		String values = CapitalCharacters + SmallCharacters + numbers + symbols;

		Random randm = new Random();

		char[] password = new char[len];

		for (int i = 0; i < len; i++) {
			password[i] = values.charAt(randm.nextInt(values.length()));

		}
		String text = String.valueOf(password); //turn it to string and return it
		return text;
	}
	public static void main(String[] args) {
		String inputCode = "00", empty = " ";
		String str2 = "",str3 = "";
		int j = 0,length = 0;
                double db = 0.0;
		pin myPin = new pin(inputCode); //object myPin that has initial input as 00
		myPin.setInitialpin(inputCode);

		System.out.println("Test case for method <<inputValidation()>> : ");
		System.out.println("Below,is a great generalizarion of wrong values");
		for (int i = -120; i < 0; i++) {
			String str1 = Integer.toString(i);
			if ((i < 10) && (i >= 0)) {
				str2 = "0" + str1; //adding zero before any number to make it 00, 02 etc..
				System.out.println("Arguments: <<" + str2 + ">> Result: <<" + myPin.inputValidation(str2) + ">>");
			} else if (i < 0 && i > -10) { //editing inputs like -03
				char[] arr = str1.toCharArray();
				str3 = String.valueOf(arr[1]);
				str2 = "-" + "0" + str3;//adding -0 before any number to make it 00, 02 etc..
				System.out.println("Arguments: <<" + str2 + ">> Result: <<" + myPin.inputValidation(str2) + ">>");
			} else {
				System.out.println("Arguments: <<" + str1 + ">> Result: <<" + myPin.inputValidation(str1) + ">>");
			}
		}
                
		while (j <= 20 || length < 20) {
			System.out.println("Arguments: <<" + generateRandomPassword(length) + ">> Result: <<" + myPin.inputValidation(generateRandomPassword(length)) + ">>");
			j++;
			length++;
		}
		System.out.println("Arguments: <<  >> Result: <<" + myPin.inputValidation(empty) + ">>");
		System.out.println("Arguments: <<        >> Result: <<" + myPin.inputValidation(empty + empty + empty + empty) + ">>");
                
                Random randDecimals = new Random();
                for (int i = 0; i <5; i++) {
                     db = (randDecimals.nextDouble())*10;
                     db=Math.floor(db);
                     str2 =""+ db;
                    System.out.println("Arguments: <<"+ str2 +">> Result: <<" + myPin.inputValidation(str2) + ">>");
		}
                
		System.out.println("\n Below,is the only correct values");
		for (int i = 0; i < 100; i++) { 
			String str1 = Integer.toString(i);
			if ((i < 10) && (i >= 0)) {
				str2 = "0" + str1;//for inputs like  00, 01, 02
				System.out.println("Arguments: <<" + str2 + ">> Result: <<" + myPin.inputValidation(str2) + ">>");
			} else {
				System.out.println("Arguments: <<" + str1 + ">> Result: <<" + myPin.inputValidation(str1) + ">>");
			}
		}
	}
}
