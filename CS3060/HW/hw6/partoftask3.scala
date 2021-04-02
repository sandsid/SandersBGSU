var list = t.map( num =>
if (count % 2 == 0){
    val num = t.lift(count +1)
    count = count + 1
    num
}
else {
    val num = t.lift(count -1)
    count = count + 1
    num
}
)


        var list = t
        var i = 0
        while(i < count){
            if (i % 2 == 0){
                list(i) = list(i+1)
                i = i + 1
            }
            else {
                list(i) = list(i-1)
                i = i + 1
            }
        }




        var list2 : List[Any] = Nil
        var list = t.map( num =>
            if (count % 2 == 0){
                val num = t.lift(count +1)
                count = count + 1
                list2 = list2 :+ num
                num
            }
            else {
                val num = t.lift(count -1)
                count = count + 1
                list2 = list2 :+ num
                num
            }
        )
        
        list2