object FinalExamBAnswer2 {
  def main(args: Array[String]): Unit = {

    def bar (list : List[Int], x : Integer, y : Integer) : List[Int] = {
        
        //val list2 = list.filter(num => !(num.startsWith(x) && num.endsWith(y)))
        //im not sure if i need to change the list of integers into a list of strings,
        //then check the list and then
        //change teh list of strings back into a list of integers
        // i can not find in the book or notes on how to chekc digits 
        val list2 : List [Int] = List(0)
    }

    val list1 : List [Int]= List(124, 421, 12, 43, 41, 1762, 4721)

    val list2 = bar(list1, 4, 1)

    println(list2)


  }
}