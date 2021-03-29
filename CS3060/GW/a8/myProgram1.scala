object Task1 {
    def main (args:Array[String])
    {
        val t = "123 abdf rtyu 34"
        val p = getLastWord(t)
        println(p)
        
        val s = "abc 123 sd 34"
        println(getLastChar(s))
    }

    def getLastWord (t : String): String =
    {
        val list= t.split("\\s+" ) 

        //(a) Get the size of list  
        val num = list.length;
        // (b) from list get the last item (i.e. the last word of t )
        val returnVal = list(num -1)
        //(c) return the last word of t
        return(returnVal)
    }	
    def getLastChar (a:String):Char =
    {
        //(a) Get the size of the string a
        val size = a.length;
        //(b) from string a get the last char by String library function charAt . (google it)
        val last = a.charAt(size-1)
        //(c) return the last char of s
        return(last)
    }



}


