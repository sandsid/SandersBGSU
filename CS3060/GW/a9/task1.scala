object GroupWorkNine {
    def main(args: Array[String]): Unit = 
    {
        val list1 = List("apple", "cat", "carad", "badminton")

        val list2 = list1.filter(word => !(word.startsWith("c") && word.endsWith("d")))

        println(list2)

        val list3:List[String]= list1.map( word => 
            if (word.contains("bad")) 
            {
                "replaced"
            }                         
       	    else 
            {
                word
            }
                                        
            )

        println(list3)
    }
}