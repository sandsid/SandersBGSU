/**

        Sample command line argument program
        Spits out the arguments
        Compile/run snapshot below:
            run:
            next argument:123
            next argument:hello_world
            BUILD SUCCESSFUL (total time: 0 seconds) 
*/

package cmdlinearguments;

import java.io.*;
import sun.misc.*;
import java.net.*;

public class CmdLineArguments {


   public static void main (String[] args)   {
        //throws NoSuchAlgorithmException {

   for (int posn = 0; posn <  args.length; posn++)
    System.out.println ("next argument:" + args[posn] );
   }

}
