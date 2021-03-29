import scala.io.Source

object Task2 {
    def main (args:Array[String])
    {
        var price = 0
        var maxPrice = 0
        var costliestitem : String = ""
        var lineCount = -1
        var penCost = 0

		//Below we get a file-handler for the file “data.txt”
        val fileHandler  =  Source.fromFile("data.txt")
		val lineIterator = fileHandler.getLines
	
		//Iterate over all lines

		for(line <- lineIterator){
            //(a) Increment the lineCount
            lineCount += 1
            //(b) Process the current line
            val item = line.split("\\s+")(0)

            //(c) you may need to change the price item in the third column from String to Int. 
                //If s is a string, then s.toInt gives the corresponding Int
			val price = (line.split("\\s+")(2)).toInt
            
            if (item == "Pen")
            {
                penCost = price
            }

            if (price > maxPrice) {
                costliestitem = item
                maxPrice = price
            }
		}
        // Print all the outputs
        println(lineCount)
        println(penCost)
        println(costliestitem)


		fileHandler.close()

    }
}