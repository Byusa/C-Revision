//package pintest;

/*File Name: pin.java
Developers: <<Serge Jabo Byusa>>
Purpose: <<Checks if the input of the user is valid>>
Inputs: <<pin of user as string>> <<The user inputs his/her pin>>
Outputs: <<boolean value>> <<It ouputs true if it is valid and false if not>>
Modifications
==========
<<S.B.J>> <<17th Jan>> <<created and made a inputValidation() method better>>*/
public class pin {
    private String Initialpin;
    //pin constructor with Initialpin as input
    public pin(String Initialpin){
        this.Initialpin=Initialpin;
    }
    public String getInitialpin(){
        return Initialpin;
    }
    public void setInitialpin(String Initialpin){
        if(inputValidation(Initialpin)){
            this.Initialpin=Initialpin;
        }
    }
// Developers: <<Serge Jabo Byusa>>
// Purpose: <<Checks if the pin is a valid input or not>>
// Inputs: <<pin (String)>> <<You input the pin as a string>>
// Outputs: <<boolean>> <<outputs true if valid false otherwise>>
// Side-effects: <<None>>
// Special Notes: <<None>>
    public static boolean inputValidation(String pin) {
         boolean result=true;
         if(pin.contains("-")){
            result=false;
         }
         if (!pin.matches("[0-9]+") || pin.length()!=2) {
             result=false;
         }
        return result;
    }
}
