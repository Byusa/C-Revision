//package pinmain;
/*File Name: pin.java
Developers: <<Serge Jabo Byusa>>
Purpose: <<Has the updatePin method that interact with the user using scanner
            to update the pin>>
Inputs: <<None>> 
Outputs: <<None>> 
Modifications
==========
<<S.B.J>> <<17th Jan>> <<created and made a inputValidation() method better>>*/


import java.util.*;

public class PinMain {

    public static void main(String[] args) {
        String  inputCode = "00";
        pin pin1 = new pin(inputCode);
        pin1.setInitialpin(inputCode);
        Updatepin();
    }
// Developers: <<Serge Jabo Byusa>>
// Purpose: <<I'm updating the user's password>>
// Inputs: <<None>> 
// Outputs: <<New Pin>> <<Outputs the new pin after asking for the
                      //old pic and updates if the old pin is correct>>
// Side-effects: <<None>>
// Special Notes: <<Does not impose any restrictions on the characters for each field.
                    //ie:They can be any string>>

    
    public static void Updatepin() {
        String oldpin="", Newpin="";
        Scanner sc = new Scanner(System.in);
        String  inputCode = "00";//
        pin pin1 = new pin(inputCode);//
        pin1.setInitialpin(inputCode);//

        System.out.println("Please input your old pin:");
        String input = sc.nextLine();
        String Initialpin = pin1.getInitialpin();
        while(!(Initialpin.equals(input))){
            System.out.println("That is not your old pin.");
            System.out.println("Please input your old pin:");
            input = sc.nextLine();
            oldpin = input;
        }
        
        System.out.println("Please input your New pin:");
        input = sc.nextLine();
        
        while ((!pin1.inputValidation(input))|| (Newpin.equals(oldpin))){
            System.out.println("Invalid pin.");
            System.out.println("Please input your new pin:");
            input = sc.nextLine();   
            Newpin = input;
        }
        
        System.out.println("New pin confirmed.");
        System.out.println("Your pin has been updated to " + input);

    }
    
}
