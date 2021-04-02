object GW11Task1 {
    def main(args: Array[String]): Unit = {

        println("\n---- TASK1 ---- ")
        //TASK1A
        def foo1a(x:List[Int]) : Int = {
            val y = x.map(num => scala.math.pow(2, num))
            val sum = y.reduce(_+_)
            sum.toInt
        }

        val list1 = List(3,5,8)

        val t1 = System.currentTimeMillis()
        println(foo1a(list1))
        val t2 = System.currentTimeMillis()

        //TASK1B
        def foo1b(x:List[Int]) : Int = {
            val y = x.par.map(num => scala.math.pow(2, num))
            val sum = y.reduce(_+_)
            sum.toInt
        }
        val t3 = System.currentTimeMillis()
        println(foo1b(list1))
        val t4 = System.currentTimeMillis()

        println("serial exec time = \t" + (t2 - t1))
        println("par exec time = \t" + (t4 - t3))



        //Task2
        println("\n---- TASK2 ---- ")
        def foo2(x: List[String]): String =
        {
            val y = x.map(x => x.head + "-")
            val z = y.reduce(_+_)
            z.slice(0, z.length - 1)
        }

        val list = List("12ab", "cde", "xyz")
        println(foo2(list))


        //TASK3
        println("\n---- TASK3 ---- ")
        def foo3(list: List[String]) : String = {
            val list2 = list.map(x => x.head + "-")
            val result = list2.fold("") (_+_)
            result.slice(0, result.length - 1) 
        }

        println(foo3(list))
        println("\n")

    }
}