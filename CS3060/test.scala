object Test {
    def main(args: Array[String]): Unit = 
    {
        val list1 = List(3,6,9)

        val y1 = list1 match {

        case x :: t => t.tail
        case _ => 2

        }
        println(list1)
        println(y1)

    }
}
