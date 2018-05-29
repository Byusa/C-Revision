
using System;

public class PinMain {

    public static void main(String[] args) {
        String  inputCode = "00";
        pin pin1 = new pin(inputCode);
        pin1.setInitialpin(inputCode);
        Updatepin();
    }


    public static void Updatepin() {
        String oldpin="", Newpin="";
        String sc = Console.ReadLine();
        String  inputCode = "00";//
        pin pin1 = new pin(inputCode);//
        pin1.setInitialpin(inputCode);//

        Console.WriteLine("Please input your old pin:");
        String input = sc.nextLine();
        String Initialpin = pin1.getInitialpin();

        while(!(Initialpin.equals(input))){
            Console.WriteLine("That is not your old pin.");
            Console.WriteLine("Please input your old pin:");
            input = sc.nextLine();
            oldpin = input;
        }
        
        Console.WriteLine("Please input your New pin:");
        input = sc.nextLine();
        
        while ((!pin1.inputValidation(input))|| (Newpin.equals(oldpin))){
            Console.WriteLine("Invalid pin.");
            Console.WriteLine("Please input your new pin:");
            input = sc.nextLine();   
            Newpin = input;
        }
        
        Console.WriteLine("New pin confirmed.");
        Console.WriteLine("Your pin has been updated to " + input);

    }
    
}
