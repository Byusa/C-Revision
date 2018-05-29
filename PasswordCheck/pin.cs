using System;

class pin {
    private String Initialpin;
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
