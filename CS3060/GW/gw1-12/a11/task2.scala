object GW11Task2 {
    def main(args: Array[String]): Unit = {

        def foo2(list: List[String]) : String = {
            val list2 = list.map(word => word.charAt(0) + "-")
            val result  = list2.reduce(_+_)
            result
        }

        val list = List("12ab", "cde", "xyz")
        println(foo2(list))
    }
}