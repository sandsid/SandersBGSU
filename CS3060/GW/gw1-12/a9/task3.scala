object GroupWorkNine {
    def main(args: Array[String]): Unit = 
    {
        val list1 = List("apple", "cat", "carad", "badminton")

        foo(list1)

    }

    def foo (list1:List[String]) = 
    {
        var maxLength = ""
        var minLength = ""

        var list2 = list1.sortWith((x,y) => x.size > y.size)

        var first = list2.head
        var last = list2.last

        println(first)
        println(last)
    }
}